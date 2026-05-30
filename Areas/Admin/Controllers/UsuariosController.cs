using AppServiceAndTravel.Areas.Admin.Services;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Helpers.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AppServiceAndTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IUsersService _usersService;

        public UsuariosController(IUsersService usersService) {
            _usersService = usersService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerUsuarios([FromQuery] UsuariosFilterVM filter)
        {
            var result = await _usersService.ObtenerUsuarios(filter);

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetUsuario(int idUsuario)
        {

            try
            {
                var result = _usersService.ObtenerUsuario(idUsuario);

                if (result.success!)
                {
                    return BadRequest(new { success = false, message = "no se encontraron registros" });
                }

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(404, new { success = false, message = $"se ha presentado un error: {ex.Message}" });
            }
        }
        [HttpPost]
        public IActionResult UpdateUsuario([FromBody] UserVM model)
        {

            try
            {
                var result = _usersService.ActualizarUsuario(model);

                if (result.success!)
                {
                    return BadRequest(new { success = false, message = "no se encontraron registros" });
                }

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(404, new { success = false, message = $"se ha presentado un error: {ex.Message}" });
            }
        }
        [HttpPost]
        public IActionResult SetUsuario([FromBody] UserVM model)
        {

            try
            {
                var result = _usersService.GuardarUsuario(model);

                if (result.success!)
                {
                    return BadRequest(new { success = false, message = "no se encontraron registros" });
                }

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(404, new { success = false, message = $"se ha presentado un error: {ex.Message}" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerDashboardUsuarios()
        {
            var result = await _usersService.ObtenerDashboardUsuarios();

            if (!result.Success)
            {
                return BadRequest(new
                {
                    success = false,
                    message = result.Message
                });
            }

            return Ok(new
            {
                success = true,
                data = result.Data
            });
        }
    }
}
