using AppServiceAndTravel.Data;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Services;
using Microsoft.EntityFrameworkCore;
using AppServiceAndTravel.Areas.Comercial.ViewModels;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Areas.Comercial.Models;

namespace AppServiceAndTravel.Areas.Comercial.Services
{
    public interface ICotizacionService
    {
        DashboardCotizacionesVM ObtenerDashboard();
        Task<List<CotizacionComboVM>> GetCotizacionesAprobadas();
        Task<ApiResponse<List<CotizacionVM>>> ObtenerCotizaciones(CotizacionesFilterVM filter);
        Task<(bool success, string message)> CrearCotizacion(CotizacionVM model, int idUsuario);
        Task<(bool success, string message, CotizacionDetalleVM? data)> DetalleCotizacion(int id);
        Task<(bool success, string message)> ObtenerEstadoCotizacion(int id);
        Task<(bool success, string message)> ActualizarCotizacion(int id, CotizacionUpdateVM model);
        Task<(bool success, string message)> AprobarCotizacion(int idUsuario, int id, decimal? valorAprobado, string? observaciones);
        Task<(bool success, string message)> RechazarCotizacion(int idUsuario, int id, string motivo);
    }
    public class CotizacionService : ICotizacionService
    {
        private readonly ApplicationDBContext _context;
        private readonly IConfiguration _configuration;
        private readonly UtilitiesServices _utilities;
        private readonly IEmailService _emailService;
        private readonly IWhatsAppService _whatsappService;
        public CotizacionService(ApplicationDBContext context, IConfiguration configuration, UtilitiesServices utilities, IEmailService emailService, IWhatsAppService whatsappService)
        {
            _context = context;
            _configuration = configuration;
            _utilities = utilities;
            _emailService = emailService;
            _whatsappService = whatsappService;
        }
        // public async Task<(bool success,string message,Cotizaciones data)> Index(EstadoCotizacion? estado, string? busqueda, int pagina = 1)
        // {
        //     const int itemsPorPagina = 10;

        //     var query = _context.Cotizaciones
        //         .Include(c => c.Cliente)
        //         .Include(c => c.UsuarioCreador)
        //         .Include(c => c.UsuarioAprobador)
        //         .AsQueryable();

        //     if (estado.HasValue)
        //         query = query.Where(c => c.Estado == estado.Value);

        //     if (!string.IsNullOrWhiteSpace(busqueda))
        //         query = query.Where(c =>
        //             c.Cliente!.NombreCompleto.Contains(busqueda) ||
        //             c.Origen.Contains(busqueda) ||
        //             c.Destino.Contains(busqueda));

        //     var total = await query.CountAsync();
        //     var cotizaciones = await query
        //         .OrderByDescending(c => c.FechaCreacion)
        //         .Skip((pagina - 1) * itemsPorPagina)
        //         .Take(itemsPorPagina)
        //         .ToListAsync();

        //     ViewBag.EstadoFiltro = estado;
        //     ViewBag.Busqueda = busqueda;
        //     ViewBag.PaginaActual = pagina;
        //     ViewBag.TotalPaginas = (int)Math.Ceiling((double)total / itemsPorPagina);
        //     ViewBag.TotalRegistros = total;

        //     // Contadores por estado para badges
        //     ViewBag.TotalPendientes = await _context.Cotizaciones.CountAsync(c => c.Estado == EstadoCotizacion.Pendiente);
        //     ViewBag.TotalAprobadas = await _context.Cotizaciones.CountAsync(c => c.Estado == EstadoCotizacion.Aprobada);
        //     ViewBag.TotalRechazadas = await _context.Cotizaciones.CountAsync(c => c.Estado == EstadoCotizacion.Rechazada);

