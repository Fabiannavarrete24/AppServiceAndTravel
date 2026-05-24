using AppServiceAndTravel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;

namespace AppServiceAndTravel.Controllers
{
    [Area("Operaciones")]
    public class VehiculoController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<VehiculoController> _logger;

        public VehiculoController(ApplicationDBContext context, ILogger<VehiculoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /Vehiculo
        public async Task<IActionResult> Index(string? busqueda, EstadoVehiculo? estado, int pagina = 1)
        {
            const int items = 10;
            var hoy = DateTime.Today;
            var alerta = hoy.AddDays(30);

            var q = _context.Vehiculos.AsQueryable();

            if (!string.IsNullOrWhiteSpace(busqueda))
                q = q.Where(v => v.Placa.Contains(busqueda) || v.Marca.Contains(busqueda) || v.Modelo.Contains(busqueda));

            if (estado.HasValue) q = q.Where(v => v.Estado == estado.Value);

            var total = await q.CountAsync();
            var lista = await q.OrderBy(v => v.Placa).Skip((pagina - 1) * items).Take(items).ToListAsync();

            ViewBag.Busqueda = busqueda;
            ViewBag.EstadoFiltro = estado;
            ViewBag.PaginaActual = pagina;
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)total / items);
            ViewBag.TotalRegistros = total;

            ViewBag.TotalActivos = await _context.Vehiculos.CountAsync(v => v.Estado == EstadoVehiculo.Activo);
            ViewBag.TotalInactivos = await _context.Vehiculos.CountAsync(v => v.Estado == EstadoVehiculo.Inactivo);
            ViewBag.TotalMantenimiento = await _context.Vehiculos.CountAsync(v => v.Estado == EstadoVehiculo.EnMantenimiento);
            ViewBag.TotalConAlerta = await _context.Vehiculos.CountAsync(v =>
                v.FechaVencimientoSOAT <= alerta ||
                v.FechaVencimientoTecnoMecanica <= alerta ||
                v.FechaVencimientoSeguro <= alerta);

            return View(lista);
        }

        // GET: /Vehiculo/Create
        //[Authorize(Rols = "Administrador,Coordinador")]
        public IActionResult Create() => View(new Vehiculos { FechaVencimientoSOAT = DateTime.Today.AddYears(1), FechaVencimientoTecnoMecanica = DateTime.Today.AddYears(2), FechaVencimientoSeguro = DateTime.Today.AddYears(1) });

        // POST: /Vehiculo/Create
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador,Coordinador")]
        public async Task<IActionResult> Create(Vehiculos vehiculo)
        {
            if (await _context.Vehiculos.AnyAsync(v => v.Placa == vehiculo.Placa))
                ModelState.AddModelError("Placa", "Ya existe un vehículo con esa placa.");

            if (!ModelState.IsValid) return View(vehiculo);

            _context.Vehiculos.Add(vehiculo);
            await _context.SaveChangesAsync();
            TempData["Success"] = $"Vehículo {vehiculo.Placa} registrado correctamente.";
            return RedirectToAction(nameof(Index));
        }

        // GET: /Vehiculo/Edit/{id}
        //[Authorize(Rols = "Administrador,Coordinador")]
        public async Task<IActionResult> Edit(int id)
        {
            var v = await _context.Vehiculos.FindAsync(id);
            if (v == null) return NotFound();
            return View(v);
        }

        // POST: /Vehiculo/Edit/{id}
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador,Coordinador")]
        public async Task<IActionResult> Edit(int id, Vehiculos vehiculo)
        {
            if (id != vehiculo.idVehiculo) return NotFound();

            if (await _context.Vehiculos.AnyAsync(v => v.Placa == vehiculo.Placa && v.idVehiculo != id))
                ModelState.AddModelError("Placa", "Ya existe otro vehículo con esa placa.");

            if (!ModelState.IsValid) return View(vehiculo);

            _context.Update(vehiculo);
            await _context.SaveChangesAsync();
            TempData["Success"] = $"Vehículo {vehiculo.Placa} actualizado.";
            return RedirectToAction(nameof(Index));
        }

        // GET: /Vehiculo/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var v = await _context.Vehiculos.Include(x => x.Servicios).ThenInclude(s => s.Cotizacion).ThenInclude(c => c!.Cliente).FirstOrDefaultAsync(x => x.idVehiculo == id);
            if (v == null) return NotFound();
            return View(v);
        }

        // POST: /Vehiculo/Delete/{id}
        [HttpPost, ValidateAntiForgeryToken]
        //[Authorize(Rols = "Administrador")]
        public async Task<IActionResult> Delete(int id)
        {
            var v = await _context.Vehiculos.Include(x => x.Servicios).FirstOrDefaultAsync(x => x.idVehiculo == id);
            if (v == null) return NotFound();

            if (v.Servicios.Any())
            {
                TempData["Error"] = "No se puede eliminar: el vehículo tiene servicios asociados. Márquelo como Inactivo.";
                return RedirectToAction(nameof(Index));
            }

            _context.Vehiculos.Remove(v);
            await _context.SaveChangesAsync();
            TempData["Success"] = $"Vehículo {v.Placa} eliminado.";
            return RedirectToAction(nameof(Index));
        }
    }
}