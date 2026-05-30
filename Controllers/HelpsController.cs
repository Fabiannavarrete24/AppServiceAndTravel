using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AppServiceAndTravel.Controllers
{
    [Authorize]
    public class HelpsController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HelpsController(
            IAuthService authService,
            IWebHostEnvironment hostEnvironment)
        {
            _authService = authService;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult MenuNavegacion()
        {
            try
            {
                var idUsuario = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                var result = _authService.NavProcess(idUsuario);

                return Ok(new
                {
                    success = true,
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }

    }
}