        //     return (true,"datos encontrados",cotizaciones);
        // }
        public DashboardCotizacionesVM ObtenerDashboard()
        {
            return new DashboardCotizacionesVM
            {
                TotalPendientes = _context.Cotizaciones.Count(x => x.Estado == EstadoCotizacion.Pendiente),

                TotalAprobadas = _context.Cotizaciones.Count(x => x.Estado == EstadoCotizacion.Aprobada),

                TotalRechazadas = _context.Cotizaciones.Count(x => x.Estado == EstadoCotizacion.Rechazada),

                TotalRegistros = _context.Cotizaciones.Count()
            };
        }
        public async Task<List<CotizacionComboVM>> GetCotizacionesAprobadas()
        {
            return await _context.Cotizaciones
                .Include(x => x.Cliente)
                .Where(x => x.Estado == EstadoCotizacion.Aprobada)
                .OrderByDescending(x => x.FechaCreacion)
                .Select(x => new CotizacionComboVM
                {
                    idCotizacion = x.idCotizacion,
                    cliente = x.Cliente!.RazonSocial,
                    fechaCreacion = x.FechaCreacion,
                    valorCotizado = x.ValorCotizado
                })
                .ToListAsync();
        }
        public async Task<ApiResponse<List<CotizacionVM>>> ObtenerCotizaciones(CotizacionesFilterVM filter)
        {
            try
            {
                var query = _context.Cotizaciones
                    .Include(c => c.Cliente)
                    .Include(c => c.Detalles)
                    .Include(c => c.UsuarioCreador)
                    .Include(c => c.UsuarioAprobador)
                    .AsQueryable();

                if (filter.Estado.HasValue)
                {
                    query = query.Where(c =>
                        c.Estado == filter.Estado.Value);
                }

                if (!string.IsNullOrWhiteSpace(filter.Search))
                {
                    query = query.Where(c =>
                        c.Cliente!.RazonSocial.Contains(filter.Search) ||

                        c.Detalles.Any(d =>
                            d.Origen.Contains(filter.Search) ||
                            d.Destino.Contains(filter.Search)
                        )
                    );
                }

                var total = await query.CountAsync();

                var cotizaciones = await query
                    .OrderByDescending(c => c.FechaCreacion)
                    .Paginate(filter.Page, filter.PageSize)
                    .Select(c => new CotizacionVM
                    {
                        idCotizacion = c.idCotizacion,
                        idCliente = c.idCliente,

                        Cliente = c.Cliente!.RazonSocial,
                        Correo = c.Cliente.Correo,

                        Origen = c.Detalles.Select(x => x.Origen).FirstOrDefault()!,
                        Destino = c.Detalles.Select(x => x.Destino).FirstOrDefault()!,


                        ValorCotizado = c.ValorCotizado,
                        ValorAprobado = c.ValorAprobado,

                        Estado = c.Estado.ToString(),

                        FechaCreacion = c.FechaCreacion,
                        FechaAprobacion = c.FechaAprobacion,

                        ObservacionesAprobacion = c.ObservacionesAprobacion,
                        ObservacionesRechazo = c.ObservacionesRechazo,

                        idUsuarioCreador = c.idUsuarioCreador,
                        idUsuarioAprobador = c.idUsuarioAprobador,

                        TieneServicio = c.Detalles.Any(d => d.Servicios.Any())
                    })
                    .ToListAsync();

                return new ApiResponse<List<CotizacionVM>>
                {
                    Success = true,
                    Message = "Datos encontrados correctamente",
                    Data = cotizaciones,
                    Pagination = new PaginationVM
                    {
                        Page = filter.Page,
                        PageSize = filter.PageSize,
                        Total = total
                    }
                };
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error obteniendo cotizaciones: {ex.Message}", "ObtenerCotizaciones", "ERROR");

                return new ApiResponse<List<CotizacionVM>> { Success = false, Message = ex.Message, Data = [] };
            }
        }
        public async Task<(bool success, string message)> CrearCotizacion(CotizacionVM model, int idUsuario)
        {
            try
            {
                var cliente = await _context.Clientes
                    .FirstOrDefaultAsync(x => x.idCliente == model.idCliente);

                if (cliente == null)
                    return (false, "El cliente seleccionado no existe.");

                var cotizacion = new Cotizaciones
                {
                    idCliente = model.idCliente,
                    Observaciones = model.Observaciones,
                    Estado = EstadoCotizacion.Pendiente,
                    FechaCreacion = DateTime.Now,
                    diasServicio = model.diasServicio,
                    disponibilidad = model.disponibilidad,
                    idUsuarioCreador = idUsuario
                };

                foreach (var item in model.Detalles!)
                {
                    cotizacion.Detalles.Add(new DetalleCotizacion
                    {
                        idTipoServicio = item.idTipoServicio,
                        idTipoVehiculo = item.idTipoVehiculo,
                        Origen = item.Origen,
                        Destino = item.Destino,
                        FechaServicioInicio = item.FechaServicioInicio,
                        FechaServicioFin = item.FechaServicioFin,
                        NumPasajeros = item.NumPasajeros,
                        Cantidad = item.Cantidad,
                        ValorUnitario = item.ValorUnitario,
                        ValorTotal = item.Cantidad * item.ValorUnitario,
                        Observaciones = item.Observaciones
                    });
                }
                cotizacion.ValorCotizado = cotizacion.Detalles.Sum(x => x.ValorTotal);
                _context.Cotizaciones.Add(cotizacion);

                await _context.SaveChangesAsync();

                try
                {
                    //await _emailService.EnviarCotizacionCreadaAsync(cliente.Correo, cliente.RazonSocial, cotizacion);
                }
                catch (Exception ex)
                {
                    return (false, $"La cotización fue creada pero el correo no pudo enviarse: {ex.Message}");
                }

                return (true, $"Cotización #{cotizacion.idCotizacion:D6} creada exitosamente.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public async Task<(bool success, string message, CotizacionDetalleVM? data)> DetalleCotizacion(int id)
        {
            var cotizacion = await _context.Cotizaciones
                .Include(x => x.Cliente)
                .Include(x => x.Detalles)
                    .ThenInclude(x => x.TipoServicio)
                .Include(x => x.Detalles)
                    .ThenInclude(x => x.TipoVehiculo)
                .Include(x => x.Detalles)
                    .ThenInclude(x => x.Servicios)
                .FirstOrDefaultAsync(x => x.idCotizacion == id);

            if (cotizacion == null)
                return (false, "No encontrada", null);

            var vm = new CotizacionDetalleVM
            {
                idCotizacion = cotizacion.idCotizacion,
                idCliente = cotizacion.idCliente,

                Cliente = cotizacion.Cliente?.RazonSocial ?? "",
                Correo = cotizacion.Cliente?.Correo ?? "",

                ValorCotizado = cotizacion.ValorCotizado,
                ValorAprobado = cotizacion.ValorAprobado,

                Estado = cotizacion.Estado.ToString(),
                FechaCreacion = cotizacion.FechaCreacion,

                Observaciones = cotizacion.Observaciones,
                ObservacionesAprobacion = cotizacion.ObservacionesAprobacion,
                ObservacionesRechazo = cotizacion.ObservacionesRechazo,

                TieneServicio = cotizacion.Detalles.Any(d => d.Servicios != null && d.Servicios.Any()),

                Detalles = cotizacion.Detalles
                                .Select(d => new DetalleCotizacionVM
                                {
                                    idDetalleCotizacion = d.idDetalleCotizacion,

                                    idTipoServicio = d.idTipoServicio ?? null,
                                    TipoServicio = d.TipoServicio?.descripcion ?? "",

                                    idTipoVehiculo = d.idTipoVehiculo ?? null,
                                    TipoVehiculo = d.TipoVehiculo?.descripcion ?? "",

                                    Origen = d.Origen,
                                    Destino = d.Destino,

                                    FechaServicioInicio = d.FechaServicioInicio,
                                    FechaServicioFin = d.FechaServicioFin,

                                    NumPasajeros = d.NumPasajeros,

                                    Cantidad = d.Cantidad,
                                    ValorUnitario = d.ValorUnitario,
                                    ValorTotal = d.ValorTotal,

                                    Observaciones = d.Observaciones
                                })
                                .ToList()

            };

            foreach (var d in cotizacion.Detalles)
            {
                _utilities.RegistrarLog($"Detalle:{d.idDetalleCotizacion} TipoServicio:{d.idTipoServicio} TipoVehiculo:{d.idTipoVehiculo}", "DetalleCotizacion", "INFO");
            }

            return (true, "Datos encontrados", vm);
        }
        public async Task<(bool success, string message)> ObtenerEstadoCotizacion(int id)
        {
            if (id <= 0)
                return (false, "no se ha encontrado la cotizacion ingresada");

            var cotizacion = await _context.Cotizaciones.FindAsync(id);
            if (cotizacion == null)
                return (false, "no se ha encontrado la cotizacion ingresada");

            if (cotizacion.Estado != EstadoCotizacion.Pendiente)
            {
                return (false, "Solo se pueden editar cotizaciones en estado Pendiente.");
            }

            return (true, "datos encontrados");
        }
        public async Task<(bool success, string message)> ActualizarCotizacion(int id, CotizacionUpdateVM model)
        {
            if (id != model.idCotizacion)
                return (false, "no se ha encontrado la cotizacion ingresada");

            var cotizacionDb = await _context.Cotizaciones.FindAsync(id);

            if (cotizacionDb == null)
                return (false, "no se ha encontrado la cotizacion ingresada");

            if (cotizacionDb.Estado != EstadoCotizacion.Pendiente)
            {
                return (false, "Solo se pueden editar cotizaciones en estado Pendiente.");
            }

            cotizacionDb.idCliente = model.idCliente;
            cotizacionDb.Observaciones = model.Observaciones;
            cotizacionDb.ValorCotizado = model.ValorCotizado;
            foreach (var item in model.Detalles!)
            {
                cotizacionDb.Detalles.Add(
                    new DetalleCotizacion
                    {
                        idTipoServicio = item.idTipoServicio,
                        idTipoVehiculo = item.idTipoVehiculo,

                        Origen = item.Origen,
                        Destino = item.Destino,

                        FechaServicioInicio = item.FechaServicioInicio,
                        FechaServicioFin = item.FechaServicioFin,

                        NumPasajeros = item.NumPasajeros,

                        Cantidad = item.Cantidad,

                        ValorUnitario = item.ValorUnitario,

                        ValorTotal =
                            item.Cantidad *
                            item.ValorUnitario,

                        Observaciones = item.Observaciones
                    });
            }

            await _context.SaveChangesAsync();

            return (true, "Cotización actualizada.");
        }
        public async Task<(bool success, string message)> AprobarCotizacion(int idUsuario, int id, decimal? valorAprobado, string? observaciones)
        {
            var cotizacion = await _context.Cotizaciones.Include(c => c.Cliente).FirstOrDefaultAsync(c => c.idCotizacion == id);

            if (cotizacion == null)
                return (false, "datos no encontrados");

            if (cotizacion.Estado != EstadoCotizacion.Pendiente)
            {
                return (false, "Solo se pueden aprobar cotizaciones en estado Pendiente.");
            }

            cotizacion.Estado = EstadoCotizacion.Aprobada;
            cotizacion.ValorAprobado = valorAprobado ?? cotizacion.ValorCotizado;
            cotizacion.ObservacionesAprobacion = observaciones;
            cotizacion.FechaAprobacion = DateTime.UtcNow;
            cotizacion.idUsuarioAprobador = idUsuario;

            await _context.SaveChangesAsync();

            // Notificaciones
            if (cotizacion.Cliente != null)
            {
                try
                {
                    await _emailService.EnviarAprobacionCotizacionAsync(cotizacion.Cliente.Correo, cotizacion.Cliente.RazonSocial, cotizacion);
                }
                catch (Exception ex)
                {
                    return (false, $"No se ha podido enviar el correo de aprobación:{ex.Message}");
                }

                try
                {
                    await _whatsappService.EnviarAprobacionCotizacionAsync(cotizacion.Cliente.Telefono, cotizacion.Cliente.RazonSocial, cotizacion);
                }
                catch (Exception ex)
                {
                    return (false, $"No se ha podido enviar la notificacion por whatsApp de la aprobación:{ex.Message}");
                }
            }

            return (true, $"Cotización #{cotizacion.idCotizacion:D6} aprobada exitosamente.");
        }
        public async Task<(bool success, string message)> RechazarCotizacion(int idUsuario, int id, string motivo)
        {
            var cotizacion = await _context.Cotizaciones
                .Include(c => c.Cliente)
                .FirstOrDefaultAsync(c => c.idCotizacion == id);

            if (cotizacion == null)
                return (false, "datos no encontrados");

            cotizacion.Estado = EstadoCotizacion.Rechazada;
            cotizacion.ObservacionesRechazo = motivo;
            cotizacion.FechaAprobacion = DateTime.UtcNow;
            cotizacion.idUsuarioAprobador = idUsuario;

            await _context.SaveChangesAsync();

            if (cotizacion.Cliente != null)
            {
                try
                {
                    await _emailService.EnviarRechazoCotizacionAsync(cotizacion.Cliente.Correo, cotizacion.Cliente.RazonSocial, cotizacion);
                }
                catch (Exception ex)
                {
                    return (false, $"No se ha podido enviar la notificacion el rechazo:{ex.Message}");
                }
            }

            return (true, $"Cotización #{cotizacion.idCotizacion:D6} rechazada.");
        }

    }
}