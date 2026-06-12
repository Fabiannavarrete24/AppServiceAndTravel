using AppServiceAndTravel.Areas.Comercial.ViewModels;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Helpers.Filters;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.EntityFrameworkCore;

namespace AppServiceAndTravel.Areas.Operaciones.Services
{
    public interface IServiciosService
    {
        Task<List<DetalleCotizacionComboVM>> DetallesCotizacion(int idCotizacion);
        Task<DetalleServicioVM?> DetalleServicio(int idDetalleCotizacion);
        List<TiposServiciosVM> ObtenerTiposServicios();
        Task<List<object>> ObtenerDetallesDisponibles();
        Task<(bool success, string message, object? data)> ObtenerDetalleCotizacion(int idDetalle);
        Task<(bool success, string message)> CrearServicio(AddServicioVM model, int userId);
        Task<ApiResponse<List<ServicioListadoVM>>> ObtenerServicios(ServiciosFilterVM filter);
    }
    public class ServiciosService : IServiciosService
    {
        private readonly ApplicationDBContext _context;
        private readonly IEmailService _correoService;
        private readonly IWhatsAppService _whatsAppService;
        private readonly IVehiculoService _vehiculoService;

        public ServiciosService(ApplicationDBContext context, IEmailService correoService, IWhatsAppService whatsAppService, IVehiculoService vehiculoService)
        {
            _context = context;
            _correoService = correoService;
            _whatsAppService = whatsAppService;
            _vehiculoService = vehiculoService;
        }
        public async Task<List<DetalleCotizacionComboVM>> DetallesCotizacion(int idCotizacion)
        {
            return await _context.DetalleCotizacion
                .Include(x => x.TipoVehiculo)
                .Where(x =>
                    x.idCotizacion == idCotizacion &&
                    x.idServicio == null)
                .Select(x => new DetalleCotizacionComboVM
                {
                    idDetalleCotizacion = x.idDetalleCotizacion,

                    idCotizacion = x.idCotizacion,

                    origen = x.Origen,

                    destino = x.Destino,

                    tipoVehiculo = x.TipoVehiculo!.descripcion,

                    fechaInicio = x.FechaServicioInicio,

                    fechaFin = x.FechaServicioFin,

                    descripcion =
                        x.Origen +
                        " → " +
                        x.Destino +
                        " | " +
                        x.TipoVehiculo.descripcion
                })
                .ToListAsync();
        }
        public async Task<DetalleServicioVM?> DetalleServicio(int idDetalleCotizacion)
        {
            return await _context.DetalleCotizacion
                .Include(x => x.Cotizacion)
                    .ThenInclude(x => x!.Cliente)
                .Include(x => x.TipoVehiculo)
                .Where(x => x.idDetalleCotizacion == idDetalleCotizacion)
                .Select(x => new DetalleServicioVM
                {
                    idCotizacion = x.idCotizacion,
                    idDetalleCotizacion = x.idDetalleCotizacion,
                    idTipoVehiculo = x.idTipoVehiculo,
                    cliente = x.Cotizacion!.Cliente!.RazonSocial,
                    origen = x.Origen,
                    destino = x.Destino,
                    tipoVehiculo = x.TipoVehiculo!.descripcion,
                    fechaInicioServicio = x.FechaServicioInicio,
                    fechaFinServicio = x.FechaServicioFin,
                    numPasajeros = x.NumPasajeros,
                    cantidad = x.Cantidad,
                    valorUnitario = x.ValorUnitario,
                    valorTotal = x.ValorTotal,
                    observaciones =
                        x.Observaciones
                })
                .FirstOrDefaultAsync();
        }
        public List<TiposServiciosVM> ObtenerTiposServicios()
        {
            var TiposServiciosVM = _context.TiposServicios
                .OrderBy(r => r.descripcion)
                .Select(r => new TiposServiciosVM
                {
                    id = r.idTipoServicio,
                    descripcion = r.descripcion
                })
                .ToList();

            return TiposServiciosVM;
        }
        public async Task<List<object>> ObtenerDetallesDisponibles()
        {
            return await _context.DetalleCotizacion
                .Include(x => x.Cotizacion)
                    .ThenInclude(x => x!.Cliente)

                .Where(x =>
                    x.Cotizacion!.Estado == EstadoCotizacion.Aprobada &&
                    !x.Servicios.Any())

                .Select(x => new
                {
                    idDetalle = x.idDetalleCotizacion,

                    texto =
                        $"Cot #{x.idCotizacion:D6} - " +
                        $"{x.Origen} → {x.Destino} - " +
                        $"{x.Cotizacion!.Cliente!.RazonSocial}"
                })
                .ToListAsync<object>();
        }
        public async Task<(bool success, string message, object? data)> ObtenerDetalleCotizacion(int idDetalle)
        {
            var detalle = await _context.DetalleCotizacion

                .Include(x => x.Cotizacion)
                    .ThenInclude(x => x!.Cliente)

                .Include(x => x.TipoServicio)
                .Include(x => x.TipoVehiculo)

                .FirstOrDefaultAsync(x =>
                    x.idDetalleCotizacion == idDetalle);

            if (detalle == null)
                return (false, "Detalle no encontrado", null);

            return
            (
                true,
                "",
                new
                {
                    detalle.idDetalleCotizacion,

                    Cliente = detalle.Cotizacion!.Cliente!.RazonSocial,

                    detalle.Origen,
                    detalle.Destino,

                    TipoServicio =
                        detalle.TipoServicio!.descripcion,

                    TipoVehiculo =
                        detalle.TipoVehiculo!.descripcion,

                    detalle.FechaServicioInicio,
                    detalle.FechaServicioFin,

                    detalle.NumPasajeros,

                    detalle.ValorTotal
                }
            );
        }
        public async Task<(bool success, string message)> CrearServicio(AddServicioVM model, int userId)
        {
            var detalle =
                await _context.DetalleCotizacion

                .Include(x => x.Cotizacion)
                    .ThenInclude(x => x!.Cliente)

                .FirstOrDefaultAsync(x =>
                    x.idDetalleCotizacion ==
                    model.idDetalleCotizacion);

            if (detalle == null)
                return (false, "Detalle no encontrado");

            var servicio = new Servicios
            {
                idDetalleCotizacion = model.idDetalleCotizacion,
                idVehiculo = model.idVehiculo,
                idConductor = model.idConductor,
                FechaServicio = model.FechaServicio,
                Observaciones = model.Observaciones,
                Estado = EstadoServicio.Programado,
                FechaCreacion = DateTime.Now,
                idUsuarioCreador = userId
            };

            _context.Servicios.Add(servicio);

            await _context.SaveChangesAsync();

            return
            (
                true,
                $"Servicio #{servicio.idServicio:D6} creado"
            );
        }
        public async Task<ApiResponse<List<ServicioListadoVM>>> ObtenerServicios(ServiciosFilterVM filter)
        {
            var query = _context.Servicios

                .Include(x => x.DetalleCotizacion)
                    .ThenInclude(x => x!.Cotizacion)
                        .ThenInclude(x => x!.Cliente)

                .Include(x => x.Conductor)

                .Include(x => x.Vehiculo)

                .AsQueryable();

            var total = await query.CountAsync();

            var data = await query

                .OrderByDescending(x => x.FechaServicio)

                .Select(x => new ServicioListadoVM
                {
                    idServicio = x.idServicio,

                    idCotizacion =
                        x.DetalleCotizacion!.idCotizacion,

                    Cliente =
                        x.DetalleCotizacion
                            .Cotizacion!
                            .Cliente!
                            .RazonSocial,

                    Origen =
                        x.DetalleCotizacion.Origen,

                    Destino =
                        x.DetalleCotizacion.Destino,

                    Vehiculo =
                        x.Vehiculo!.Placa,

                    Conductor =
                        x.Conductor!.NombreCompleto,

                    FechaServicio =
                        x.FechaServicio,

                    Estado =
                        x.Estado.ToString(),

                    CorreoEnviado =
                        x.NotificacioncorreoEnviada,

                    WhatsAppEnviado =
                        x.NotificacionWhatsAppEnviada
                })
                .ToListAsync();

            return new ApiResponse<List<ServicioListadoVM>>
            {
                Success = true,
                Data = data
            };
        }
        //         // ── GET: Servicio/Index ────────────────────────────────────────────
        // //         public async List<Servicios> ObtenerServicios(EstadoServicio? estado, string? busqueda, int pagina = 1)
        // //         {
        // //             const int itemsPorPagina = 10;

