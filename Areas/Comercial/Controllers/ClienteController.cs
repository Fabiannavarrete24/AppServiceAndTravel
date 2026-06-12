using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Comercial.Services;
using System.Security.Claims;
using AppServiceAndTravel.Areas.Comercial.ViewModels;

namespace AppServiceAndTravel.Areas.Comercial.Controllers
{
    [Area("Comercial")]
    public class ClienteController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IClienteService _clienteService;
        private int UserId { get { return Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value); } }

        public ClienteController(ApplicationDBContext context, IClienteService clienteService)
        {
            _context = context;
            _clienteService = clienteService;
        }
        [HttpPost]
        public async Task<IActionResult> SetCliente([FromBody] ClienteVM model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { success = false, message = "Datos inválidos" });

            var result = await _clienteService.CrearCliente(model);

            if (!result.success)
                return BadRequest(new { success = false, message = result.message });

            return Ok(new { success = true, message = result.message });
        }
        [HttpGet]
        public async Task<IActionResult> GetCliente(int id)
        {
            var result = await _clienteService.ObtenerCliente(id);

            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCliente([FromBody] ClienteVM model)
        {
            var result = await _clienteService.ActualizarCliente(model);

            if (!result.success)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> ToggleActivo(int id)
        {
            var result = await _clienteService.CambiarEstado(id);

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerDashboard()
        {
            var result = await _clienteService.ObtenerDashboard();

            return Ok(new { success = result.success, data = result.data });
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerClientes(string? search, bool soloActivos = true, int page = 1, int pageSize = 10)
        {
            var result = await _clienteService.ObtenerClientes(search, soloActivos, page, pageSize);

            return Ok(new { success = result.success, data = result.data, totalRecords = result.totalRegistros });
        }
        [HttpGet]
        public async Task<IActionResult> BuscarClientes(string term)
        {
            
            var clientes = await _clienteService.BuscarClientes(term);
            return Ok(clientes);
        }
    }
}