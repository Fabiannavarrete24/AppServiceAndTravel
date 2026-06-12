using AppServiceAndTravel.Areas.Comercial.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppServiceAndTravel.Areas.Comercial.Controllers
{
    [Area("Comercial")]
    public class DasboardController : Controller
    {
        private readonly IDashboardCotizacionService _dashboardService;

        public DasboardController(IDashboardCotizacionService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet]
        public IActionResult ObtenerDashboard()
        {
            var result = _dashboardService.ObtenerDashboard();

            return Json(new { success = true, data = result });
        }
        
    }
}