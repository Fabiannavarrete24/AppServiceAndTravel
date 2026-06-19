using AppServiceAndTravel.Areas.Admin.Models;
using AppServiceAndTravel.Areas.Admin.Services;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MySqlConnector;
using Npgsql;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static AppServiceAndTravel.Services.AuthService;

namespace AppServiceAndTravel.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> ReturnToken(AuthRequest autorizacion);
        Task<AuthResponse> ReturnRefreshToken(RefreshTokenRequest refreshTokenRequest, int idUsuario);
        Task<LoginResponseVM> Login(string usuario, string clave);
        Task<(bool success, string message)> ConfirmaCuenta(string token);
        string GenerateToken(List<Claim> claims);
        string GenerateRefreshToken();
        List<MenuVM> NavProcess(int idUser);
        HistLoginVM RegisterHistLogin(int idUser, string userName, bool valid, string message);
        //List<Claim> BuildClaims(ApplicationUser user, List<Procesos> menu);
        (bool success, string message) RestablecerContraseña(string token, string clave, string confirmarClave);
        Task<(bool success, string message)> RestablecerCuenta(string token, int? usuario);
        Task<(bool success, string message)> CorreoRestablecerCuenta(string correo, string url);

    }
    public class AuthService : IAuthService
    {
        private readonly ApplicationDBContext _context;
        private readonly IConfiguration _configuration;
        private readonly IUsersService _usersService;
        private readonly UtilitiesServices _utilities;
        private readonly IEmailService _emailService;
        private readonly IJwtService _jwtService;
        public AuthService(ApplicationDBContext context, IConfiguration configuration, IUsersService usersService, UtilitiesServices utilities, IEmailService emailService, IJwtService jwtService)
        {
            _context = context;
            _configuration = configuration;
            _usersService = usersService;
            _utilities = utilities;
            _emailService = emailService;
            _jwtService = jwtService;
        }

        private LoginResponseVM Fail(string message)
        {
            return new LoginResponseVM
            {
                success = false,
                message = message
            };
        }
        public string GenerateToken(List<Claim> claims)
        {
            var key = _configuration["JwtSettings:SecretKey"];
            var keyBytes = Encoding.ASCII.GetBytes(key!);
            var ExpireToken = Convert.ToInt32(_configuration["JwtSettings:ExpirationMinutes"]);
            var identity = new ClaimsIdentity(claims);

            var tokenDescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.UtcNow.AddMinutes(ExpireToken),
                SigningCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                    new SymmetricSecurityKey(keyBytes),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
        public string GenerateRefreshToken()
        {

            var byteArray = new byte[64];
            var refreshToken = "";

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(byteArray);
                refreshToken = Convert.ToBase64String(byteArray);
            }

            return refreshToken;
        }
        private async Task<AuthResponse> SaveHistRefreshToken(int id, string token, string refreshToken)
        {
            try
            {
                int expirationMinutes = Convert.ToInt32(_configuration["JwtSettings:ExpirationMinutes"]);

                var histRefreshToken = new HistRefreshToken
                {
                    idUsuario = id,
                    Token = token,
                    RefreshToken = refreshToken,
                    fechaCreacion = DateTime.UtcNow,
                    fechaExpiracion = DateTime.UtcNow.AddMinutes(expirationMinutes),
                    activo = true
                };

                _context.HistRefreshToken.Add(histRefreshToken);

                await _context.SaveChangesAsync();

                return new AuthResponse
                {
                    Token = token,
                    RefreshToken = refreshToken,
                    sucess = true,
                    message = "Token generado",
                    expiration = expirationMinutes.ToString()
                };
            }
            catch (Exception ex)
            {
                var message = "Error interno del servidor: " + ex.Message;

                return new AuthResponse
                {
                    Token = null!,
                    sucess = false,
                    message = message
                };
            }
        }
        public async Task<AuthResponse> ReturnToken(AuthRequest autorizacion)
        {
            try
            {
                var login = await _context.Usuarios
                    .FirstOrDefaultAsync(u =>
                        (u.userName == autorizacion.user ||
                         u.correo == autorizacion.user)
                        &&
                        u.password == autorizacion.password
                    );

                if (login == null)
                {
                    return new AuthResponse
                    {
                        sucess = false,
                        message = "Usuario o contraseña incorrecta"
                    };
                }

                var menu = NavProcess(login.idUsuario);

                var claims = BuildClaims(login, menu);

                var token = GenerateToken(claims);

                var refresh = GenerateRefreshToken();

                return await SaveHistRefreshToken(login.idUsuario, token, refresh);
            }
            catch (Exception ex)
            {
                return new AuthResponse
                {
                    sucess = false,
                    message = ex.Message
                };
            }
        }
        public async Task<AuthResponse> ReturnRefreshToken(RefreshTokenRequest refreshTokenRequest, int idUsuario)
        {
            try
            {
                var refreshTokenResult = await _context.HistRefreshToken
                    .FirstOrDefaultAsync(h =>
                        h.RefreshToken == refreshTokenRequest.RefreshToken &&
                        h.Token == refreshTokenRequest.TokenExpirate &&
                        h.idUsuario == idUsuario
                    );

                var usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(u =>
                        u.idUsuario == idUsuario
                    );

                usuario = new ApplicationUser();

                if (refreshTokenResult == null)
                {
                    return new AuthResponse
                    {
                        sucess = false,
                        message = "El token ingresado no existe"
                    };
                }

                var refreshTokenGenerado = GenerateRefreshToken();

                var menu = NavProcess(idUsuario);

                var claims = BuildClaims(usuario, menu);

                var tokenGenerado = GenerateToken(claims);

                return await SaveHistRefreshToken(idUsuario, tokenGenerado, refreshTokenGenerado);
            }
            catch (Exception ex)
            {
                var message = "Error interno del servidor: " + ex.Message;

                _utilities.RegistrarLog(ex.Message, "ReturnRefreshToken");

                return new AuthResponse
                {
                    Token = null!,
                    sucess = false,
                    message = message
                };
            }
        }
        #region Login
        public HistLoginVM RegisterHistLogin(int idUser, string userName, bool valid, string message)
        {
            try
            {

                var histLogin = new HistLogin
                {
                    idUsuario = idUser,
                    userName = userName,
                    valido = valid,
                    inSesion = valid,
                    mensaje = message,
                    fechaCreacion = DateTime.UtcNow
                };

                _context.HistLogin.Add(histLogin);
                _context.SaveChanges();

                return new HistLoginVM
                {
                    success = true,
                    message = message
                };
            }
            catch (Exception ex)
            {
                return new HistLoginVM
                {
                    success = false,
                    message = ex.Message
                };
            }
        }
        public List<MenuVM> NavProcess(int idUser)
        {
            var idRol = _context.Usuarios
                .Where(x => x.idUsuario == idUser)
                .Select(x => x.idRol)                
                .FirstOrDefault();

            if (idRol <= 0)
            {
                return new List<MenuVM>();
            }

            var procesos = _context.Permisos
                .Where(p => p.idRol == idRol)
                .Select(p => p.proceso!)
                .Distinct()
                .OrderBy(o => o.orden)              
                .Select(x => new MenuVM
                {
                    idProceso = x.idProceso,
                    proceso = x.proceso,
                    area = x.area,
                    controlador = x.controlador,
                    url = x.url,
                    icono = x.icono,
                    idProcesoPadre = x.idProcesoPadre,
                    orden = x.orden
                })
                .ToList();
            return ConstruirMenu(procesos, null);
        }
        private List<MenuVM> ConstruirMenu(List<MenuVM> procesos, int? idPadre)
        {
            var hijos = procesos
                .Where(x =>
                    (idPadre == null && (x.idProcesoPadre == null || x.idProcesoPadre == 0))
                    ||
                    x.idProcesoPadre == idPadre
                )
                .OrderBy(x => x.orden)
                .ToList();

            foreach (var item in hijos)
            {
                item.hijos = ConstruirMenu(
                    procesos,
                    item.idProceso
                );
            }
            return hijos;
        }
        public async Task<LoginResponseVM> Login(string usuario, string clave)
        {
            var user = _context.Usuarios.FirstOrDefault(u => u.userName == usuario);

            if (user == null)
                return Fail("Usuario o contraseña incorrectos");

            var hasher = new PasswordHasher<string>();
            bool isValid = false;

            try
            {
                var result = hasher.VerifyHashedPassword(usuario, user.password!, clave);
                isValid = result != PasswordVerificationResult.Failed;
            }
            catch (FormatException)
            {
                if (user.password == clave)
                {
                    var newHash = hasher.HashPassword(usuario, clave);
                    var UpdateUser = await _context.Usuarios.FindAsync(user.idUsuario);

                    if (UpdateUser != null)
                    {
                        UpdateUser.password = newHash;

                        await _context.SaveChangesAsync();
                    }

                    isValid = true;
                }
            }

            if (!isValid)
            {
                RegisterHistLogin(user.idUsuario, user.userName!, false, "Usuario o contraseña incorrectos.");
                return Fail("Usuario o contraseña incorrectos.");
            }

            if (user.fechaCambioClave <= DateTime.UtcNow)
            {
                RegisterHistLogin(user.idUsuario, user.userName!, false, "Su contraseña se encuentra vencida, debe cambiarla.");
                return Fail("Su contraseña se encuentra vencida, debe cambiarla.");
            }

            if (user.restaurada == true)
            {
                RegisterHistLogin(user.idUsuario, user.userName!, false, "Solicitaste un cambio de contraseña, revise su bandeja de entrada o genere una nueva solicitud.");
                return Fail("Solicitaste un cambio de contraseña, revise su bandeja de entrada o genere una nueva solicitud.");
            }

            if (user.activo == false || user.fechaBaja != null)
            {
                RegisterHistLogin(user.idUsuario, user.userName!, false, "El usuario se encuentra deshabilitado.");
                return Fail("El usuario se encuentra deshabilitado.");
            }

            var UpdateHistLogin = await _context.HistLogin.FindAsync(user.idUsuario);

            if (UpdateHistLogin != null)
            {
                UpdateHistLogin.inSesion = true;

                await _context.SaveChangesAsync();
            }


            var menu = NavProcess(user.idUsuario);

            if (menu == null)
            {
                RegisterHistLogin(user.idUsuario, usuario, false, "Sin permisos");
                return Fail("El usuario no tiene permisos para acceder al sistema");
            }
            var claims = BuildClaims(user, menu);

            if (claims == null || !claims.Any())
            {
                RegisterHistLogin(user.idUsuario, user.userName!, false, "Sin claims");
                return Fail("No se pudieron generar claims");
            }

            RegisterHistLogin(user.idUsuario, user.userName!, true, "Bienvenido al sistema");
            user.ultimoAcceso = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return new LoginResponseVM
            {
                user = user,
                claims = claims,
                success = true,
                message = "Bienvenido al sistema",
            };
        }
        private List<Claim> BuildClaims(ApplicationUser user, List<MenuVM> menu)
        {
            var claims = new List<Claim>
             {
                 new Claim(ClaimTypes.NameIdentifier, user.idUsuario.ToString()),
                 new Claim(ClaimTypes.Name, string.IsNullOrEmpty(user.nombreCompleto) ? user.userName! : user.nombreCompleto),
                 new Claim(ClaimTypes.Email, user.correo ?? ""),
                 new Claim(ClaimTypes.Role, user.admin == true ? "administrador" : "usuario"),
                 new Claim("permiso", "cotizacion.crear"),
                 new Claim("permiso", "proveedor.editar")
             };

            foreach (var item in menu)
            {
                if (!string.IsNullOrEmpty(item.url))
                {
                    claims.Add(new Claim("Permisos", item.url.ToLower()));
                }
            }

            return claims;
        }
        #endregion        
        public async Task<(bool success, string message)> ConfirmaCuenta(string token)
        {
            if (string.IsNullOrEmpty(token))
                return (false, "El token no puede estar vacío.");

            try
            {
                var UpdateUser = await _context.Usuarios.FirstOrDefaultAsync(u => u.token == token);

                if (UpdateUser != null)
                {
                    UpdateUser.confirmada = true;
                    UpdateUser.restaurada = false;

                    await _context.SaveChangesAsync();
                }
                return (true, "Cuenta Confirmada");
            }
            catch (Exception ex)
            {
                return (false, $"Error al confirmar la cuenta: {ex.Message}");
            }
        }
        public (bool success, string message) RestablecerContraseña(string token, string clave, string confirmarClave)
        {
            var message = "No se ha podido cambiar la contraseña";

            if (clave != confirmarClave)
                return (false, "Las contraseñas no coinciden.");

            if (string.IsNullOrEmpty(token))
                return (false, "El token no puede estar vacío.");

            try
            {
                var UpdateUser = _context.Usuarios.FirstOrDefault(u => u.token == token);

                if (UpdateUser == null || UpdateUser.restaurada == false || UpdateUser.fechaExpiracionToken > DateTime.UtcNow)
                {
                    return (false, "El token no es válido o ha expirado.");
                }

                if (UpdateUser != null)
                {
                    var hasher = new PasswordHasher<string>();
                    var newHash = hasher.HashPassword(UpdateUser!.userName!, clave);

                    UpdateUser.password = newHash;
                    UpdateUser.restaurada = false;
                    UpdateUser.fechaExpiracionToken = DateTime.UtcNow.AddMinutes(30);

                    _context.SaveChanges();
                    message = "Contraseña actualizada con exito";
                }

                return (true, message);
            }
            catch (Exception ex)
            {
                return (false, $"Se ha presentado un problema: {ex.Message}");
            }
        }
        public async Task<(bool success, string message)> RestablecerCuenta(string token, int? usuario)
        {
            try
            {
                var user = _context.Usuarios.FirstOrDefault(u => u.idUsuario == usuario);

                if (user is null)
                {
                    return new(false, "usuario no encontrado");
                }

                user.restaurada = true;
                user.token = token;
                await _context.SaveChangesAsync();

                return new(true, "Cuenta restablecida con exito");
            }
            catch (Exception ex)
            {
                return new(false, ex.Message);
            }
        }
        public async Task<(bool success, string message)> CorreoRestablecerCuenta(string correo, string url)
        {

            if (string.IsNullOrEmpty(correo))
                return (false, "El correo no puede estar vacío.");

            var usuario = _usersService.ObtenerUsuarioPorCorreo(correo);

            if (usuario.data == null)
            {
                return (false, "Correo no encontrado.");
            }
            var jwt = _jwtService.ConfigJWT();
            var token = _utilities.GenerateToken(usuario.data.Username!, jwt);

            if (string.IsNullOrEmpty(token))
                return (false, "No se logro generar el Token.");

            var restablcer = await RestablecerCuenta(token!, usuario.data.idUsuario);

            if (!restablcer.success)
            {
                return (false, "No se logro Restablecer la cuenta");
            }

            var formato = _utilities.FormatosCorreos("RESETPW");

            if (formato == null)
            {
                return (false, "No se encontró el formato del correo.");
            }

            string htmlBody = formato.mensaje!.Replace("{nombreCompleto}", usuario.data.nombreCompleto).Replace("{URL}", $"{url}/account/reset?token={token}");

            try
            {
                await _emailService.Enviarcorreo(usuario.data.correo!, null!, formato.titulo!, htmlBody, null!, null!);
            }
            catch (Exception ex)
            {
                return (false, "Error al enviar el correo:" + ex.Message);
            }

            return (true, "La cuenta ha sido Restablecida con exito, revisa tu bandeja de entrada");
        }

    }
}
