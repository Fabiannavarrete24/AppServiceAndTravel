using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Helpers.Filters;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.Services
{
    public interface IConductorService
    {
        Task<object> ObtenerEstadisticasAsync();
        Task<ConductorVM?> ObtenerConductor(int idConductor);
        Task<ConductoresResponseVM> ObtenerConductoresAsync(string? busqueda, TipoProveedor? tipo, int pagina);
        Task<(bool success, string message, ConductorVM? data)> GuardarConductor(ConductorVM model);
        Task<(bool success, string message)> DeshabilitarConductor(int idConductor);
        Task<(bool success, string message)> EliminarAsync(int id);
    }

    public class ConductorService : IConductorService
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<VehiculoService> _logger;

        // Días de alerta anticipada para vencimientos
        private const int DiasAlertaAnticipada = 30;

        public ConductorService(ApplicationDBContext context, ILogger<VehiculoService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<object> ObtenerEstadisticasAsync()
        {
            var hoy = DateTime.Today;

            return new
            {
                Total = await _context.Conductores.CountAsync(),

                Internos = await _context.Conductores
                    .CountAsync(x => x.TipoProveedor == TipoProveedor.Interno),

                Externos = await _context.Conductores
                    .CountAsync(x => x.TipoProveedor == TipoProveedor.Externo),

                LicenciasVencidas = await _context.Conductores
                    .CountAsync(x => x.FechaVencimientoLicencia < hoy)
            };
        }
        public async Task<ConductorVM?> ObtenerConductor(int idConductor)
        {
            return await _context.Conductores
                .Where(x => x.idConductor == idConductor)
                .Select(x => new ConductorVM
                {
                    idConductor = x.idConductor,
                    NombreCompleto = x.NombreCompleto,
                    Cedula = x.Cedula,
                    Telefono = x.Telefono,
                    Correo = x.correo,

                    NumeroLicencia = x.NumeroLicencia,
                    CategoriaLicencia = x.CategoriaLicencia,
                    CategoriaLicenciaAnterior = x.CategoriaLicenciaAnterior,

                    FechaExpedicionLicencia = x.FechaExpedicionLicencia,
                    FechaVencimientoLicencia = x.FechaVencimientoLicencia,

                    OrganismoTransitoExpideLicencia =
                        x.OrganismoTransitoExpideLicencia,

                    RestriccionesLicencia =
                        x.RestriccionesLicencia,

                    TieneRetencionLicencia =
                        x.TieneRetencionLicencia,

                    RetencionLicencia =
                        x.RetencionLicencia,

                    OrganismoTransitoCancelaLicencia =
                        x.OrganismoTransitoCancelaLicencia,

                    EstadoLicencia =
                        x.EstadoLicencia,

                    TipoProveedor =
                        x.TipoProveedor,

                    EstadoPersona =
                        x.EstadoPersona,

                    EstadoConductor =
                        x.EstadoConductor,

                    Activo =
                        x.Activo
                })
                .FirstOrDefaultAsync();
        }
        public async Task<ConductoresResponseVM> ObtenerConductoresAsync(string? busqueda, TipoProveedor? tipo, int pagina)
        {
            const int pageSize = 10;

            var query = _context.Conductores.AsQueryable();

            if (tipo.HasValue)
                query = query.Where(x => x.TipoProveedor == tipo);

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                query = query.Where(x =>
                    x.NombreCompleto.Contains(busqueda) ||
                    x.Cedula.Contains(busqueda) ||
                    x.Telefono.Contains(busqueda) ||
                    x.NumeroLicencia.Contains(busqueda));
            }

            var totalRegistros = await query.CountAsync();

            var conductores = await query
                .OrderBy(x => x.NombreCompleto)
                .Skip((pagina - 1) * pageSize)
                .Take(pageSize)
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

            return new ConductoresResponseVM
            {
                Conductores = conductores,

                TotalRegistros = totalRegistros,
                PaginaActual = pagina,
                TotalPaginas = (int)Math.Ceiling(totalRegistros / (double)pageSize),

                Total = await _context.Conductores.CountAsync(),

                Internos = await _context.Conductores
                    .CountAsync(x => x.TipoProveedor == TipoProveedor.Interno),

                Externos = await _context.Conductores
                    .CountAsync(x => x.TipoProveedor == TipoProveedor.Externo),

                LicenciasVencidas = await _context.Conductores
                    .CountAsync(x => x.FechaVencimientoLicencia < DateTime.Today)
            };
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

                conductor.NombreCompleto = model.NombreCompleto;
                conductor.Cedula = model.Cedula;
                conductor.Telefono = model.Telefono;
                conductor.correo = model.Correo;

                conductor.NumeroLicencia = model.NumeroLicencia;
                conductor.CategoriaLicencia = model.CategoriaLicencia;
                conductor.CategoriaLicenciaAnterior = model.CategoriaLicenciaAnterior;

                conductor.FechaExpedicionLicencia =
                    model.FechaExpedicionLicencia ?? DateTime.Now;

                conductor.FechaVencimientoLicencia =
                    model.FechaVencimientoLicencia ?? DateTime.Now;

                conductor.OrganismoTransitoExpideLicencia =
                    model.OrganismoTransitoExpideLicencia;

                conductor.RestriccionesLicencia =
                    model.RestriccionesLicencia;

                conductor.TieneRetencionLicencia =
                    model.TieneRetencionLicencia;

                conductor.RetencionLicencia =
                    model.RetencionLicencia;

                conductor.OrganismoTransitoCancelaLicencia =
                    model.OrganismoTransitoCancelaLicencia;

                conductor.EstadoLicencia =
                    model.EstadoLicencia;

                conductor.TipoProveedor =
                    model.TipoProveedor;

                conductor.RazonSocialExterna =
                    model.RazonSocialExterna;

                conductor.NitExterno =
                    model.NitExterno;

                conductor.TarifaExterna =
                    model.TarifaExterna;

                conductor.ObservacionesExterno =
                    model.ObservacionesExterno;

                conductor.EstadoPersona =
                    model.EstadoPersona;

                conductor.EstadoConductor =
                    model.EstadoConductor;

                conductor.Activo =
                    model.Activo;

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