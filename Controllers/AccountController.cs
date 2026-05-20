using Npgsql;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.ViewModels;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data;
using AppServiceAndTravel.Services;
using Microsoft.AspNetCore.Identity;
using Dapper;
using MySql.Data.MySqlClient;


namespace AppServiceAndTravel.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDBContext dbContext;
        private readonly IConfiguration _configuration;
        private readonly EmailService _Service;
        private readonly Utilities _utilities;
        public readonly IWebHostEnvironment _hostEnvironment;
        
        private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(6);

        public AccountController(ApplicationDBContext dbContext, IConfiguration configuration, EmailService Service, Utilities utilities,IWebHostEnvironment hostEnvironment)
        {
            this.dbContext = dbContext;
            _configuration = configuration;
            _Service = Service;
            _utilities = utilities;
            _hostEnvironment = hostEnvironment;

        }

        [HttpGet]
        public IActionResult Login(string message = null!)
        {
            if (!string.IsNullOrEmpty(message))
            {
                ViewData["message"] = message;
            }

            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var roleClaim = User.FindFirst(ClaimTypes.Role)?.Value?.ToLower();

                if (roleClaim == "administrador")
                {
                    return RedirectToAction("Dashboard", "App", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Dashboard", "App");
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
        public IActionResult Actualizar(string token)
        {
            //if (token == null || token == "")
            //{
            //    return RedirectToAction("Error", "Shared");
            //}
            //var usuario = GetUsuarioPorToken(token);
            //if (usuario == null || usuario.restore == 0 || usuario.tokenDateExpiration > DateTime.UtcNow)
            //{
            //    return RedirectToAction("TokenInValid");
            //}

            //return View(new RestoreVM { Token = token });
            return View();
        }

        [HttpGet]
        public IActionResult Confirmar(string token)
        {
            //var alerta = ConfirmaCuenta(token);
            //if (alerta == null)
            //{
            //    return BadRequest("El token no es válido o ya expiró.");
            //}
            //return Ok(alerta);
            return View();
        }
        public IDbConnection GenerateConnection()
        {
            var provider = _configuration["ConnectionStrings:DatabaseProvider"]?.ToLower();
            var connString = _configuration.GetConnectionString("DefaultConnection");

            return provider switch
            {
                "mysql" => new MySqlConnection(connString),
                "postgresql" => new NpgsqlConnection(connString),
                _ => throw new Exception($"Proveedor no soportado: {provider}")
            };
        }   
        private HistLoginVM RegisterHistLogin(int idUsuario, string userName, bool valid, string message, DateTime registerDate)
        {
             try
            {
                using MySqlConnection con = new MySqlConnection(dbContext.Database.GetConnectionString());
                con.Open();

                using MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO loginhistory ( idUsuario, userName, valid, message, registerDate)
                    VALUES( @idUsuario, @userName, @valid, @message, @registerDate);", con);

                cmd.Parameters.Add("@idUsuario", MySqlDbType.VarChar).Value = idUsuario;
                cmd.Parameters.Add("@userName", MySqlDbType.VarChar).Value = userName;
                cmd.Parameters.Add("@valid", MySqlDbType.VarChar).Value = valid;
                cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;
                cmd.Parameters.Add("@registerDate", MySqlDbType.VarChar).Value = registerDate;

                cmd.ExecuteNonQuery();

                return new HistLoginVM
                {
                    success = true,
                    mensage = message
                };
            }
            catch (Exception ex)
            {
                return new HistLoginVM
                {
                    success = false,
                    mensage = ex.Message
                };
            }
        } 
        
        // public LoginResponseVM? ValidaUsuario(string usuario, string clave)
        // {
        //     var success = false;
        //     var message = "Usuario o contraseña incorrectos";
        //     var sql = @"
        //         SELECT 
        //             idUsuario,
        //             userName,
        //             email,
        //             admin,
        //             changePassowrdDate,
        //             active,
        //             restore,
        //             confirm
        //         FROM Users
        //         WHERE userName = @usuario 
        //         AND password = @clave
        //     ";

        //     using var con = GenerateConnection();

        //     con.Open();

        //     var user = con.QueryFirstOrDefault<LoginResponseVM>(sql, new { usuario, clave });

        //     if(user != null)
        //     {
        //         if(user.changePassowrdDate == DateTime.Now)
        //         {                      
        //            success = false;
        //            message = "su contraseña se encuentra vencida debe cambiarla";          
        //            RegisterHistLogin(user.idUsuario,usuario,success,message,DateTime.Now);  

        //            return user = new LoginResponseVM
        //             {
        //                 success = false,
        //                 message = message
        //             };
                    
        //         }

        //         if(user.restore == 1)
        //         {                    
        //            success = false;
        //            message = "su contraseña se encuentra vencida debe cambiarla";       
        //            RegisterHistLogin(user.idUsuario,usuario,success,message,DateTime.Now);

        //             return user = new LoginResponseVM
        //             {
        //                 success = false,
        //                 message = message
        //             };                    
        //         }

        //         var nav = GetNavProcess(user.idUsuario);

        //         if(nav == null)
        //         {
        //            success = false;
        //            message = "el usuario no tiene permisos para acceder al sistema";       
        //            RegisterHistLogin(user.idUsuario,usuario,success,message,DateTime.Now);

        //             return user = new LoginResponseVM
        //             {
        //                 success = false,
        //                 message = message
        //             };   
        //         }

        //         user.success = true;
        //         user.message = "Bienvenido al sistema";
        //         RegisterHistLogin(user.idUsuario,usuario,user.success,user.message,DateTime.Now);
        //     }

        //     if(user == null)
        //     {
        //         RegisterHistLogin(0,usuario,false,"Usuario o contraseña incorrectos",DateTime.Now);
        //     }

        //     return user;
            
        // }
        public LoginResponseVM ValidaUsuario(string usuario, string clave)
        {
            var sql = @"
                SELECT 
                    idUsuario,
                    userName,
                    email,
                    admin,
                    changePassowrdDate,
                    active,
                    restore,
                    confirm,
                    password
                FROM Users
                WHERE userName = @usuario
            ";

            using var con = GenerateConnection();
            con.Open();

            var user = con.QueryFirstOrDefault<LoginResponseVM>(sql, new { usuario });

            // Usuario no existe
            if (user == null)
            {
                RegisterHistLogin(0, usuario, false, "Usuario o contraseña incorrectos", DateTime.Now);
                return Fail("Usuario o contraseña incorrectos");
            }

            // Validar contraseña (ejemplo simple, deberías usar hash)
            var hasher = new PasswordHasher<string>();
            var result = hasher.VerifyHashedPassword(usuario, user.password!, clave);

            if (result == PasswordVerificationResult.Failed)
            {
                RegisterHistLogin(user.idUsuario, usuario, false, "Usuario o contraseña incorrectos", DateTime.Now);
                return Fail("Usuario o contraseña incorrectos");
            }

            // Validar expiración
            if (user.changePassowrdDate <= DateTime.Now || user.restaurada == 1)
            {
                RegisterHistLogin(user.idUsuario, usuario, false, "Contraseña vencida", DateTime.Now);
                return Fail("Su contraseña se encuentra vencida, debe cambiarla");
            }

            // Validar permisos
            var nav = GetNavProcess(user.idUsuario);
            if (nav == null)
            {
                RegisterHistLogin(user.idUsuario, usuario, false, "Sin permisos", DateTime.Now);
                return Fail("El usuario no tiene permisos para acceder al sistema");
            }

            // OK
            RegisterHistLogin(user.idUsuario, usuario, true, "Bienvenido al sistema", DateTime.Now);

            user.success = true;
            user.message = "Bienvenido al sistema";
            return user;
        }
        private LoginResponseVM Fail(string message)
        {
            return new LoginResponseVM
            {
                success = false,
                message = message
            };
        }
        public List<Procesos> GetNavProcess(int idUsuario)
        {
            using var con = GenerateConnection();

            con.Open();
            var sql = @"SELECT p.idProcess,p.url,p.process,p.area,p.controller,p.icon,p.idParentProcess
                FROM users u
                INNER JOIN userroles ur on u.idUsuario = ur.idUsuario
                INNER JOIN roles r on ur.idRole = r.idRole
                INNER JOIN permissions pr on pr.idRol = r.idRole
                INNER JOIN process p on pr.idProcess = p.idProcess
                WHERE u.idUsuario = @ID;";

            var results = con.Query<Procesos>(sql, new { ID = idUsuario }).ToList();

            foreach (var menu in results)
            {
                menu.InverseidParentprocesoNavigation =
                    results.Where(m => m.idParentproceso == menu.IdProceso).ToList();
            }

            return results.Where(r => r.idParentproceso == 0).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string usuario, string clave)
        {
            var result = ValidaUsuario(usuario, clave);

            if (result!.idUsuario <= 0 || !result.success)
            {
                return Ok(new
                {
                    success = result.success,
                    message = result.message
                });
            }

            var menu = GetNavProcess(result.idUsuario);

            var menuJson = JsonSerializer.Serialize(menu, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            });

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, result.userName ?? ""),
                new Claim(ClaimTypes.Role, result.admin == 1 ? "administrador" : "usuario"),
                new Claim(ClaimTypes.Sid, result.idUsuario.ToString()),
                new Claim("Menu", menuJson)
            };

            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity),
                new AuthenticationProperties
                {
                    IsPersistent = true,
                    AllowRefresh = true
                }
            );

            return Ok(new
            {
                success = result.success,
                message = result.message
            });
        }
        
        //[HttpGet]
        //public EmailFormat GetFormatosCorreos(int tipo)
        //{
        //    var results = new EmailFormat();
        //    try
        //    {
        //        using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
        //        {
        //            con.Open();
        //            using (var transaction = con.BeginTransaction())
        //            {
        //                FbCommand cmd = new FbCommand
        //                {
        //                    Connection = con,
        //                    Transaction = transaction,
        //                    CommandText = "SELECT ASUNTO, message FROM FORMATOS_CORREOS WHERE ID_FORMATO = @ID"
        //                };

        //                cmd.Parameters.Add("@ID", FbDbType.Integer).Value = tipo;

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        results = new EmailFormat
        //                        {
        //                            title = reader.GetString(reader.GetOrdinal("ASUNTO")),
        //                            message = reader.GetString(reader.GetOrdinal("MENSAJE")),
        //                        };
        //                    }
        //                    else
        //                    {
        //                        results = null;
        //                    }
        //                }

        //                transaction.Commit();
        //            }
        //        }
        //        if (results != null)
        //        {
        //            return results;
        //        }
        //        else
        //        {
        //            return results!;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        [HttpGet]
        public string GenerarToken(int Longitud)
        {
            string results = "";
            try
            {
                //using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
                //{
                //    con.Open();
                //    using (var transaction = con.BeginTransaction())
                //    {
                //        FbCommand cmd = new FbCommand
                //        {
                //            Connection = con,
                //            Transaction = transaction,
                //            CommandText = "SELECT CLAVE FROM PROC_GENERAR_CLAVE_ALEATORIA(@LONGITUD)"
                //        };

                //        cmd.Parameters.Add("@LONGITUD", FbDbType.Integer).Value = Longitud;

                //        using (var reader = cmd.ExecuteReader())
                //        {
                //            if (reader.Read())
                //            {
                //                results = reader.GetString(reader.GetOrdinal("CLAVE"));

                //            }
                //            else
                //            {
                //                results = null!;
                //            }
                //        }

                //        transaction.Commit();
                //    }
                //}
                if (results != null)
                {
                    return results;
                }
                else
                {
                    return results!;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //[HttpPost]
        //public bool SetRestablecerCuenta(string token, int? usuario)
        //{
        //    try
        //    {
        //        using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
        //        {
        //            con.Open();
        //            using (var transaction = con.BeginTransaction())
        //            {
        //                FbCommand cmd = new FbCommand
        //                {
        //                    Connection = con,
        //                    Transaction = transaction,
        //                    CommandText = "UPDATE USUARIOS SET RESTABLECER = 1, TOKEN = @TOKEN WHERE ID_USUARIO = @ID"
        //                };

        //                cmd.Parameters.Add("@TOKEN", FbDbType.Integer).Value = token;
        //                cmd.Parameters.Add("@ID", FbDbType.Integer).Value = usuario;
        //                cmd.ExecuteReader();
        //                transaction.Commit();

        //                return true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //[HttpPost]
        //public Alerts ConfirmaCuenta(string token)
        //{
        //    if (string.IsNullOrEmpty(token))
        //        throw new ArgumentException("El token no puede estar vacío.");

        //    Alerts alerta = null!;
        //    try
        //    {
        //        using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
        //        {
        //            con.Open();
        //            using (FbCommand cmd = new FbCommand("PROC_UPD_TOKEN_USUARIO", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("TOKEN", FbDbType.VarChar).Value = token;
        //                cmd.Parameters.Add("RESTABLECER", FbDbType.Integer).Value = 1;
        //                cmd.Parameters.Add("CLAVE", FbDbType.VarChar).Value = (object)null! ?? DBNull.Value;
        //                cmd.Parameters.Add("FILTRO", FbDbType.VarChar).Value = "CONFIRMADO";

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        alerta = new Alerts
        //                        {
        //                            icon = reader.GetString(reader.GetOrdinal("ICONO")),
        //                            message = reader.GetString(reader.GetOrdinal("message")),
        //                        };
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al confirmar la cuenta", ex);
        //    }

        //    return alerta ?? throw new Exception("No se pudo confirmar la cuenta.");
        //}

        [HttpGet]
        public UserVM GetUsuarioPorToken(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("El token no puede estar vacío.");

            UserVM usuario = null!;
            try
            {
                //using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
                //{
                //    con.Open();
                //    using (FbCommand cmd = new FbCommand("PROC_GET_USUARIO_POR_TOKEN", con))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.Add("TOKEN", FbDbType.VarChar).Value = token;

                //        using (var reader = cmd.ExecuteReader())
                //        {
                //            if (reader.Read())
                //            {
                //                usuario = new UserVM
                //                {
                //                    Id = reader.IsDBNull(reader.GetOrdinal("COD_USUARIO")) ? 0 : reader.GetInt32(reader.GetOrdinal("COD_USUARIO")),
                //                    Valid = reader.IsDBNull(reader.GetOrdinal("Valid")) ? 0 : reader.GetInt32(reader.GetOrdinal("Valid")),
                //                    message = reader.IsDBNull(reader.GetOrdinal("message")) ? null : reader.GetString(reader.GetOrdinal("message")),
                //                    Password = reader.IsDBNull(reader.GetOrdinal("CLAVE")) ? null : reader.GetString(reader.GetOrdinal("CLAVE")),
                //                    restore = reader.IsDBNull(reader.GetOrdinal("RESTABLECER")) ? 0 : reader.GetInt32(reader.GetOrdinal("RESTABLECER")),
                //                    tokenDateExpiration = reader.IsDBNull(reader.GetOrdinal("FECHA_EXPIRACION_TOKEN")) ? null : reader.GetDateTime(reader.GetOrdinal("FECHA_EXPIRACION_TOKEN")),

                //                };
                //            }
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por token", ex);
            }

            return usuario ?? throw new Exception("No se encontró ningún usuario con el token especificado.");
        }

        [HttpGet]
        private UserVM ObtenerUsuarioPorCorreo(string correo)
        {
            if (string.IsNullOrEmpty(correo))
                throw new ArgumentException("El correo no puede estar vacío.");

            UserVM usuario = null!;

            //using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
            //{
            //    con.Open();
            //    using (FbCommand cmd = new FbCommand("PROC_GET_USUARIO_CORREO", con))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add("CORREO", FbDbType.VarChar).Value = correo;

            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                usuario = new UserVM
            //                {
            //                    Id = reader.IsDBNull(reader.GetOrdinal("COD_USUARIO")) ? 0 : reader.GetInt32(reader.GetOrdinal("COD_USUARIO")),
            //                    Valid = reader.IsDBNull(reader.GetOrdinal("Valid")) ? 0 : reader.GetInt32(reader.GetOrdinal("Valid")),
            //                    message = reader.IsDBNull(reader.GetOrdinal("message")) ? string.Empty : reader.GetString(reader.GetOrdinal("message")),
            //                    CompleteName = reader.IsDBNull(reader.GetOrdinal("NOMBRE")) ? string.Empty : reader.GetString(reader.GetOrdinal("NOMBRE")),
            //                    Password = reader.IsDBNull(reader.GetOrdinal("CLAVE")) ? string.Empty : reader.GetString(reader.GetOrdinal("CLAVE")),
            //                    Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? string.Empty : reader.GetString(reader.GetOrdinal("EMAIL")),
            //                    Admin = reader.IsDBNull(reader.GetOrdinal("ES_ADMIN")) ? 0 : reader.GetInt32(reader.GetOrdinal("ES_ADMIN")),
            //                    dateChangePassword = reader.IsDBNull(reader.GetOrdinal("FECHA_CAMBIO_CLAVE")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FECHA_CAMBIO_CLAVE")),
            //                    restore = reader.IsDBNull(reader.GetOrdinal("RESTABLECER")) ? 0 : reader.GetInt32(reader.GetOrdinal("RESTABLECER")),
            //                    Confirm = reader.IsDBNull(reader.GetOrdinal("CONFIRMADO")) ? 0 : reader.GetInt32(reader.GetOrdinal("CONFIRMADO")),
            //                    Token = reader.IsDBNull(reader.GetOrdinal("TOKEN")) ? string.Empty : reader.GetString(reader.GetOrdinal("TOKEN"))
            //                };
            //            }
            //        }
            //    }
            //}

            return usuario;
        }

        [HttpPost]
        public bool RestablecerCuenta(int restablecer, string token, string clave)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(clave))
                throw new ArgumentException("El token y la clave no pueden estar vacíos.");

            bool respuesta = false;

            try
            {
                //using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
                //{
                //    con.Open();
                //    using (FbCommand cmd = new FbCommand("PROC_UPD_TOKEN_USUARIO", con))
                //    {
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.Add("TOKEN", FbDbType.VarChar).Value = token;
                //        cmd.Parameters.Add("RESTABLECER", FbDbType.Integer).Value = restablecer;
                //        cmd.Parameters.Add("CLAVE", FbDbType.VarChar).Value = clave;
                //        cmd.Parameters.Add("FILTRO", FbDbType.VarChar).Value = "RESTABLECER";

                //        cmd.ExecuteNonQuery();
                //        respuesta = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw new Exception("Error al restablecer la cuenta", ex);
            }

            return respuesta;
        }

        //[HttpPost]
        //public async Task<IActionResult> EnvioCorreoRestablecerCuenta(string correo)
        //{
        //    var usuario = new UserVM();

        //    if (string.IsNullOrEmpty(correo))
        //        return Json(new { respuesta = false, message = "El correo no puede estar vacío.", icono = "error" });

        //    usuario = ObtenerUsuarioPorCorreo(correo);
        //    if (usuario == null)
        //    {
        //        return Json(new { respuesta = false, message = "Correo no encontrado.", icono = "error" });
        //    }
        //    var token = GenerarToken(50);
        //    //var restablcer = SetRestablecerCuenta(token!, usuario.Id);
        //    //var formato = GetFormatosCorreos(2);

        //    //if (formato == null)
        //    //{
        //    //    return StatusCode(500, new { message = "No se encontró el formato del correo.", icono = "error" });
        //    //}

        //    //// Construir la URL de restablecimiento
        //    //string url = Url.Action("Actualizar", "Account", new { token = token }, Request.Scheme)!;

        //    //string htmlBody = string.Format(formato.message!, usuario.nombreCompleto, url);

        //    try
        //    {
        //        //await _Service.SendEmailAsync(usuario.correo!, null!, "formato.title!", "htmlBody", null!, null!);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { message = "Error al enviar el correo:" + ex.Message, icono = "error" });
        //    }

        //    return Json(new { respuesta = true, message = usuario.message, icono = "success" });
        //}

        [HttpPost]
        public IActionResult RestablecerContraseña(string token, string clave, string confirmarClave)
        {
            var usuario = new UserVM();
            var icono = "";
            var message = "";
            if (clave != confirmarClave)
            {
                return Json(new { icono = "error", message = "Las contraseñas no coinciden." });
            }

            try
            {
                // Obtener usuario por token
                usuario = GetUsuarioPorToken(token);

                // Validar si el token es válido o ha expirado
                if (usuario == null || usuario.restaurada == 0 || usuario.tokenDateExpiration > DateTime.UtcNow)
                {
                    return Json(new { icono = "error", message = "El token no es válido o ha expirado." });
                }

                // Actualiza la contraseña
                usuario.Password = _utilities.Encriptar(clave);
                usuario.restaurada = 0;
                usuario.Token = null;

                var alerta = RestablecerCuenta(0, token, usuario.Password);
                if (!alerta)
                {
                    icono = "error";
                    message = "Error al realizar la actualización, intente mas tarde";
                }
                else
                {
                    icono = "success";
                    message = "Contraseña actualizada con exito";
                }

                return Json(new { icono, message });
            }
            catch (Exception ex)
            {
                return Json(new { icono = "error", message = $"Error al restablecer contraseña: {ex.Message}" });
            }
        }

        [HttpPost]
        public LoginVM SetRegistrarUsuario(string usuario, string nombre, string clave, string correo, string cargo, int administrador, string token)
        {
            var result = new LoginVM();
            try
            {
                //using (FbConnection con = new FbConnection(dbContext.Database.GetConnectionString()))
                //{
                //    con.Open();
                //    using (var transaction = con.BeginTransaction())
                //    {
                //        FbCommand cmd = new FbCommand
                //        {
                //            Connection = con,
                //            Transaction = transaction,
                //            CommandText = "SELECT Valid, message FROM PROC_SET_USUARIO(@USUARIO,@NOMBRE,@CLAVE,@CORREO,@CARGO,@ADMINISTRADOR,@TOKEN)"
                //        };

                //        cmd.Parameters.Add("@USUARIO", FbDbType.Integer).Value = usuario;
                //        cmd.Parameters.Add("@NOMBRE", FbDbType.Integer).Value = nombre;
                //        cmd.Parameters.Add("@CLAVE", FbDbType.Integer).Value = clave;
                //        cmd.Parameters.Add("@CORREO", FbDbType.Integer).Value = correo;
                //        cmd.Parameters.Add("@CARGO", FbDbType.Integer).Value = cargo;
                //        cmd.Parameters.Add("@ADMINISTRADOR", FbDbType.Integer).Value = administrador;
                //        cmd.Parameters.Add("@TOKEN", FbDbType.Integer).Value = token;

                //        using (var reader = cmd.ExecuteReader())
                //        {
                //            if (reader.Read())
                //            {
                //                result.valid = reader.IsDBNull(reader.GetOrdinal("Valido")) ? 0 : reader.GetInt32(reader.GetOrdinal("Valido"));
                //                result.message = reader.IsDBNull(reader.GetOrdinal("message")) ? null : reader.GetString(reader.GetOrdinal("message"));
                //            }
                //        }
                //        transaction.Commit();
                //    }
                //}
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Se presento un error; {ex.Message}", "setRegitrarUsuario", "PROC_GET_LOGIN");
                result.valid = 0;
                result.message = "Error interno del servidor: " + ex.Message;
            }
            _utilities.RegistrarLog($"Se ejecuto correctamente", "setRegitrarUsuario", "PROC_GET_LOGIN");
            return result;
        }

        [HttpGet]
        private async Task<bool> AutenticarUsuario(string usuario, string clave)
        {
            var clavehashed = _utilities.Encriptar(clave);
            var result = ValidaUsuario(usuario, clavehashed);

            if (!result!.success)
                result = ValidaUsuario(usuario, clave);

            if (!result!.success)
            {
                return false;
            }

            // var menu = GetMenuSistema(result.IdUsuario);

            // if (menu == null)
            //  {
            //      return false;
            //  }

            //   string menuJson = JsonSerializer.Serialize(menu, new JsonSerializerOptions
            //   {
            //       ReferenceHandler = ReferenceHandler.IgnoreCycles,
            //       WriteIndented = true
            //   });

            if (result.userName == null)
            {
                return false;
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, result.userName!),
                new(ClaimTypes.Sid, result.idUsuario.ToString()),
               // new("Menu", menuJson),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties
            {
                AllowRefresh = true,
                IsPersistent = true
            });

            _utilities.RegistrarLog("Se ejecuto Correctamente", "AutenticarUsuario", "PROC_GET_LOGIN");

            if (User.Identity!.IsAuthenticated)
            {
                return true;
            }

            return false;
        }

        [HttpGet]
        public IActionResult LoginExterno(string proveedor, string urlRetorno = null!)
        {
            if (string.IsNullOrEmpty(proveedor))
            {
                return RedirectToAction("Login", new { message = "Proveedor no válido." });
            }

            var urlRedireccion = Url.Action("RegistrarUsuarioExterno", values: new { urlRetorno });
            var propiedades = new AuthenticationProperties
            {
                RedirectUri = urlRedireccion
            };
            _utilities.RegistrarLog("Se ejecuto Correctamente", "LoginExterno", "");
            return new ChallengeResult(proveedor, propiedades);
        }

        [HttpGet]
        public IActionResult RegistrarUsuarioExterno(string urlRetorno = null!, string remoteError = null!)
        {
            urlRetorno ??= Url.Content("~/");

            if (remoteError != null)
            {
                return RedirectToAction("Login", new { message = $"Error con el proveedor: {remoteError}" });
            }

            var usuario = User;

            if (usuario == null || !usuario.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Login", new { message = "No se pudo autenticar con el proveedor externo." });
            }

            var correo = usuario.FindFirstValue(ClaimTypes.Email);
            var nombre = usuario.FindFirstValue(ClaimTypes.Name);
            var userName = correo?.Split('@')[0] ?? "externo";
            var clave = Guid.NewGuid().ToString();

            _utilities.RegistrarLog($"{correo} - {nombre}", "RegistroUsuarioExterno", "LOGIN_EXTERNO");

            if (string.IsNullOrEmpty(correo))
            {
                return RedirectToAction("Login", new { message = "No se recibió un correo válido del proveedor." });
            }

            var usuarioExistente = ObtenerUsuarioPorCorreo(correo);

            if (usuarioExistente.correo == null)
            {
                var registro = SetRegistrarUsuario(nombre ?? "Usuario Externo", userName, clave, correo, null!, 0, "_utilities.GenerarToken(50)!");
                if (registro.valid == 0)
                {
                    return RedirectToAction("Login", new { message = "No se pudo registrar al usuario externo: " + registro.message });
                }

                var resultadoLogin = Login(correo, clave);
                return RedirectToAction("Inicio", "App");
            }
            else
            {
                var resultadoLogin = Login(usuarioExistente.correo, usuarioExistente.Password!);
                return RedirectToAction("Inicio", "App");
            }
        }


    }

}

