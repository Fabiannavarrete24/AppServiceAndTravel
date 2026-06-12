using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppServiceAndTravel.Areas.Operaciones.Services;
using System.Security.Claims;

namespace AppServiceAndTravel.Areas.Operaciones.Controllers
{
    [Area("Operaciones")]
    public class ServiciosController : Controller
    {
        private readonly IServiciosService _servicioService;
        private readonly IVehiculoService _vehiculoService;
        private int UserId { get { return Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value); } }

        public ServiciosController(IServiciosService servicioService, IVehiculoService vehiculoService)
        {
            _servicioService = servicioService;
            _vehiculoService = vehiculoService;
        }
        [HttpGet]
        public async Task<IActionResult> GetDetallesCotizacion(int idCotizacion)
        {
            var result =
                await _servicioService.DetallesCotizacion(idCotizacion);

            return Ok(new
            {
                success = true,
                data = result
            });
        }
        [HttpGet]
        public async Task<IActionResult> GetDetalleServicio(int idDetalleCotizacion)
        {
            var result =
                await _servicioService.DetalleServicio(idDetalleCotizacion);

            return Ok(new
            {
                success = true,
                data = result
            });
        }
        [HttpGet]
        public IActionResult GetTiposServicios()
        {
            var result = _servicioService.ObtenerTiposServicios();

            return Ok(new { success = true, data = result });
        }
        [HttpGet]
        public IActionResult GetTiposVehiculos()
        {
            var result = _vehiculoService.ObtenerTiposVehiculos();

            return Ok(new { success = true, data = result });
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerDetallesDisponibles()
        {
            var result = await _servicioService.ObtenerDetallesDisponibles();

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerDetalleCotizacion(int idDetalle)
        {
            var result = await _servicioService.ObtenerDetalleCotizacion(idDetalle);

            if (!result.success)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult>
        CrearServicio([FromBody] AddServicioVM model)
        {
            var result =
                await _servicioService.CrearServicio(model, UserId);

            if (!result.success)
                return BadRequest(result);

            return Ok(result);
        }

    }
}