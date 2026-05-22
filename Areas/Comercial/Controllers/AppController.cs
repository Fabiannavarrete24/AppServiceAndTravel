using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;

namespace AppServiceAndTravel.Areas.Comercial.Controllers
{
    [Area("Comercial")]
    public class AppController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService _EmailService;
        private readonly IWhatsAppService _whatsAppService;

        public AppController(
            ApplicationDBContext context,
            UserManager<ApplicationUser> userManager,
            IEmailService EmailService,
            IWhatsAppService whatsAppService)
        {
            _context = context;
            _userManager = userManager;
            _EmailService = EmailService;
            _whatsAppService = whatsAppService;
        }

        // ── GET: Cotizacion/Index ─────────────────────────────────────────
        public async Task<IActionResult> Index(EstadoCotizacion? estado, string? busqueda, int pagina = 1)
        {
            const int itemsPorPagina = 10;

            var query = _context.Cotizaciones
                .Include(c => c.Cliente)
                .Include(c => c.UsuarioCreador)
                .Include(c => c.UsuarioAprobador)
                .AsQueryable();

            if (estado.HasValue)
                query = query.Where(c => c.Estado == estado.Value);

            if (!string.IsNullOrWhiteSpace(busqueda))
                query = query.Where(c =>
                    c.Cliente!.NombreCompleto.Contains(busqueda) ||
                    c.Origen.Contains(busqueda) ||
                    c.Destino.Contains(busqueda));

            var total = await query.CountAsync();
            var cotizaciones = await query
                .OrderByDescending(c => c.FechaCreacion)
                .Skip((pagina - 1) * itemsPorPagina)
                .Take(itemsPorPagina)
                .ToListAsync();

            ViewBag.EstadoFiltro = estado;
            ViewBag.Busqueda = busqueda;
            ViewBag.PaginaActual = pagina;
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)total / itemsPorPagina);
            ViewBag.TotalRegistros = total;

            // Contadores por estado para badges
            ViewBag.TotalPendientes = await _context.Cotizaciones.CountAsync(c => c.Estado == EstadoCotizacion.Pendiente);
            ViewBag.TotalAprobadas = await _context.Cotizaciones.CountAsync(c => c.Estado == EstadoCotizacion.Aprobada);
            ViewBag.TotalRechazadas = await _context.Cotizaciones.CountAsync(c => c.Estado == EstadoCotizacion.Rechazada);

            return View(cotizaciones);
        }

        // ── GET: Cotizacion/Create ────────────────────────────────────────
        //[Authorize(Rols = "Administrador,Coordinador,Operador")]
        public async Task<IActionResult> Create()
        {
            await CargarSelectListsAsync();
            return View();
        }

        // ── POST: Cotizacion/Create ───────────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador,Coordinador,Operador")]
        public async Task<IActionResult> Create(Cotizacion cotizacion)
        {
            if (!ModelState.IsValid)
            {
                await CargarSelectListsAsync();
                return View(cotizacion);
            }

            cotizacion.Estado = EstadoCotizacion.Pendiente;
            cotizacion.FechaCreacion = DateTime.Now;
            cotizacion.UsuarioCreadorId = Convert.ToInt32(_userManager.GetUserId(User));

            _context.Cotizaciones.Add(cotizacion);
            await _context.SaveChangesAsync();

            // Notificar al cliente
            var cliente = await _context.Clientes.FindAsync(cotizacion.ClienteId);
            if (cliente != null)
            {
                try
                {
                    await _EmailService.EnviarCotizacionCreadaAsync(cliente.correo, cliente.NombreCompleto, cotizacion);
                }
                catch (Exception ex)
                {
                    TempData["Warning"] = $"Cotización creada, pero hubo un error al enviar el correo: {ex.Message}";
                }
            }

            TempData["Success"] = $"Cotización #{cotizacion.Id:D6} creada exitosamente.";
            return RedirectToAction(nameof(Index));
        }

        // ── GET: Cotizacion/Details/{id} ──────────────────────────────────
        public async Task<IActionResult> Details(int id)
        {
            var cotizacion = await _context.Cotizaciones
                .Include(c => c.Cliente)
                .Include(c => c.UsuarioCreador)
                .Include(c => c.UsuarioAprobador)
                .Include(c => c.Servicio)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cotizacion == null) return NotFound();
            return View(cotizacion);
        }

        // ── GET: Cotizacion/Edit/{id} ─────────────────────────────────────
       // [Authorize(Rols = "Administrador,Coordinador")]
        public async Task<IActionResult> Edit(int id)
        {
            var cotizacion = await _context.Cotizaciones.FindAsync(id);
            if (cotizacion == null) return NotFound();

            if (cotizacion.Estado != EstadoCotizacion.Pendiente)
            {
                TempData["Error"] = "Solo se pueden editar cotizaciones en estado Pendiente.";
                return RedirectToAction(nameof(Index));
            }

            await CargarSelectListsAsync();
            return View(cotizacion);
        }

        // ── POST: Cotizacion/Edit/{id} ────────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador,Coordinador")]
        public async Task<IActionResult> Edit(int id, Cotizacion cotizacion)
        {
            if (id != cotizacion.Id) return NotFound();

            var cotizacionDb = await _context.Cotizaciones.FindAsync(id);
            if (cotizacionDb == null) return NotFound();

            if (cotizacionDb.Estado != EstadoCotizacion.Pendiente)
            {
                TempData["Error"] = "Solo se pueden editar cotizaciones en estado Pendiente.";
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                await CargarSelectListsAsync();
                return View(cotizacion);
            }

            cotizacionDb.ClienteId = cotizacion.ClienteId;
            cotizacionDb.Origen = cotizacion.Origen;
            cotizacionDb.Destino = cotizacion.Destino;
            cotizacionDb.FechaServicioRequerido = cotizacion.FechaServicioRequerido;
            cotizacionDb.DescripcionCarga = cotizacion.DescripcionCarga;
            cotizacionDb.NumPasajeros = cotizacion.NumPasajeros;
            cotizacionDb.ValorCotizado = cotizacion.ValorCotizado;

            await _context.SaveChangesAsync();
            TempData["Success"] = "Cotización actualizada.";
            return RedirectToAction(nameof(Index));
        }

        // ── POST: Cotizacion/Aprobar ──────────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador,Aprobador")]
        public async Task<IActionResult> Aprobar(int id, decimal? valorAprobado, string? observaciones)
        {
            var cotizacion = await _context.Cotizaciones
                .Include(c => c.Cliente)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cotizacion == null) return NotFound();

            if (cotizacion.Estado != EstadoCotizacion.Pendiente)
            {
                TempData["Error"] = "Solo se pueden aprobar cotizaciones en estado Pendiente.";
                return RedirectToAction(nameof(Details), new { id });
            }

            cotizacion.Estado = EstadoCotizacion.Aprobada;
            cotizacion.ValorAprobado = valorAprobado ?? cotizacion.ValorCotizado;
            cotizacion.ObservacionesAprobacion = observaciones;
            cotizacion.FechaAprobacion = DateTime.Now;
            cotizacion.UsuarioAprobadorId = Convert.ToInt32(_userManager.GetUserId(User));

            await _context.SaveChangesAsync();

            // Notificaciones
            if (cotizacion.Cliente != null)
            {
                try { await _EmailService.EnviarAprobacionCotizacionAsync(cotizacion.Cliente.correo, cotizacion.Cliente.NombreCompleto, cotizacion); }
                catch (Exception ex) { _logger.LogError(ex, "Error correo aprobación"); }

                try { await _whatsAppService.EnviarAprobacionCotizacionAsync(cotizacion.Cliente.Telefono, cotizacion.Cliente.NombreCompleto, cotizacion); }
                catch (Exception ex) { _logger.LogError(ex, "Error WhatsApp aprobación"); }
            }

            TempData["Success"] = $"Cotización #{cotizacion.Id:D6} aprobada exitosamente.";
            return RedirectToAction(nameof(Details), new { id });
        }

        // ── POST: Cotizacion/Rechazar ─────────────────────────────────────
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador,Aprobador")]
        public async Task<IActionResult> Rechazar(int id, string motivo)
        {
            var cotizacion = await _context.Cotizaciones
                .Include(c => c.Cliente)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cotizacion == null) return NotFound();

            cotizacion.Estado = EstadoCotizacion.Rechazada;
            cotizacion.ObservacionesRechazo = motivo;
            cotizacion.FechaAprobacion = DateTime.Now;
            cotizacion.UsuarioAprobadorId = Convert.ToInt32(_userManager.GetUserId(User));

            await _context.SaveChangesAsync();

            if (cotizacion.Cliente != null)
            {
                try { await _EmailService.EnviarRechazoCotizacionAsync(cotizacion.Cliente.correo, cotizacion.Cliente.NombreCompleto, cotizacion); }
                catch { /* log */ }
            }

            TempData["Warning"] = $"Cotización #{cotizacion.Id:D6} rechazada.";
            return RedirectToAction(nameof(Details), new { id });
        }

        // ── Helpers ───────────────────────────────────────────────────────
        private async Task CargarSelectListsAsync()
        {
            var clientes = await _context.Clientes
                .Where(c => c.Activo)
                .OrderBy(c => c.NombreCompleto)
                .ToListAsync();

            ViewBag.Clientes = new SelectList(clientes, "Id", "NombreCompleto");
        }

        private readonly ILogger<AppController> _logger =
            LoggerFactory.Create(b => b.AddConsole()).CreateLogger<AppController>();
    }
}
