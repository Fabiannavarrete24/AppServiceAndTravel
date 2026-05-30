using AppServiceAndTravel.Areas.Admin.Models;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Helpers.Filters;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using AppServiceAndTravel.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;

namespace AppServiceAndTravel.Areas.Admin.Services
{
    public interface IUsersService 
    {
        Task<ApiResponse<List<UserVM>>> ObtenerUsuarios(UsuariosFilterVM filter);
        (bool success, string message, UserVM data) ObtenerUsuario(int idUsuario);
        (bool success, string message, UserVM data) ObtenerUsuarioPorCorreo(string correo);
       (bool success, string message, UserVM data) UsuarioPorToken(string token);
        (bool success, string message) ActualizarUsuario(UserVM model);
        (bool success, string message, LoginVM data) GuardarUsuario(UserVM model);
        Task<ApiResponse<UsuariosDashboardVM>> ObtenerDashboardUsuarios();
    }
    public class UsersService : IUsersService
    {
        private readonly ApplicationDBContext _context;
        private readonly UtilitiesServices _utilities;
        private readonly IAuditoriaService _auditoriaService;

        public UsersService(ApplicationDBContext context, UtilitiesServices utilities, IAuditoriaService auditoriaService)
        {
            _context = context;
            _utilities = utilities;
            _auditoriaService = auditoriaService;
        }
        public async Task<ApiResponse<List<UserVM>>> ObtenerUsuarios(UsuariosFilterVM filter)
        {
            try
            {
                var query = _context.Usuarios.Include(x => x.RolesUsuarios!).ThenInclude(r => r.Rol).AsQueryable();

                if (!string.IsNullOrWhiteSpace(filter.Search))
                {
                    query = query.Where(x =>
                        x.userName!.Contains(filter.Search) ||
                        x.nombreCompleto!.Contains(filter.Search) ||
                        x.correo!.Contains(filter.Search));
                }

                if (filter.Admin.HasValue)
                {
                    query = query.Where(x => x.admin == filter.Admin.Value);
                }

                if (filter.IdRol.HasValue)
                {
                    query = query.Where(x =>
                        x.RolesUsuarios!.Any(r => r.idRol == filter.IdRol.Value));
                }

                var total = await query.CountAsync();

                var usuarios = await query
                    .OrderBy(x => x.nombreCompleto)
                    .Paginate(filter.Page, filter.PageSize)
                    .Select(user => new UserVM
                    {
                        idUsuario = user.idUsuario,
                        Username = user.userName,
                        nombreCompleto = user.nombreCompleto,
                        correo = user.correo,
                        restaurada = user.restaurada,
                        confirmada = user.confirmada,
                        tokenDateExpiration = user.fechaExpiracionToken,
                        token = user.token,
                        fechaBaja = user.fechaBaja,
                        dateChangePassword = user.fechaCambioClave,
                        fechaUltimoAcceso = user.ultimoAcceso,
                        admin = user.admin,
                        activo = user.activo,
                        idRol = user.RolesUsuarios!
                            .Select(r => r.idRol)
                            .FirstOrDefault(),
                        rol = user.RolesUsuarios!
                            .Select(r => r.Rol!.nombre)
                            .FirstOrDefault()
                    })
                    .ToListAsync();

                return new ApiResponse<List<UserVM>>
                {
                    Success = true,
                    Message = "Datos encontrados con éxito",
                    Data = usuarios,
                    Pagination = new PaginationVM
                    {
                        Page = filter.Page,
                        PageSize = filter.PageSize,
                        Total = total
                    }
                };
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error: {ex.Message}","ObtenerUsuarios","ERROR");

                return new ApiResponse<List<UserVM>>{Success = false,Message = ex.Message,Data = []};
            }
        }
        public (bool success, string message,UserVM data) ObtenerUsuario(int idUsuario)
        {
            
            try
            {
                var user = _context.Usuarios.FirstOrDefault(u => u.idUsuario == idUsuario);
                var rol = _context.RolesUsuarios.FirstOrDefault(r => r.idUsuario == idUsuario);
                var result = new UserVM
                {
                    idUsuario = user!.idUsuario,
                    Username = user.userName,
                    nombreCompleto = user.nombreCompleto,
                    correo = user.correo,
                    restaurada = user.restaurada,
                    confirmada = user.confirmada,
                    tokenDateExpiration = user.fechaExpiracionToken,
                    token = user.token,
                    idRol = rol!.idRol,                    
                    fechaBaja = user.fechaBaja,
                    dateChangePassword = user.fechaCambioClave,                    
                    admin = user.admin,

                };
                _utilities.RegistrarLog($"Datos encontrados con exito", "ObtenerUsuario", "INFO");
                return (true, "Datos encontrados con exito", result);
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Se presento un error; {ex.Message}", "ObtenerUsuario");
                return (true, $"se ha presentado un problema {ex.Message}",null!);
            }            
        }
        public (bool success, string message, UserVM data) UsuarioPorToken(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("El token no puede estar vacío.");
            UserVM usuario = null!;
            try
            {

                var user = _context.Usuarios.FirstOrDefault(u => u.token == token);
                var rol = _context.RolesUsuarios.FirstOrDefault(r => r.idUsuario == user!.idUsuario);
                if (user!.fechaExpiracionToken <= DateTime.UtcNow)
                {
                    throw new Exception("El token ya fue utilizado o ya expiro.");
                }

                if (user != null)
                {
                    usuario = new UserVM
                    {
                        idUsuario = user!.idUsuario,
                        Username = user.userName,
                        nombreCompleto = user.nombreCompleto,
                        correo = user.correo,
                        restaurada = user.restaurada,
                        confirmada = user.confirmada,
                        tokenDateExpiration = user.fechaExpiracionToken,
                        token = user.token,
                        idRol = rol!.idRol,
                        fechaBaja = user.fechaBaja,
                        dateChangePassword = user.fechaCambioClave,
                        admin = user.admin,
                    };
                }
                if (usuario is null)
                {
                    _utilities.RegistrarLog("No se encontró ningún usuario.", "UsuarioPorToken");
                    return (false, "No se encontró ningún usuario.", null!);
                } 
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error al obtener el usuario por token: {ex.Message}", "UsuarioPorToken","ERROR");
                return (false,$"Error al obtener el usuario por token: {ex.Message}",null!);
            }
            _utilities.RegistrarLog($"Datos encontrados con exito", "UsuarioPorToken");
            return (true, $"Datos encontrados con exito", usuario);
        }
        public (bool success, string message, UserVM data) ObtenerUsuarioPorCorreo(string correo)
        {
            if (string.IsNullOrEmpty(correo))
                throw new ArgumentException("El correo esta en blanco.");
            UserVM usuario = null!;
            try
            {

                var user = _context.Usuarios.FirstOrDefault(u => u.correo == correo);
                var rol = _context.RolesUsuarios.FirstOrDefault(r => r.idUsuario == user!.idUsuario);
                if (user != null)
                {
                    usuario = new UserVM
                    {
                        idUsuario = user!.idUsuario,
                        Username = user.userName,
                        nombreCompleto = user.nombreCompleto,
                        correo = user.correo,
                        restaurada = user.restaurada,
                        confirmada = user.confirmada,
                        tokenDateExpiration = user.fechaExpiracionToken,
                        token = user.token,
                        idRol = rol!.idRol,
                        fechaBaja = user.fechaBaja,
                        dateChangePassword = user.fechaCambioClave,
                        admin = user.admin,
                    };
                }
                else
                {
                    _utilities.RegistrarLog("No se encontró ningún usuario con el correo especificado.", "UsuarioPorToken");
                    return (false, "No se encontró ningún usuario con el correo especificado.", null!);
                }
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error al obtener el usuario por correo: {ex.Message}", "ObtenerUsuarioPorCorreo", "ERROR");
                return (false, $"Error al obtener el usuario: {ex.Message}", null!);
            }

            return (true, $"Datos encontrados con exito", usuario);
        }        
        public (bool success, string message) ActualizarUsuario(UserVM model)
        {
            try
            {
                var user = _context.Usuarios.Include(x => x.RolesUsuarios).FirstOrDefault(x => x.idUsuario == model.idUsuario);
                var rolActual = user!.RolesUsuarios!.FirstOrDefault();
                
                if (user == null)
                    return (false, "No se encontró el usuario");

                var cambios = new List<string>();
                bool existeUsuario = _context.Usuarios.Any(x => x.userName == model.Username && x.idUsuario != model.idUsuario);

                if (existeUsuario)
                    return (false, "El nombre de usuario ya existe");

                if (user.userName != model.Username)
                {
                    cambios.Add($"Usuario: {user.userName} → {model.Username}");
                    user.userName = model.Username;
                }

                if (user.nombreCompleto != model.nombreCompleto)
                {
                    cambios.Add($"Nombre: {user.nombreCompleto} → {model.nombreCompleto}");
                    user.nombreCompleto = model.nombreCompleto;
                }

                if (user.correo != model.correo)
                {
                    cambios.Add($"Correo: {user.correo} → {model.correo}");
                    user.correo = model.correo;
                }
                
                if (user.telefono != model.telefono)
                {
                    cambios.Add($"Telefono: {user.telefono} → {model.telefono}");
                    user.telefono = model.telefono;
                }

                if (user.cargo != model.cargo)
                {
                    cambios.Add($"Cargo: {user.cargo} → {model.cargo}");
                    user.cargo = model.cargo;
                }

                if (user.admin != model.admin)
                {
                    cambios.Add($"Administrador: {user.admin} → {model.admin}");
                    user.admin = model.admin;
                }

                if (user.activo != model.activo)
                {
                    cambios.Add($"Fecha baja modificada");
                    user.activo = model.activo;
                    user.fechaBaja = model.fechaBaja;
                }

                if (!string.IsNullOrWhiteSpace(model.password))
                {
                    var hasher = new PasswordHasher<string>();
                    var resultado = hasher.VerifyHashedPassword(model.Username!,user.password!,model.password);
                    bool passwordValida = resultado != PasswordVerificationResult.Failed;

                    if (!passwordValida)
                    {
                        user.password = hasher.HashPassword(model.Username!, model.password);
                        user.fechaCambioClave = DateTime.UtcNow.AddMonths(3);
                        cambios.Add("Contraseña actualizada");
                    }
                }

                if (rolActual != null)
                {
                    if (rolActual.idRol != model.idRol)
                    {
                        cambios.Add($"Rol: {rolActual.idRol} → {model.idRol}");
                        rolActual.idRol = model.idRol;
                    }
                }
                else
                {
                    user!.RolesUsuarios!.Add(new RolesUsuarios
                    {
                        idRol = model.idRol
                    });

                    cambios.Add($"Rol asignado: {model.idRol}");
                }

                 _context.SaveChanges();

                if (cambios.Any())
                {
                     _auditoriaService.RegistrarLogAsync(EstadoLogSistema.INFO,EventosSistemas.EDITA,"USUARIOS",string.Join(" | ", cambios),null!,model.Username!);
                }

                _utilities.RegistrarLog($"Usuario actualizado correctamente: {model.Username}","ActualizarUsuario","INFO");

                return (true, "Usuario actualizado correctamente");
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error actualizando usuario: {ex.Message}","ActualizarUsuario","ERROR");

                return (false, $"Error: {ex.Message}");
            }
        }
        public (bool success, string message, LoginVM data) GuardarUsuario(UserVM model)
        {
            try
            {
                bool existe = _context.Usuarios.Any(x => x.userName == model.Username);

                if (existe)
                {
                    return (false, "El usuario ya existe", null!);
                }

                var hasher = new PasswordHasher<string>();

                string passwordHash = hasher.HashPassword(model.Username!, model.password!);

                var request = new ApplicationUser
                {
                    userName = model.Username,
                    nombreCompleto = model.nombreCompleto,
                    password = passwordHash,
                    correo = model.correo,
                    cargo = model.cargo,
                    admin = model.admin,
                    confirmada = true,
                    fechaCreacion = DateTime.UtcNow,
                    fechaCambioClave = DateTime.UtcNow.AddMonths(3),
                    RolesUsuarios = new List<RolesUsuarios>
                    {
                        new RolesUsuarios
                        {
                            idRol = model.idRol
                        }
                    }
                };

                _context.Usuarios.AddAsync(request);

                _context.SaveChangesAsync();

                _auditoriaService.RegistrarLogAsync(EstadoLogSistema.INFO,EventosSistemas.CREA,"USUARIOS",$"Usuario creado: {model.Username}",null!,model.Username);

                _utilities.RegistrarLog($"Usuario creado correctamente: {model.Username}","GuardarUsuario","INFO");

                var result = new LoginVM
                {
                    idUsuario = request.idUsuario,
                    userName = request.userName,
                    nombreCompleto = request.nombreCompleto
                };

                return (true, "Usuario registrado correctamente", result);
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error guardando usuario: {ex.Message}","GuardarUsuario","ERROR");

                return (false, $"Error: {ex.Message}", null!);
            }
        }
        public async Task<ApiResponse<UsuariosDashboardVM>> ObtenerDashboardUsuarios()
        {
            try
            {
                var totalUsuarios = await _context.Usuarios.CountAsync();

                var activos = await _context.Usuarios
                    .CountAsync(x => x.activo);

                var inactivos = await _context.Usuarios
                    .CountAsync(x => !x.activo);

                var roles = await _context.Roles.CountAsync();

                var result = new UsuariosDashboardVM
                {
                    TotalUsuarios = totalUsuarios,
                    UsuariosActivos = activos,
                    UsuariosInactivos = inactivos,
                    RolesDefinidos = roles
                };

                return new ApiResponse<UsuariosDashboardVM>
                {
                    Success = true,
                    Message = "Dashboard cargado correctamente",
                    Data = result
                };
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog(
                    ex.Message,
                    "ObtenerDashboardUsuarios",
                    "ERROR");

                return new ApiResponse<UsuariosDashboardVM>
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}
