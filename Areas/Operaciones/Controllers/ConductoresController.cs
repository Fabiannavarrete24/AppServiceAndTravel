using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.Services;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
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
    public class ConductoresController : Controller
    {
        private readonly IConductorService _conductorService;
        private readonly ILogger<ConductoresController> _logger;

        public ConductoresController(IConductorService conductorService, ILogger<ConductoresController> logger)
        {
            _conductorService = conductorService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerConductores(string? busqueda, TipoProveedor? tipo, int pagina = 1)
        {
            var resultado = await _conductorService.ObtenerConductoresAsync(
                busqueda,
                tipo,
                pagina);

            return Ok(resultado);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerConductor(int id)
        {
            var conductor = await _conductorService.ObtenerConductor(id);

            if (conductor == null)
                return NotFound();

            return Ok(conductor);
        }
        [HttpPost]
        public async Task<IActionResult> EliminarConductor(int id)
        {
            var result = await _conductorService.EliminarAsync(id);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> DeshabilitarConductor(int idConductor)
        {
            var resultado =
                await _conductorService.DeshabilitarConductor(idConductor);

            return Json(new
            {
                success = resultado.success,
                message = resultado.message
            });
        }
        [HttpPost]
        public async Task<IActionResult> GuardarConductor(ConductorVM model)
        {
            var resultado =
                await _conductorService.GuardarConductor(model);

            return Json(new
            {
                success = resultado.success,
                message = resultado.message,
                data = resultado.data
            });
        }
    }
}