        // //             var query = _context.Servicios
        // //                 .Include(s => s.DetalleCotizacion)
        // //      .ThenInclude(d => d.Cotizacion)
        // //          .ThenInclude(c => c.Cliente)
        // //          .Include(s => s.DetalleCotizacion)
        // //      .ThenInclude(d => d.TipoVehiculo)

        // //  .Include(s => s.DetalleCotizacion)
        // //      .ThenInclude(d => d.TipoServicio)
        // //                 .Include(s => s.Vehiculo)
        // //                 .Include(s => s.Conductor)
        // //                 .AsQueryable();

        // //             if (estado.HasValue)
        // //                 query = query.Where(s => s.Estado == estado.Value);

        // //             if (!string.IsNullOrWhiteSpace(busqueda))
        // //             {
        // //                 query = query.Where(s =>
        // //                     s.DetalleCotizacion!.Cotizacion!.Cliente!.RazonSocial.Contains(busqueda) ||
        // //                     s.Vehiculo!.Placa.Contains(busqueda) ||
        // //                     s.Conductor!.NombreCompleto.Contains(busqueda)
        // //                 );
        // //             }

        // //             var total = await query.CountAsync();
        // //             var servicios = await query
        // //                 .OrderByDescending(s => s.FechaCreacion)
        // //                 .Skip((pagina - 1) * itemsPorPagina)
        // //                 .Take(itemsPorPagina)
        // //                 .ToListAsync();

