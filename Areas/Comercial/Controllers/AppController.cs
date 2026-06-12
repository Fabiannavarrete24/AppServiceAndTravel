using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Comercial.Services;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Security.Claims;

namespace AppServiceAndTravel.Areas.Comercial.Controllers
{
    [Area("Comercial")]
    public class AppController : Controller
    {

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Clientes()
        {
            return View();
        }
        public IActionResult CrearCliente()
        {
            return View();
        }
        public IActionResult Cotizaciones()
        {
            return View();
        }        
        public IActionResult CrearCotizacion()
        {
            return View();
        }
        private readonly ILogger<AppController> _logger =
            LoggerFactory.Create(b => b.AddConsole()).CreateLogger<AppController>();
    }
}
