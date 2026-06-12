using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Areas.Comercial.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
namespace AppServiceAndTravel.Areas.Comercial.Services
{
    public interface IDashboardCotizacionService
    {
        DashboardCotizacionesVM ObtenerDashboard();
    }
    public class DashboardCotizacionService : IDashboardCotizacionService
    {
        private readonly ApplicationDBContext _context;
        private readonly IConfiguration _configuration;
        private readonly UtilitiesServices _utilities;
        private readonly IEmailService _emailService;
        public DashboardCotizacionService(ApplicationDBContext context, IConfiguration configuration, UtilitiesServices utilities, IEmailService emailService)
        {
            _context = context;
            _configuration = configuration;
            _utilities = utilities;
            _emailService = emailService;
        }

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
    }
}