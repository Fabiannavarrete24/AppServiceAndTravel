using Microsoft.AspNetCore.Mvc;

namespace AppServiceAndTravel.Areas.Configuracion.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUsuario()
        {
            return View();
        }
        public IActionResult EditUsuario()
        {
            return View();
        }
        public IActionResult Usuarios()
        {
            return View();
        }
    }
}
