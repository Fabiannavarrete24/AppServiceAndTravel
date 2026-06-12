using AppServiceAndTravel.Areas.Admin.Services;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using AppServiceAndTravel.ViewModels;
using Dapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Data;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AppServiceAndTravel.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IUsersService _usersService;
        public readonly IWebHostEnvironment _hostEnvironment;       

        public AccountController(IAuthService authService,IWebHostEnvironment hostEnvironment, IUsersService usersService)
        {
            _authService = authService;
            _hostEnvironment = hostEnvironment;
            _usersService = usersService;

        }
        public IActionResult TokenInValid() { 
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string message = null!)
        {

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var roleClaim = User.FindFirst(ClaimTypes.Role)?.Value?.ToLower();

                if (roleClaim == "administrador")
                {
                    return RedirectToAction("Dashboard", "App", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Dashboard", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Reset(string token)
        {
            if (token == null || token == "")
            {
                return RedirectToAction("Error", "Shared");
            }
            var usuario = _usersService.UsuarioPorToken(token);
            if(usuario.success)
            if (usuario.data == null || usuario.data.restaurada == false || usuario.data.tokenDateExpiration > DateTime.UtcNow || usuario.data.tokenDateExpiration is null)
            {
                return RedirectToAction("TokenInValid");
            }

            return View(new RestoreVM { Token = token });
        }

        [HttpGet]
        public IActionResult Confirm(string token)
        {
            var alerta = _authService.ConfirmaCuenta(token);
            if (alerta == null)
            {
                return BadRequest("El token no es válido o ya expiró.");
            }
            return Ok(alerta);
        }  

        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string usuario,string clave)
        {
            var result = await _authService.Login(usuario,clave);

            if (!result.success)
            {
                return BadRequest(new{success = false,message = result.message});
            }

            var identity = new ClaimsIdentity(
                result.claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity),
                new AuthenticationProperties
                {
                    IsPersistent = true,
                    AllowRefresh = true
                });

            return Ok(new{success = true,message = result.message});

        }

        [HttpPost]
        public async Task<(bool success,string message)> SetRestablecerCuenta(string token, int? usuario)
        {
            try
            {
               var result = await _authService.RestablecerCuenta(token, usuario);
               
                return (result.success, result.message);
            }
            catch (Exception ex)
            {
                return (false,$"se ha generado un error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EnvioCorreoRestablecerCuenta(string correo)
        {
            try
            {
                if (string.IsNullOrEmpty(correo))
                    return BadRequest(new { success = false, message = "El correo no puede estar en blanco" });

                var baseUrl = $"{Request.Scheme}://{Request.Host}";

                var result = await _authService.CorreoRestablecerCuenta(correo, baseUrl);
                if (!result.success)
                    return BadRequest(new { success = false, message = result.message });

                return Ok(new { success = true, message = result.message });
            }
            catch (Exception ex) {
                return BadRequest(new { success = false,message = $"se ha presentado un problema: {ex.Message}"});
            }
        }

        [HttpPost]
        public IActionResult RestablecerContraseña(string token, string clave, string confirmarClave)
        {
            var icono = "";
            var message = "";
            if (clave != confirmarClave)
            {
                return Json(new { icono = "error", message = "Las contraseñas no coinciden." });
            }

            try
            {
                var result = _authService.RestablecerContraseña(token,clave,confirmarClave);
                return Ok(new { icono, message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"Error al restablecer contraseña: {ex.Message}" });
            }
        }        

        //[HttpGet]
        //public IActionResult LoginExterno(string proveedor, string urlRetorno = null!)
        //{
        //    if (string.IsNullOrEmpty(proveedor))
        //    {
        //        return RedirectToAction("Login", new { message = "Proveedor no válido." });
        //    }

        //    var urlRedireccion = Url.Action("RegistrarUsuarioExterno", values: new { urlRetorno });
        //    var propiedades = new AuthenticationProperties
        //    {
        //        RedirectUri = urlRedireccion
        //    };
        //    _utilities.RegistrarLog("Se ejecuto Correctamente", "LoginExterno", "");
        //    return new ChallengeResult(proveedor, propiedades);
        //}

        //[HttpGet]
        //public IActionResult RegistrarUsuarioExterno(string urlRetorno = null!, string remoteError = null!)
        //{
        //    urlRetorno ??= Url.Content("~/");

        //    if (remoteError != null)
        //    {
        //        return RedirectToAction("Login", new { message = $"Error con el proveedor: {remoteError}" });
        //    }

        //    var usuario = User;

        //    if (usuario == null || !usuario.Identity?.IsAuthenticated == true)
        //    {
        //        return RedirectToAction("Login", new { message = "No se pudo autenticar con el proveedor externo." });
        //    }

        //    var correo = usuario.FindFirstValue(ClaimTypes.Email);
        //    var nombre = usuario.FindFirstValue(ClaimTypes.Name);
        //    var userName = correo?.Split('@')[0] ?? "externo";
        //    var clave = Guid.NewGuid().ToString();

        //    _utilities.RegistrarLog($"{correo} - {nombre}", "RegistroUsuarioExterno", "LOGIN_EXTERNO");

        //    if (string.IsNullOrEmpty(correo))
        //    {
        //        return RedirectToAction("Login", new { message = "No se recibió un correo válido del proveedor." });
        //    }

        //    var usuarioExistente = _authService.ObtenerUsuarioPorCorreo(correo);

        //    if (usuarioExistente.correo == null)
        //    {
        //        var registro = _userService.RegistrarUsuario(nombre ?? "Usuario Externo", userName, clave, correo, null!, 0, "_utilities.GenerarToken(50)!");
        //        if (registro.valid == 0)
        //        {
        //            return RedirectToAction("Login", new { message = "No se pudo registrar al usuario externo: " + registro.message });
        //        }

        //        var resultadoLogin = Login(correo, clave);
        //        return RedirectToAction("Inicio", "App");
        //    }
        //    else
        //    {
        //        var resultadoLogin = Login(usuarioExistente.correo, usuarioExistente.Password!);
        //        return RedirectToAction("Inicio", "App");
        //    }
        //}

    }

}


