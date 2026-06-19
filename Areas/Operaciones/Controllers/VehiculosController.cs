using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.Services;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Helpers.Filters;

namespace AppServiceAndTravel.Controllers
{
    [Area("Operaciones")]
    public class VehiculosController : Controller
    {
        private readonly IVehiculoService _vehiculoService;
        private readonly ILogger<VehiculosController> _logger;

        public VehiculosController(IVehiculoService vehiculoService, ILogger<VehiculosController> logger)
        {
            _vehiculoService = vehiculoService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetVehiculo(int id)
        {
            var vehiculo = await _vehiculoService.ObtenerVehiculo(id);

            if (vehiculo == null)
                return NotFound();

            return Json(vehiculo);
        }
        [HttpGet]
        public async Task<IActionResult> ListarVehiculos([FromQuery] VehiculosFilterVM filter)
        {
            var result = await _vehiculoService.ListarVehiculos(filter);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerVehiculo(int id)
        {
            var vehiculo = await _vehiculoService.ObtenerVehiculo(id);

            return Json(vehiculo);
        }

        [HttpPost]
        public async Task<IActionResult> GuardarVehiculo(VehiculoDetalleVM model)
        {
            try
            {

                var resultado = await _vehiculoService.GuardarVehiculo(model);

                return Ok(new { success = resultado.success, data = resultado.message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"se ha presentado un problema {ex.Message}" });
            }
        }
       
        [HttpPost]
        public async Task<IActionResult> Deshabilitar(int id)
        {
            var resultado = await _vehiculoService.DeshabilitarVehiculo(id);

            return Json(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarVehiculo(string term)
        {
            var lista = await _vehiculoService.BuscarVehiculos(term);

            return Json(lista);
        }

        [HttpPost]
        public async Task<IActionResult> EliminarVehiculo(int id)
        {
            var result = await _vehiculoService.EliminarVehiculo(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerKPIs()
        {
            var result = await _vehiculoService.ObtenerKpis();

            if(result == null)
            return NotFound();

            return Ok(new{success = true,data = result});
        }
    }
}