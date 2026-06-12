using System.Security.Claims;
using System.Threading.Tasks;
using AppServiceAndTravel.Areas.Admin.Services;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Area("Admin")]
//[Authorize(Roles = "Administrador")]
public class ConfiguracionController : Controller
{
    private readonly IConfiguracionService _configService;
    private readonly ApplicationDBContext _context;
    private int UserId { get { return Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value); } }

    public ConfiguracionController(IConfiguracionService configService, ApplicationDBContext context)
    {
        _configService = configService;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetConfiguracion()
    {
        var configuracion = await _configService.ObtenerConfiguracion();
        var notificacion = await _configService.ObtenerNotificacion();


        return Ok(new { success = true, dataConfig = configuracion, datanotif = notificacion });
    }
    [HttpPost]
    public async Task<IActionResult> SetEmpresa([FromBody] EmpresaVM model)
    {
        try
        {
            await _configService.GuardarEmpresa(model, UserId);

            return Ok(new{success = true,message = "Configuración guardada correctamente"});
        }
        catch (Exception ex)
        {
            return BadRequest(new{success = false,message = $"se ha presentado un problema: {ex.Message}"});
        }
    }
    [HttpPost]
    public async Task<IActionResult> SetApariencia([FromBody] AparienciaVM model)
    {
        try
        {
            var result = await _configService.GuardarApariencia(model, UserId);

            return Ok(new { success = result.success , message = result.message });
        }
        catch (Exception ex)
        {
            return BadRequest(new{success = false,message = $"se ha presentado un problema: {ex.Message}"});
        }
    }
    [HttpPost]
    public async Task<IActionResult> SetRegional([FromBody] RegionalVM model)
    {
        try
        {
            await _configService.GuardarRegional(model, UserId);

            return Ok(new { success = true, message = "Configuración guardada correctamente" });
        }
        catch (Exception ex)
        {
            return BadRequest(new{success = false,message = $"se ha presentado un problema: {ex.Message}"});
        }
    }
    [HttpPost]
    public async Task<IActionResult> SetSMTP([FromBody] SMTPVM model)
    {
        try
        {
            await _configService.GuardarSMTP(model, UserId);

            return Ok(new { success = true, message = "Configuración guardada correctamente" });
        }
        catch (Exception ex)
        {
            return BadRequest(new{success = false,message = $"se ha presentado un problema: {ex.Message}"});
        }
    }
    [HttpPost]
    public async Task<IActionResult> SetWhatsapp([FromBody] WhatsappVM model)
    {
        try
        {
            await _configService.GuardarWahtsapp(model, UserId);

            return Ok(new { success = true, message = "Configuración guardada correctamente" });
        }
        catch (Exception ex)
        {
            return BadRequest(new{success = false,message = $"se ha presentado un problema: {ex.Message}"});
        }
    }
    [HttpPost]
    public IActionResult SetBD([FromBody] BDVM model)
    {
        try
        {
             _configService.GuardarBD(model, UserId);

            return Ok(new { success = true, message = "Configuración guardada correctamente" });
        }
        catch (Exception ex)
        {
            return BadRequest(new{success = false,message = $"se ha presentado un problema: {ex.Message}"});
        }
    }
    [HttpPost]
    public IActionResult SetJWT([FromBody] JWTVM model)
    {
        try
        {
            _configService.GuardarJWT(model, UserId);

            return Ok(new{ success = true, message = "Configuración guardada correctamente" });
        }
        catch (Exception ex)
        {
            return BadRequest(new{ success = false, message = $"se ha presentado un problema: {ex.Message}" });
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetPermisosRol(int idRol)
    {
        var result = await _configService.ObtenerPermisosRol(idRol);

        return Ok(new { success = true, data = result });
    }
    [HttpGet]
    public IActionResult GetRoles()
    {
        var result = _configService.ObtenerRoles();

        return Ok(new { success = true, data = result });
    }
    [HttpPost]
    public async Task<IActionResult> SerPermisosRol([FromBody] GuardarPermisosVM model) {
        try 
        {
            if(model is null)
                return BadRequest(new { success = false, message = "los datos ingresados estan en blanco" });

            var result = await _configService.GuardarPermisos(model);

            return Ok(new { result.success, result.message});
        } 
        catch (Exception ex)
        {
            return StatusCode(404,new { success = false, message = ex.Message});
        }
    }
    [HttpPost]
    public async Task<IActionResult> CrearRol(string nombre)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return BadRequest(new{success = false,message = "El nombre es obligatorio"});
            }

            var existe = await _context.Roles
                .AnyAsync(x => x.nombre == nombre);

            if (existe)
            {
                return Ok(new{success = false,message = "El rol ya existe"});
            }

            var rol = new AppServiceAndTravel.Areas.Admin.Models.Roles
            {
                nombre = nombre,
                fechaCreacion = DateTime.Now
            };

            _context.Roles.Add(rol);

            await _context.SaveChangesAsync();

            return Ok(new{success = true,data = new {idRol = rol.idRol}});}

        catch (Exception ex)
        {
            return StatusCode(500, new{success = false,message = ex.Message});
        }
    }
}