        // //             return servicios;
        // //         }

        //         // ── GET: Servicio/Create ───────────────────────────────────────────
        //         //[Authorize(Rols = "Administrador,Coordinador")]
        //         public async Task<IActionResult> CrearServicios(int? cotizacionId)
        //         {
        //             await CargarSelectListsAsync(cotizacionId);

        //             var servicio = new Servicio();
        //             if (cotizacionId.HasValue)
        //             {
        //                 var cot = await _context.Cotizaciones
        //                     .Include(c => c.Cliente)
        //                     .FirstOrDefaultAsync(c => c.Id == cotizacionId && c.Estado == EstadoCotizacion.Aprobada);

        //                 if (cot != null)
        //                 {
        //                     servicio.CotizacionId = cot.Id;
        //                     servicio.FechaServicio = cot.FechaServicioRequerido;
        //                     ViewBag.CotizacionPreseleccionada = cot;
        //                 }
        //             }

        //             return View(servicio);
        //         }

        //         // ── POST: Servicio/Create ──────────────────────────────────────────
        //         [HttpPost, ValidateAntiForgeryToken]
        //         //[Authorize(Rols = "Administrador,Coordinador")]
        //         public async Task<IActionResult> CrearServicios(Servicio servicio)
        //         {
        //             // Verificar que la cotización esté aprobada y sin servicio
        //             var cotizacion = await _context.Cotizaciones
        //                 .Include(c => c.Cliente)
        //                 .Include(c => c.Servicio)
        //                 .FirstOrDefaultAsync(c => c.Id == servicio.CotizacionId);

        //             if (cotizacion == null)
        //             {
        //                 ModelState.AddModelError("CotizacionId", "Cotización no encontrada.");
        //             }
        //             else if (cotizacion.Estado != EstadoCotizacion.Aprobada)
        //             {
        //                 ModelState.AddModelError("CotizacionId", "Solo se pueden generar servicios para cotizaciones aprobadas.");
        //             }
        //             else if (cotizacion.Servicio != null)
        //             {
        //                 ModelState.AddModelError("CotizacionId", "Esta cotización ya tiene un servicio generado.");
        //             }

