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
        Task<ConductoresResponseVM> ObtenerConductoresAsync(string? busqueda,TipoProveedor? tipo,int pagina);

        Task<object> ObtenerEstadisticasAsync();

        Task<Conductores?> ObtenerPorIdAsync(int id);

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
        public async Task<Conductores?> ObtenerPorIdAsync(int id)
        {
            return await _context.Conductores
                .FirstOrDefaultAsync(x => x.idConductor == id);
        }
        public async Task<ConductoresResponseVM> ObtenerConductoresAsync(
    string? busqueda,
    TipoProveedor? tipo,
    int pagina)
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