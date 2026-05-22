using System.Diagnostics;
using AppServiceAndTravel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppServiceAndTravel.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult CreateCliente()
        {
            return View();
        }

        public IActionResult CreateServicio()
        {
            return View();
        }
        public IActionResult CreateUsuarios()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult DetailsCliente()
        {
            return View();
        }
        public IActionResult EditCliente()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }

        public IActionResult Usuarios()
        {
            return View();
        }
        public IActionResult Configuracion()
        {
            return View();
        }
        public IActionResult Setup()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
