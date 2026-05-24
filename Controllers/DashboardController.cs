using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AppServiceAndTravel.Services;

namespace AppServiceAndTravel.Controllers.Api
{
    [Authorize]
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(IDashboardService dashboardService,ILogger<DashboardController> logger)
        {
            _dashboardService = dashboardService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetDashboard()
        {
            try
            {
                var dashboard =
                    await _dashboardService.ObtenerDashboard();

                return Ok(dashboard);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error obteniendo dashboard"
                );

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        success = false,
                        message =
                            "Error obteniendo información del dashboard"
                    }
                );
            }
        }
    }
}