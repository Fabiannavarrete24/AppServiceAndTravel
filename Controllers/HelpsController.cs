using AppServiceAndTravel.Areas.Operaciones.Services;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AppServiceAndTravel.Controllers
{
    //[Authorize]
    public class HelpsController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IVehiculoService _vehiculoService;
        private readonly UtilitiesServices _utilitiesService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HelpsController(IAuthService authService, IVehiculoService vehiculoService, UtilitiesServices utilitiesService, IWebHostEnvironment hostEnvironment)
        {
            _authService = authService;
            _vehiculoService = vehiculoService;
            _utilitiesService = utilitiesService;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult MenuNavegacion()
        {
            try
            {
                var idUsuario = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                var result = _authService.NavProcess(idUsuario);

                return Ok(new{success = true,data = result});
            }
            catch (Exception ex)
            {
                return BadRequest(new{success = false,message = ex.Message});
            }
        }
        [HttpGet]
        public IActionResult ObtenerListadoSelect()
        {
            var result = _utilitiesService.ObtenerSelect();

            return Json(result);
        }
        [HttpGet]
        public IActionResult ObtenerTiposVehiculo(int idCategoria)
        {
            var result = _utilitiesService.ObtenerTiposVehiculos(idCategoria);

            return Json(result);
        }
    }
}