        //             if (!ModelState.IsValid)
        //             {
        //                 await CargarSelectListsAsync(servicio.CotizacionId);
        //                 return View(servicio);
        //             }

        //             // ── Validar vehículo y conductor ─────────────────────────────
        //             var usuarioId = _userManager.GetUserId(User);
        //             var validacion = await _validacionService.ValidarParaServicioAsync(
        //                 servicio.VehiculoId, servicio.ConductorId, usuarioId);

        //             if (!validacion.Exitoso)
        //             {
        //                 foreach (var error in validacion.Errores)
        //                     ModelState.AddModelError(string.Empty, error);

        //                 await CargarSelectListsAsync(servicio.CotizacionId);

        //                 ViewBag.ErroresValidacion = validacion.Errores;
        //                 ViewBag.AdvertenciasValidacion = validacion.Advertencias;
        //                 return View(servicio);
        //             }

        //             // Pasar advertencias a la vista de confirmadaación si las hay
        //             if (validacion.Advertencias.Count > 0)
        //                 TempData["Advertencias"] = string.Join("|", validacion.Advertencias);

        //             // ── Crear servicio ────────────────────────────────────────────
        //             servicio.Estado = EstadoServicio.Programado;
        //             servicio.FechaCreacion = DateTime.Now;
        //             servicio.UsuarioCreadorId = usuarioId;

        //             _context.Servicios.Add(servicio);
        //             await _context.SaveChangesAsync();

        //             // Actualizar validación con ID del servicio
        //             var ultimaValidacion = await _context.ValidacionesVehiculo
        //                 .Where(v => v.VehiculoId == servicio.VehiculoId && v.ServicioId == null)
        //                 .OrderByDescending(v => v.FechaValidacion)
        //                 .FirstOrDefaultAsync();

        //             if (ultimaValidacion != null)
        //             {
        //                 ultimaValidacion.ServicioId = servicio.Id;
        //                 await _context.SaveChangesAsync();
        //             }

        //             // ── Enviar notificaciones ────────────────────────────────────
        //             var servicioCompleto = await _context.Servicios
        //                 .Include(s => s.Cotizacion).ThenInclude(c => c!.Cliente)
        //                 .Include(s => s.Vehiculo)
        //                 .Include(s => s.Conductor)
        //                 .FirstAsync(s => s.Id == servicio.Id);

        //             var cliente = cotizacion!.Cliente;
        //             bool correoOk = false, wpOk = false;

        //             if (cliente != null)
        //             {
        //                 try
        //                 {
        //                     await _correoService.EnviarconfirmadaacionServicioAsync(
        //                         cliente.correo, cliente.NombreCompleto, servicioCompleto);
        //                     correoOk = true;
        //                 }
        //                 catch (Exception ex)
        //                 {
        //                     _logger.LogError(ex, "Error al enviar correo de confirmadaación");
        //                 }

        //                 try
        //                 {
        //                     wpOk = await _whatsAppService.EnviarconfirmadaacionServicioAsync(
        //                         cliente.Telefono, servicioCompleto);
        //                 }
        //                 catch (Exception ex)
        //                 {
        //                     _logger.LogError(ex, "Error al enviar WhatsApp de confirmadaación");
        //                 }
        //             }

        //             // Marcar notificaciones
        //             servicioCompleto.NotificacioncorreoEnviada = correoOk;
        //             servicioCompleto.NotificacionWhatsAppEnviada = wpOk;
        //             servicioCompleto.FechaNotificacion = DateTime.Now;
        //             await _context.SaveChangesAsync();

        //             TempData["Success"] = $"Servicio #{servicio.Id:D6} generado exitosamente. " +
        //                 $"correo: {(correoOk ? "✓" : "✗")} | WhatsApp: {(wpOk ? "✓" : "✗")}";

        //             return RedirectToAction(nameof(DetallesServicios), new { id = servicio.Id });
        //         }

