using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Comercial.Services;
using System.Security.Claims;
using AppServiceAndTravel.Areas.Comercial.ViewModels;

namespace AppServiceAndTravel.Areas.Comercial.Controllers
{
    [Area("Comercial")]
    public class CotizacionController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IEmailService _EmailService;
        private readonly ICotizacionService _cotizacionService;
        private readonly IWhatsAppService _whatsAppService;
        private int UserId { get { return Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value); } }
        private readonly IDashboardCotizacionService _dashboardService;

        public CotizacionController(ApplicationDBContext context, IEmailService EmailService, ICotizacionService cotizacionService, IWhatsAppService whatsAppService, IDashboardCotizacionService dashboardService)
        {
            _context = context;
            _EmailService = EmailService;
            _cotizacionService = cotizacionService;
            _whatsAppService = whatsAppService;
            _dashboardService = dashboardService;
        }
        [HttpGet]
        public IActionResult ObtenerDashboard()
        {
            var result = _dashboardService.ObtenerDashboard();

            return Json(new { success = true, data = result });
        }
        [HttpGet]
        public async Task<IActionResult> GetCotizacionesAprobadas()
        {
            var cotizaciones = await _cotizacionService.GetCotizacionesAprobadas();

            return Ok(new
            {
                success = true,
                data = cotizaciones
            });
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerCotizaciones(CotizacionesFilterVM filter)
        {
            var result = await _cotizacionService.ObtenerCotizaciones(filter);

            return Json(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetCotizacion(int id)
        {
            try
            {
                var result = await _cotizacionService.DetalleCotizacion(id);

                if (!result.success)
                {
                    return BadRequest(new { success = false, message = result.message });
                }
                return Ok(new { success = true, message = result.message, data = result.data });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"se ha presentado un error: {ex.Message}" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetEstadoCotizacion(int id)
        {
            if (id is <= 0)
                return BadRequest(new { success = false, message = $"debe ingresar un numero de cotizacion" });
            try
            {

                var result = await _cotizacionService.ObtenerEstadoCotizacion(id);
                if (!result.success)
                {
                    return BadRequest(new { success = false, message = $"no fue posible Actualizar la cotización" });
                }
                return Ok(new { success = result.success, message = result.message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"se ha presentado un error {ex.Message}" });
            }
        }
        [HttpPost]
        public async Task<IActionResult> SetCotizacion([FromBody] CotizacionVM model)
        {
            if (model == null)
            {
                return BadRequest(new { success = false, message = "No se recibieron datos." });
            }

            try
            {
                var result = await _cotizacionService.CrearCotizacion(model, UserId);

                if (!result.success)
                {
                    return BadRequest(new { success = false, message = result.message });
                }

                return Ok(new { success = true, message = result.message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCotizacion([FromBody] CotizacionUpdateVM model)
        {
            var result = await _cotizacionService.ActualizarCotizacion(model.idCotizacion, model);

            if (!result.success)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AprobarCotizacion(int idCotizacion, decimal? valorAprobado, string? observaciones)
        {            

            if (idCotizacion <= 0)
                return NotFound(new { success = false, message = $"Cotización no encontrada {idCotizacion}" });

                var cotizacion = await _cotizacionService.AprobarCotizacion(UserId, idCotizacion, valorAprobado, observaciones);

            if (!cotizacion.success)
            {
                return BadRequest(new { success = cotizacion.success, message = cotizacion.message });
            }

            return Ok(new { success = cotizacion.success, message = cotizacion.message });
        }
        [HttpPost]
        public async Task<IActionResult> RechazarCotizacion(int idCotizacion, string Motivo)
        {
            var result = await _cotizacionService.RechazarCotizacion(UserId, idCotizacion, Motivo);

            if (!result.success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}