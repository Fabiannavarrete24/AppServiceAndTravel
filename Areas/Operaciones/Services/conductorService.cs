using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Helpers.Filters;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Areas.Admin.Services;
using AppServiceAndTravel.Services;

namespace AppServiceAndTravel.Areas.Operaciones.Services
{
    public interface IConductorService
    {
        Task<ApiResponse<object>> ObtenerEstadisticas();
        Task<ApiResponse<List<ConductorVM>>> BuscarConductores(string filtro);
        Task<ConductorVM?> ObtenerConductor(int idConductor);
        Task<ApiResponse<List<ConductorListadoVM>>> ObtenerConductores(ConductoresFilterVM filter);
        Task<(bool success, string message, ConductorVM? data)> GuardarConductor(ConductorVM model);
        Task<(bool success, string message)> DeshabilitarConductor(int idConductor);
        Task<(bool success, string message)> EliminarAsync(int id);
    }

    public class ConductorService : IConductorService
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<VehiculoService> _logger;
        private readonly UtilitiesServices _utilities;
        private readonly IAuditoriaService _auditoriaService;
        // Días de alerta anticipada para vencimientos
        private const int DiasAlertaAnticipada = 30;

        public ConductorService(ApplicationDBContext context, ILogger<VehiculoService> logger,UtilitiesServices utilities, IAuditoriaService auditoriaService)
        {
            _context = context;
            _logger = logger;
            _utilities = utilities;
            _auditoriaService = auditoriaService;
        }
        public async Task<ApiResponse<object>> ObtenerEstadisticas()
        {
            var hoy = DateTime.Today;
            try
            {
                    var Total = await _context.Conductores.CountAsync();
                    var Internos = await _context.Conductores.CountAsync(x => x.TipoProveedor == TipoProveedor.Interno);
                    var Externos = await _context.Conductores.CountAsync(x => x.TipoProveedor == TipoProveedor.Externo);
                    var LicenciasVencidas = await _context.Conductores.CountAsync(x => x.FechaVencimientoLicencia < hoy);

                var result = new
                {
                    Total = Total,
                    Internos = Internos,
                    Externos = Externos,
                    LicenciasVencidas = LicenciasVencidas
                };

                return new ApiResponse<object>
                {
                    Success = true,
                    Message = "Dashboard cargado correctamente",
                    Data = result
                };
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog(ex.Message,"ObtenerDashboardUsuarios","ERROR");

                return new ApiResponse<object>
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }        
        public async Task<ApiResponse<List<ConductorVM>>> BuscarConductores(string filtro)
        {
            try
            {
                var lista = await _context.Conductores
                    .Where(x =>
                        x.NombreCompleto.Contains(filtro)
                        || x.Cedula.Contains(filtro)
                        || x.Telefono.Contains(filtro))
                    .Select(x => new ConductorVM
                    {
                        idConductor = x.idConductor,
                        NombreCompleto = x.NombreCompleto,
                        Cedula = x.Cedula,
                        Telefono = x.Telefono
                    })
                    .ToListAsync();

                return new ApiResponse<List<ConductorVM>>
                {
                    Success = true,
                    Message = "Consulta realizada",
                    Data = lista
                };
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<ConductorVM>>
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
        public async Task<ConductorVM?> ObtenerConductor(int idConductor)
        {
            return await _context.Conductores
                .Where(x => x.idConductor == idConductor)
                .Select(x => new ConductorVM
                {
                    //datos generales
                    idConductor = x.idConductor,
                    NombreCompleto = x.NombreCompleto,
                    Cedula = x.Cedula,
                    Telefono = x.Telefono,
                    TipoDocumento = x.TipoDocumento,
                    Correo = x.correo,
                    //licencia
                    NumeroLicencia = x.NumeroLicencia,
                    CategoriaLicencia = x.CategoriaLicencia,
                    FechaExpedicionLicencia = x.FechaExpedicionLicencia,
                    FechaVencimientoLicencia = x.FechaVencimientoLicencia,
                    OrganismoExpide = x.OrganismoExpide,
                    RestriccionesLicencia = x.RestriccionesLicencia,
                    EstadoLicencia = x.EstadoLicencia,
                    TipoConductor = x.TipoProveedor,
                    Activo = x.Activo
                })
                .FirstOrDefaultAsync();
        }
        public async Task<ApiResponse<List<ConductorListadoVM>>> ObtenerConductores(ConductoresFilterVM filter)
        {
            try
            {
                var query = _context.Conductores.AsQueryable();

                if (!string.IsNullOrWhiteSpace(filter.Busqueda))
                {
                    query = query.Where(x =>
                        x.NombreCompleto!.Contains(filter.Busqueda) ||
                        x.Cedula!.Contains(filter.Busqueda) ||
                        x.Telefono!.Contains(filter.Busqueda) ||
                        x.NumeroLicencia!.Contains(filter.Busqueda));
                }

                if (filter.Tipo.HasValue)
                {
                    query = query.Where(x =>
                        x.TipoProveedor == filter.Tipo);
                }

                var total = await query.CountAsync();

                var conductores = await query
                    .OrderBy(x => x.NombreCompleto)
                    .Skip((filter.Page - 1) * filter.PageSize)
                    .Take(filter.PageSize)
                    .Select(x => new ConductorListadoVM
                    {
                        Id = x.idConductor,
                        NombreCompleto = x.NombreCompleto,
                        Cedula = x.Cedula,
                        Telefono = x.Telefono,
                        Correo = x.correo!,
                        NumeroLicencia = x.NumeroLicencia,
                        FechaVencimientoLicencia = x.FechaVencimientoLicencia,
                        Activo = x.Activo,
                        TipoProveedor = x.TipoProveedor
                    })
                    .ToListAsync();

                return new ApiResponse<List<ConductorListadoVM>>
                {
                    Success = true,
                    Message = "Datos encontrados con éxito",
                    Data = conductores,

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
                _utilities.RegistrarLog(ex.Message,nameof(ObtenerConductores),"ERROR");

                return new ApiResponse<List<ConductorListadoVM>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = []
                };
            }
        }        
        public async Task<(bool success, string message, ConductorVM? data)> GuardarConductor(ConductorVM model)
        {
            try
            {
                Conductores? conductor;

                if (model.idConductor > 0)
                {
                    conductor = await _context.Conductores.FirstOrDefaultAsync(x => x.idConductor == model.idConductor);

                    if (conductor == null)
                        return (false, "Conductor no encontrado", null);
                }
                else
                {
                    conductor = new Conductores();

                    _context.Conductores.Add(conductor);

                    conductor.FechaCreacion = DateTime.Now;
                }
                //generales
                conductor.NombreCompleto = model.NombreCompleto;
                conductor.TipoDocumento = model.TipoDocumento;
                conductor.Cedula = model.Cedula;
                conductor.Telefono = model.Telefono;
                conductor.correo = model.Correo;
                conductor.Activo = model.EstadoConductor;
                conductor.TipoProveedor = model.TipoConductor;
                conductor.EstadoConductor = model.EstadoConductor ? EstadoConductor.Activo : EstadoConductor.Suspendido;
                //licencia
                conductor.NumeroLicencia = model.NumeroLicencia;
                conductor.CategoriaLicencia = model.CategoriaLicencia;
                conductor.EstadoLicencia = model.EstadoLicencia;
                conductor.OrganismoExpide = model.OrganismoExpide;
                conductor.FechaExpedicionLicencia = model.FechaExpedicionLicencia ?? DateTime.Now;
                conductor.FechaVencimientoLicencia = model.FechaVencimientoLicencia ?? DateTime.Now;
                conductor.Vigencia = model.Vigencia;
                conductor.RestriccionesLicencia = model.RestriccionesLicencia;

                await _context.SaveChangesAsync();

                return (
                    true,
                    model.idConductor > 0
                        ? "Conductor actualizado correctamente"
                        : "Conductor creado correctamente",
                    model
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando conductor");

                return (false, ex.Message, null);
            }
        }
        public async Task<(bool success, string message)> DeshabilitarConductor(int idConductor)
        {
            try
            {
                var conductor = await _context.Conductores
                    .FirstOrDefaultAsync(x => x.idConductor == idConductor);

                if (conductor == null)
                    return (false, "Conductor no encontrado");

                conductor.Activo = false;
                conductor.EstadoConductor = EstadoConductor.Suspendido;
                await _context.SaveChangesAsync();

                return (true, "Conductor deshabilitado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deshabilitando conductor");

                return (false, ex.Message);
            }
        }
        public async Task<(bool success, string message)> EliminarAsync(int id)
        {
            var conductor = await _context.Conductores
                .FirstOrDefaultAsync(x => x.idConductor == id);

            if (conductor == null)
                return (false, "Conductor no encontrado");

            _context.Conductores.Remove(conductor);

            await _context.SaveChangesAsync();

            return (true, "Conductor eliminado correctamente");
        }

    }

}