        //         // ── GET: Servicio/Details ──────────────────────────────────────────
        //         public async Task<IActionResult> DetallesServicios(int id)
        //         {
        //             var servicio = await _context.Servicios
        //                 .Include(s => s.Cotizacion).ThenInclude(c => c!.Cliente)
        //                 .Include(s => s.Vehiculo)
        //                 .Include(s => s.Conductor)
        //                 .Include(s => s.UsuarioCreador)
        //                 .FirstOrDefaultAsync(s => s.Id == id);

        //             if (servicio == null) return NotFound();
        //             return View(servicio);
        //         }

        //         // ── POST: Cambiar estado del servicio ─────────────────────────────
        //         [HttpPost, ValidateAntiForgeryToken]
        //         //[Authorize(Rols = "Administrador,Coordinador")]
        //         public async Task<IActionResult> CambiarEstado(int id, EstadoServicio nuevoEstado, string? observaciones)
        //         {
        //             var servicio = await _context.Servicios.FindAsync(id);
        //             if (servicio == null) return NotFound();

        //             servicio.Estado = nuevoEstado;
        //             if (!string.IsNullOrWhiteSpace(observaciones))
        //                 servicio.Observaciones = observaciones;

        //             await _context.SaveChangesAsync();

        //             TempData["Success"] = $"Estado del servicio actualizado a: {nuevoEstado}.";
        //             return RedirectToAction(nameof(DetallesServicios), new { id });
        //         }

        //         // ── AJAX: Validar vehículo antes de crear ─────────────────────────
        //         [HttpPost]
        //         public async Task<IActionResult> ValidarVehiculo(int vehiculoId, int conductorId)
        //         {
        //             var resultado = await _validacionService.ValidarParaServicioAsync(vehiculoId, conductorId);
        //             return Json(new
        //             {
        //                 exitoso = resultado.Exitoso,
        //                 errores = resultado.Errores,
        //                 advertencias = resultado.Advertencias,
        //                 vehiculo = resultado.Vehiculo == null ? null : new
        //                 {
        //                     placa = resultado.Vehiculo.Placa,
        //                     marca = resultado.Vehiculo.Marca,
        //                     modelo = resultado.Vehiculo.Modelo
        //                 }
        //             });
        //         }

        //         // ── Helpers ───────────────────────────────────────────────────────
        //         private async Task CargarSelectListsAsync(int? cotizacionIdPreseleccionada = null)
        //         {
        //             // Solo cotizaciones aprobadas sin servicio
        //             var cotizaciones = await _context.Cotizaciones
        //                 .Include(c => c.Cliente)
        //                 .Where(c => c.Estado == EstadoCotizacion.Aprobada && c.Servicio == null)
        //                 .OrderByDescending(c => c.FechaAprobacion)
        //                 .Select(c => new
        //                 {
        //                     c.Id,
        //                     Display = $"#{c.Id:D6} - {c.Cliente!.NombreCompleto} | {c.Origen} → {c.Destino} ({c.FechaServicioRequerido:dd/MM/yy})"
        //                 })
        //                 .ToListAsync();

        //             ViewBag.Cotizaciones = new SelectList(cotizaciones, "Id", "Display", cotizacionIdPreseleccionada);

        //             var vehiculos = await _context.Vehiculos
        //                 .Where(v => v.Estado == EstadoVehiculo.Activo)
        //                 .OrderBy(v => v.Placa)
        //                 .Select(v => new
        //                 {
        //                     v.Id,
        //                     Display = $"{v.Placa} - {v.Marca} {v.Modelo} ({v.Anio})"
        //                 })
        //                 .ToListAsync();

        //             ViewBag.Vehiculos = new SelectList(vehiculos, "Id", "Display");

        //             var conductores = await _context.Conductores
        //                 .Where(c => c.Activo)
        //                 .OrderBy(c => c.NombreCompleto)
        //                 .ToListAsync();

        //             ViewBag.Conductores = new SelectList(conductores, "Id", "NombreCompleto");
        //         }


    }
}