using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AppServiceAndTravel.Areas.Operaciones.Controllers
{
    [Area("Operaciones")]
    public class AppController : Controller
    {
        //private readonly ApplicationDBContext _context;
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IEmailService _correoService;
        //private readonly IWhatsAppService _whatsAppService;
        //private readonly IVehiculoValidationService _validacionService;
        //private readonly ILogger<AppController> _logger;

        //public AppController(
        //    ApplicationDBContext context,
        //    UserManager<ApplicationUser> userManager,
        //    IEmailService correoService,
        //    IWhatsAppService whatsAppService,
        //    IVehiculoValidationService validacionService,
        //    ILogger<AppController> logger)
        //{
        //    _context = context;
        //    _userManager = userManager;
        //    _correoService = correoService;
        //    _whatsAppService = whatsAppService;
        //    _validacionService = validacionService;
        //    _logger = logger;
        //}

        //// ── GET: Servicio/Index ────────────────────────────────────────────
        //public async Task<IActionResult> Servicios(EstadoServicio? estado, string? busqueda, int pagina = 1)
        //{
        //    const int itemsPorPagina = 10;

        //    var query = _context.Servicios
        //        .Include(s => s.Cotizacion).ThenInclude(c => c!.Cliente)
        //        .Include(s => s.Vehiculo)
        //        .Include(s => s.Conductor)
        //        .AsQueryable();

        //    if (estado.HasValue)
        //        query = query.Where(s => s.Estado == estado.Value);

        //    if (!string.IsNullOrWhiteSpace(busqueda))
        //        query = query.Where(s =>
        //            s.Cotizacion!.Cliente!.NombreCompleto.Contains(busqueda) ||
        //            s.Vehiculo!.Placa.Contains(busqueda) ||
        //            s.Conductor!.NombreCompleto.Contains(busqueda));

        //    var total = await query.CountAsync();
        //    var servicios = await query
        //        .OrderByDescending(s => s.FechaCreacion)
        //        .Skip((pagina - 1) * itemsPorPagina)
        //        .Take(itemsPorPagina)
        //        .ToListAsync();

        //    ViewBag.EstadoFiltro = estado;
        //    ViewBag.Busqueda = busqueda;
        //    ViewBag.PaginaActual = pagina;
        //    ViewBag.TotalPaginas = (int)Math.Ceiling((double)total / itemsPorPagina);
        //    ViewBag.TotalRegistros = total;

        //    return View(servicios);
        //}

        //// ── GET: Servicio/Create ───────────────────────────────────────────
        ////[Authorize(Rols = "Administrador,Coordinador")]
        //public async Task<IActionResult> CrearServicios(int? cotizacionId)
        //{
        //    await CargarSelectListsAsync(cotizacionId);

        //    var servicio = new Servicio();
        //    if (cotizacionId.HasValue)
        //    {
        //        var cot = await _context.Cotizaciones
        //            .Include(c => c.Cliente)
        //            .FirstOrDefaultAsync(c => c.Id == cotizacionId && c.Estado == EstadoCotizacion.Aprobada);

        //        if (cot != null)
        //        {
        //            servicio.CotizacionId = cot.Id;
        //            servicio.FechaServicio = cot.FechaServicioRequerido;
        //            ViewBag.CotizacionPreseleccionada = cot;
        //        }
        //    }

        //    return View(servicio);
        //}

        //// ── POST: Servicio/Create ──────────────────────────────────────────
        //[HttpPost, ValidateAntiForgeryToken]
        ////[Authorize(Rols = "Administrador,Coordinador")]
        //public async Task<IActionResult> CrearServicios(Servicio servicio)
        //{
        //    // Verificar que la cotización esté aprobada y sin servicio
        //    var cotizacion = await _context.Cotizaciones
        //        .Include(c => c.Cliente)
        //        .Include(c => c.Servicio)
        //        .FirstOrDefaultAsync(c => c.Id == servicio.CotizacionId);

        //    if (cotizacion == null)
        //    {
        //        ModelState.AddModelError("CotizacionId", "Cotización no encontrada.");
        //    }
        //    else if (cotizacion.Estado != EstadoCotizacion.Aprobada)
        //    {
        //        ModelState.AddModelError("CotizacionId", "Solo se pueden generar servicios para cotizaciones aprobadas.");
        //    }
        //    else if (cotizacion.Servicio != null)
        //    {
        //        ModelState.AddModelError("CotizacionId", "Esta cotización ya tiene un servicio generado.");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        await CargarSelectListsAsync(servicio.CotizacionId);
        //        return View(servicio);
        //    }

        //    // ── Validar vehículo y conductor ─────────────────────────────
        //    var usuarioId = _userManager.GetUserId(User);
        //    var validacion = await _validacionService.ValidarParaServicioAsync(
        //        servicio.VehiculoId, servicio.ConductorId, usuarioId);

        //    if (!validacion.Exitoso)
        //    {
        //        foreach (var error in validacion.Errores)
        //            ModelState.AddModelError(string.Empty, error);

        //        await CargarSelectListsAsync(servicio.CotizacionId);

        //        ViewBag.ErroresValidacion = validacion.Errores;
        //        ViewBag.AdvertenciasValidacion = validacion.Advertencias;
        //        return View(servicio);
        //    }

        //    // Pasar advertencias a la vista de confirmadaación si las hay
        //    if (validacion.Advertencias.Count > 0)
        //        TempData["Advertencias"] = string.Join("|", validacion.Advertencias);

        //    // ── Crear servicio ────────────────────────────────────────────
        //    servicio.Estado = EstadoServicio.Programado;
        //    servicio.FechaCreacion = DateTime.Now;
        //    servicio.UsuarioCreadorId = usuarioId;

        //    _context.Servicios.Add(servicio);
        //    await _context.SaveChangesAsync();

        //    // Actualizar validación con ID del servicio
        //    var ultimaValidacion = await _context.ValidacionesVehiculo
        //        .Where(v => v.VehiculoId == servicio.VehiculoId && v.ServicioId == null)
        //        .OrderByDescending(v => v.FechaValidacion)
        //        .FirstOrDefaultAsync();

        //    if (ultimaValidacion != null)
        //    {
        //        ultimaValidacion.ServicioId = servicio.Id;
        //        await _context.SaveChangesAsync();
        //    }

        //    // ── Enviar notificaciones ────────────────────────────────────
        //    var servicioCompleto = await _context.Servicios
        //        .Include(s => s.Cotizacion).ThenInclude(c => c!.Cliente)
        //        .Include(s => s.Vehiculo)
        //        .Include(s => s.Conductor)
        //        .FirstAsync(s => s.Id == servicio.Id);

        //    var cliente = cotizacion!.Cliente;
        //    bool correoOk = false, wpOk = false;

        //    if (cliente != null)
        //    {
        //        try
        //        {
        //            await _correoService.EnviarconfirmadaacionServicioAsync(
        //                cliente.correo, cliente.NombreCompleto, servicioCompleto);
        //            correoOk = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "Error al enviar correo de confirmadaación");
        //        }

        //        try
        //        {
        //            wpOk = await _whatsAppService.EnviarconfirmadaacionServicioAsync(
        //                cliente.Telefono, servicioCompleto);
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "Error al enviar WhatsApp de confirmadaación");
        //        }
        //    }

        //    // Marcar notificaciones
        //    servicioCompleto.NotificacioncorreoEnviada = correoOk;
        //    servicioCompleto.NotificacionWhatsAppEnviada = wpOk;
        //    servicioCompleto.FechaNotificacion = DateTime.Now;
        //    await _context.SaveChangesAsync();

        //    TempData["Success"] = $"Servicio #{servicio.Id:D6} generado exitosamente. " +
        //        $"correo: {(correoOk ? "✓" : "✗")} | WhatsApp: {(wpOk ? "✓" : "✗")}";

        //    return RedirectToAction(nameof(DetallesServicios), new { id = servicio.Id });
        //}

        //// ── GET: Servicio/Details ──────────────────────────────────────────
        //public async Task<IActionResult> DetallesServicios(int id)
        //{
        //    var servicio = await _context.Servicios
        //        .Include(s => s.Cotizacion).ThenInclude(c => c!.Cliente)
        //        .Include(s => s.Vehiculo)
        //        .Include(s => s.Conductor)
        //        .Include(s => s.UsuarioCreador)
        //        .FirstOrDefaultAsync(s => s.Id == id);

        //    if (servicio == null) return NotFound();
        //    return View(servicio);
        //}

        //// ── POST: Cambiar estado del servicio ─────────────────────────────
        //[HttpPost, ValidateAntiForgeryToken]
        ////[Authorize(Rols = "Administrador,Coordinador")]
        //public async Task<IActionResult> CambiarEstado(int id, EstadoServicio nuevoEstado, string? observaciones)
        //{
        //    var servicio = await _context.Servicios.FindAsync(id);
        //    if (servicio == null) return NotFound();

        //    servicio.Estado = nuevoEstado;
        //    if (!string.IsNullOrWhiteSpace(observaciones))
        //        servicio.Observaciones = observaciones;

        //    await _context.SaveChangesAsync();

        //    TempData["Success"] = $"Estado del servicio actualizado a: {nuevoEstado}.";
        //    return RedirectToAction(nameof(DetallesServicios), new { id });
        //}

        //// ── AJAX: Validar vehículo antes de crear ─────────────────────────
        //[HttpPost]
        //public async Task<IActionResult> ValidarVehiculo(int vehiculoId, int conductorId)
        //{
        //    var resultado = await _validacionService.ValidarParaServicioAsync(vehiculoId, conductorId);
        //    return Json(new
        //    {
        //        exitoso = resultado.Exitoso,
        //        errores = resultado.Errores,
        //        advertencias = resultado.Advertencias,
        //        vehiculo = resultado.Vehiculo == null ? null : new
        //        {
        //            placa = resultado.Vehiculo.Placa,
        //            marca = resultado.Vehiculo.Marca,
        //            modelo = resultado.Vehiculo.Modelo
        //        }
        //    });
        //}

        //// ── Helpers ───────────────────────────────────────────────────────
        //private async Task CargarSelectListsAsync(int? cotizacionIdPreseleccionada = null)
        //{
        //    // Solo cotizaciones aprobadas sin servicio
        //    var cotizaciones = await _context.Cotizaciones
        //        .Include(c => c.Cliente)
        //        .Where(c => c.Estado == EstadoCotizacion.Aprobada && c.Servicio == null)
        //        .OrderByDescending(c => c.FechaAprobacion)
        //        .Select(c => new
        //        {
        //            c.Id,
        //            Display = $"#{c.Id:D6} - {c.Cliente!.NombreCompleto} | {c.Origen} → {c.Destino} ({c.FechaServicioRequerido:dd/MM/yy})"
        //        })
        //        .ToListAsync();

        //    ViewBag.Cotizaciones = new SelectList(cotizaciones, "Id", "Display", cotizacionIdPreseleccionada);

        //    var vehiculos = await _context.Vehiculos
        //        .Where(v => v.Estado == EstadoVehiculo.Activo)
        //        .OrderBy(v => v.Placa)
        //        .Select(v => new
        //        {
        //            v.Id,
        //            Display = $"{v.Placa} - {v.Marca} {v.Modelo} ({v.Anio})"
        //        })
        //        .ToListAsync();

        //    ViewBag.Vehiculos = new SelectList(vehiculos, "Id", "Display");

        //    var conductores = await _context.Conductores
        //        .Where(c => c.Activo)
        //        .OrderBy(c => c.NombreCompleto)
        //        .ToListAsync();

        //    ViewBag.Conductores = new SelectList(conductores, "Id", "NombreCompleto");
        //}

        #region Conductores
        public IActionResult Conductores()
        {
            return View();
        }
        public IActionResult CrearConductor() { 
            return View();
        }
        #endregion
        #region Servicios
        public IActionResult CrearServicio()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
        public IActionResult DetallesServicios()
        {
            return View();
        }
        #endregion
        #region vehiculos
        public IActionResult Vehiculos()
        {
            return View();
        }
        public IActionResult CrearVehiculo()
        {
            return View();
        }
        public IActionResult DetallesVehiculos()
        {
            return View();
        }

        #endregion
        #region proveedores
        public IActionResult CrearProveedor()
        {
            return View();
        }
        public IActionResult Proveedores()
        {
            return View();
        }        
        #endregion
    }
}
