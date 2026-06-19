using AppServiceAndTravel.Areas.Operaciones.Services;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Helpers;
using Microsoft.AspNetCore.Mvc;
using AppServiceAndTravel.ViewModels;

namespace AppServiceAndTravel.Controllers
{
    [Area("Empleados")]
    public class EmpleadosController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<EmpleadosController> _logger;

        public EmpleadosController(ApplicationDBContext context, ILogger<EmpleadosController> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        public async Task<ApiResponse<EmpleadoVM>> EmpleadoPorDocumento(string documento)
        {
            try
            {
                // var empleado = await _context.Empleados
                //     .Where(x => x.Documento == documento)
                //     .Select(x => new EmpleadoVM
                //     {
                //         idEmpleado = x.idEmpleado,
                //         Documento = x.Documento,
                //         NombreCompleto = x.NombreCompleto,
                //         Telefono = x.Telefono,
                //         Correo = x.Correo,
                //         TipoDocumento = x.TipoDocumento
                //     })
                //     .FirstOrDefaultAsync();

                // if (empleado == null)
                // {
                //     return new ApiResponse<EmpleadoVM>
                //     {
                //         Success = false,
                //         Message = "Empleado no encontrado"
                //     };
                // }
                // if(documento != null)
                // return new ApiResponse<EmpleadoVM> { Success = true, Message = "Empleado encontrado", Data = null! };

                return new ApiResponse<EmpleadoVM> { Success = false, Message = $"datos no encontrados {documento}", Data = null! };                
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmpleadoVM> { Success = false, Message = ex.Message };
            }
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerEmpleadoPorDocumento(string documento)
        {
            var response = await ObtenerEmpleadoPorDocumento(documento);
            return Json(response);
        }
    }
}