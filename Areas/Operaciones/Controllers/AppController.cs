using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AppServiceAndTravel.Areas.Operaciones.Controllers
{
    [Area("Operaciones")]
    public class AppController : Controller
    {

        #region Conductores
        public IActionResult Conductores()
        {
            return View();
        }
        public IActionResult CrearConductor() { 
            return View();
        }
        #endregion
        #region Servicios
        public IActionResult CrearServicio()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
        public IActionResult DetallesServicios()
        {
            return View();
        }
        #endregion
        #region vehiculos
        public IActionResult Vehiculos()
        {
            return View();
        }
        public IActionResult CrearVehiculo()
        {
            return View();
        }
        public IActionResult DetallesVehiculos()
        {
            return View();
        }

        #endregion
        #region proveedores
        public IActionResult CrearProveedor()
        {
            return View();
        }
        public IActionResult Proveedores()
        {
            return View();
        }        
        #endregion
    }
}
