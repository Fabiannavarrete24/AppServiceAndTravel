using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using AppServiceAndTravel.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AppServiceAndTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppController : Controller
    {

        public AppController()
        {
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult ConfiguracionGeneral()
        {
            return View();
        }
        public IActionResult RolesPermisos()
        {
            return View();
        }

        public IActionResult Usuarios()
        {
            return View();
        }
        public IActionResult CrearUsuarios()
        {
            return View();
        }

        private readonly ILogger<AppController> _logger = LoggerFactory.Create(b => b.AddConsole()).CreateLogger<AppController>();
    }
}
