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
        (bool success, string message, UserVM? data) ObtenerUsuario(int idUsuario);
        (bool success, string message, UserVM data) ObtenerUsuarioPorCorreo(string correo);
        (bool success, string message, UserVM data) UsuarioPorToken(string token);
        Task<(bool success, string message)> ActualizarUsuario(UserVM model);
        Task<(bool success, string message)> ResetPassword(ResetPasswordVM model);
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
                var query = _context.Usuarios
                    .Include(x => x.Rol)
                    .AsQueryable();

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
                    query = query.Where(x => x.idRol == filter.IdRol.Value);
                }

                var total = await query.CountAsync();

                var usuarios = await query
                    .OrderBy(x => x.nombreCompleto)
                    .Skip((filter.Page - 1) * filter.PageSize)
                    .Take(filter.PageSize)
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
                        idRol = user.idRol,
                        rol = user.Rol != null
                            ? user.Rol.nombre
                            : string.Empty
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
                _utilities.RegistrarLog(
                    $"Error: {ex.Message}",
                    "ObtenerUsuarios",
                    "ERROR");

                return new ApiResponse<List<UserVM>>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = []
                };
            }
        }
        public (bool success, string message, UserVM data) ObtenerUsuario(int idUsuario)
        {
            try
            {
                var user = _context.Usuarios.Include(x => x.Rol).FirstOrDefault(x => x.idUsuario == idUsuario);

                if (user == null)
                {
                    _utilities.RegistrarLog($"Usuario {idUsuario} no se encontro", "ObtenerUsuario", "INFO");
                    return (false, "Usuario no encontrado", null!);
                }

                var result = new UserVM
                {
                    idUsuario = user.idUsuario,
                    Username = user.userName,
                    nombreCompleto = user.nombreCompleto,
                    correo = user.correo,
                    restaurada = user.restaurada,
                    confirmada = user.confirmada,
                    tokenDateExpiration = user.fechaExpiracionToken,
                    token = user.token,
                    idRol = user.idRol,
                    fechaBaja = user.fechaBaja,
                    dateChangePassword = user.fechaCambioClave,
                    admin = user.admin,
                    activo = user.activo
                };

                _utilities.RegistrarLog($"Usuario {idUsuario} consultado correctamente", "ObtenerUsuario", "INFO");

                return (true, "Datos encontrados con éxito", result);
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog($"Error: {ex.Message}", "ObtenerUsuario", "ERROR");

                return (false, ex.Message, null!);
            }
        }
        public (bool success, string message, UserVM data) UsuarioPorToken(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("El token no puede estar vacío.");
            UserVM usuario = null!;
            try
            {

                var user = _context.Usuarios.Include(x => x.Rol).FirstOrDefault(u => u.token == token);
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
                        idRol = user.idRol,
                        fechaBaja = user.fechaBaja,
                        dateChangePassword = user.fechaCambioClave,
                        admin = user.admin,
                        activo = user.activo
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
                _utilities.RegistrarLog($"Error al obtener el usuario por token: {ex.Message}", "UsuarioPorToken", "ERROR");
                return (false, $"Error al obtener el usuario por token: {ex.Message}", null!);
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

                var user = _context.Usuarios.Include(x => x.Rol).FirstOrDefault(u => u.token == correo);

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
                        idRol = user.idRol,
                        fechaBaja = user.fechaBaja,
                        dateChangePassword = user.fechaCambioClave,
                        admin = user.admin,
                        activo = user.activo
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
        public async Task<(bool success, string message)> ActualizarUsuario(UserVM model)
        {
            try
            {
                var user = await _context.Usuarios
                    .FirstOrDefaultAsync(x => x.idUsuario == model.idUsuario);

                if (user == null)
                    return (false, "No se encontró el usuario");

                var cambios = new List<string>();

                if (!string.IsNullOrWhiteSpace(model.Username))
                {
                    bool existeUsuario = await _context.Usuarios.AnyAsync(x =>
                        x.userName == model.Username &&
                        x.idUsuario != model.idUsuario);

                    if (existeUsuario)
                        return (false, "El nombre de usuario ya existe");
                }

                if (!string.IsNullOrWhiteSpace(model.Username) &&
                    user.userName != model.Username)
                {
                    cambios.Add($"Usuario: {user.userName} → {model.Username}");
                    user.userName = model.Username;
                }

                if (!string.IsNullOrWhiteSpace(model.nombreCompleto) &&
                    user.nombreCompleto != model.nombreCompleto)
                {
                    cambios.Add($"Nombre: {user.nombreCompleto} → {model.nombreCompleto}");
                    user.nombreCompleto = model.nombreCompleto;
                }

                if (!string.IsNullOrWhiteSpace(model.correo) &&
                    user.correo != model.correo)
                {
                    cambios.Add($"Correo: {user.correo} → {model.correo}");
                    user.correo = model.correo;
                }

                if (!string.IsNullOrWhiteSpace(model.telefono) &&
                    user.telefono != model.telefono)
                {
                    cambios.Add($"Teléfono: {user.telefono} → {model.telefono}");
                    user.telefono = model.telefono;
                }

                if (!string.IsNullOrWhiteSpace(model.cargo) &&
                    user.cargo != model.cargo)
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
                    cambios.Add($"Estado: {(user.activo ? "Activo" : "Inactivo")} → {(model.activo ? "Activo" : "Inactivo")}");

                    user.activo = model.activo;

                    if (!model.activo)
                        user.fechaBaja = DateTime.UtcNow;
                    else
                        user.fechaBaja = null;
                }

                // Actualizar rol
                if (model.idRol > 0 && user.idRol != model.idRol)
                {
                    cambios.Add($"Rol: {user.idRol} → {model.idRol}");
                    user.idRol = model.idRol;
                }

                await _context.SaveChangesAsync();

                if (cambios.Any())
                {
                    await _auditoriaService.RegistrarLogAsync(
                        EstadoLogSistema.INFO,
                        EventosSistemas.EDITA,
                        "USUARIOS",
                        string.Join(" | ", cambios),
                        null!,
                        user.userName!);
                }

                _utilities.RegistrarLog(
                    $"Usuario actualizado correctamente: {user.userName}",
                    "ActualizarUsuario",
                    "INFO");

                return (true, "Usuario actualizado correctamente");
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog(
                    ex.ToString(),
                    "ActualizarUsuario",
                    "ERROR");

                return (false, ex.Message);
            }
        }
        public async Task<(bool success, string message)> ResetPassword(ResetPasswordVM model)
        {
            try
            {
                var user = await _context.Usuarios
                    .FirstOrDefaultAsync(x => x.idUsuario == model.idUsuario);

                if (user == null)
                    return (false, "Usuario no encontrado");

                if (string.IsNullOrWhiteSpace(model.Password))
                    return (false, "Debe ingresar una contraseña");

                var hasher = new PasswordHasher<string>();

                user.password = hasher.HashPassword(
                    user.userName!,
                    model.Password!);

                user.fechaCambioClave = DateTime.UtcNow.AddMonths(3);

                await _context.SaveChangesAsync();

                await _auditoriaService.RegistrarLogAsync(
                    EstadoLogSistema.INFO,
                    EventosSistemas.EDITA,
                    "USUARIOS",
                    "Restablecimiento de contraseña",
                    null!,
                    user.userName!);

                _utilities.RegistrarLog(
                    $"Contraseña restablecida para {user.userName}",
                    "ResetPassword",
                    "INFO");

                return (true, "Contraseña actualizada correctamente");
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog(
                    ex.ToString(),
                    "ResetPassword",
                    "ERROR");

                return (false, ex.Message);
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
                    userName = model.Username!,
                    nombreCompleto = model.nombreCompleto,
                    password = passwordHash,
                    correo = model.correo!,
                    cargo = model.cargo!,
                    admin = model.admin,
                    confirmada = true,
                    fechaCreacion = DateTime.UtcNow,
                    fechaCambioClave = DateTime.UtcNow.AddMonths(3),
                    idRol = model.idRol
                };

                _context.Usuarios.AddAsync(request);

                _context.SaveChangesAsync();

                _auditoriaService.RegistrarLogAsync(EstadoLogSistema.INFO, EventosSistemas.CREA, "USUARIOS", $"Usuario creado: {model.Username}", null!, model.Username!);

                _utilities.RegistrarLog($"Usuario creado correctamente: {model.Username}", "GuardarUsuario", "INFO");

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
                _utilities.RegistrarLog($"Error guardando usuario: {ex.Message}", "GuardarUsuario", "ERROR");

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
