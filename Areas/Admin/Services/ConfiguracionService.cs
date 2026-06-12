using AppServiceAndTravel.Areas.Admin.Models;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.Services;
using AppServiceAndTravel.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using static AppServiceAndTravel.Areas.Admin.Services.ConfiguracionService;
namespace AppServiceAndTravel.Areas.Admin.Services
{
    public interface IConfiguracionService
    {
        Task<ConfiguracionGeneral> ObtenerConfiguracion();
        Task<ConfigNotificaciones> ObtenerNotificacion();
        List<RolesVM> ObtenerRoles();
        Task<PermisoRolVM> ObtenerPermisosRol(int idRol);
        Task<(bool success, string message)> GuardarPermisos(GuardarPermisosVM model);
        Task<(bool success, string message)> GuardarEmpresa(EmpresaVM model, int userId);
        Task<(bool success, string message)> GuardarApariencia(AparienciaVM model, int userId);
        Task<(bool success, string message)> GuardarRegional(RegionalVM model, int userId);
        Task<(bool success, string message)> GuardarSMTP(SMTPVM model, int userId);
        Task<(bool success, string message)> GuardarWahtsapp(WhatsappVM model, int userId);
        (bool success, string message) GuardarBD(BDVM model, int userId);
        (bool success, string message) GuardarJWT(JWTVM model, int userId);

    }

    public class ConfiguracionService : IConfiguracionService
    {
        private readonly ApplicationDBContext _context;
        private static ConfiguracionGeneral? _cache;
        private readonly UtilitiesServices _utilities;

        public ConfiguracionService(ApplicationDBContext context, UtilitiesServices utilities)
        {
            _context = context;
            _utilities = utilities;
        }

        public async Task<ConfiguracionGeneral> ObtenerConfiguracion()
        {
            //if (_cache != null) return _cache;
            _cache = await _context.ConfiguracionGeneral.FirstOrDefaultAsync()
                     ?? new ConfiguracionGeneral { idConfiguracionGeneral = 1 };
            return _cache;
        }
        public async Task<ConfigNotificaciones> ObtenerNotificacion()
        {
            var result = await _context.ConfiguracionNotificaciones.FirstOrDefaultAsync()
                ?? new ConfigNotificaciones { idConfigNotificacion = 1 };

            return result!;
        }

        public async Task<(bool success, string message)> GuardarEmpresa(EmpresaVM model, int userId)
        {
            try
            {

                var result = await _context.ConfiguracionGeneral.FirstOrDefaultAsync(c => c.idConfiguracionGeneral == 1);

                if (result is null)
                    return (false, "No se logro guardar la configuracion");

                result.NombreEmpresa = model.NombreEmpresa!;
                result.NitEmpresa = model.NitEmpresa!;
                result.Eslogan = model.Eslogan!;
                result.Direccion = model.Direccion!;
                result.Ciudad = model.Ciudad!;
                result.Departamento = model.Departamento!;
                result.Pais = model.Pais!;
                result.Telefono = model.Telefono!;
                result.Telefono2 = model.Telefono2!;
                result.correo = model.correo!;
                result.SitioWeb = model.SitioWeb!;
                result.RutaLogo = model.RutaLogo!;
                result.RutaFavicon = model.RutaFavicon!;
                result.UltimaModificacion = DateTime.UtcNow;
                result.ModificadoPorId = userId;

                await _context.SaveChangesAsync();
                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public async Task<(bool success, string message)> GuardarApariencia(AparienciaVM model, int userId)
        {
            try
            {

                var result = await _context.ConfiguracionGeneral.FirstOrDefaultAsync(c => c.idConfiguracionGeneral == 1);

                if (result is null)
                    return (false, "No se logro guardar la configuracion");

                result.ColorPrimario = model.ColorPrimario!;
                result.ColorSecundario = model.ColorSecundario!;
                result.ColorAcento = model.ColorAcento!;
                result.ColorTexto = model.ColorTexto!;
                result.ColorFondo = model.ColorFondo!;
                result.ColorPeligro = model.ColorPeligro!;
                result.ColorAdvertencia = model.ColorAdvertencia!;
                result.TemaSeleccionado = model.TemaSeleccionado!;
                result.FuenteSistema = model.FuenteSistema!;
                result.TamanoFuenteBase = model.TamanoFuenteBase!;
                result.UltimaModificacion = DateTime.UtcNow;
                result.ModificadoPorId = userId;

                await _context.SaveChangesAsync();
                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public async Task<(bool success, string message)> GuardarRegional(RegionalVM model, int userId)
        {
            try
            {

                var result = await _context.ConfiguracionGeneral.FirstOrDefaultAsync(c => c.idConfiguracionGeneral == 1);

                if (result is null)
                    return (false, "No se logro guardar la configuracion");

                result.Moneda = model.Moneda!;
                result.SimboloMoneda = model.SimboloMoneda!;
                result.Idioma = model.Idioma!;
                result.ZonaHoraria = model.ZonaHoraria!;
                result.FormatoFecha = model.FormatoFecha!;
                result.SeparadorDecimal = model.SeparadorDecimal!;
                result.SeparadorMiles = model.SeparadorMiles!;
                result.UltimaModificacion = DateTime.UtcNow;
                result.ModificadoPorId = userId;

                await _context.SaveChangesAsync();
                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public async Task<(bool success, string message)> GuardarSMTP(SMTPVM model, int userId)
        {
            try
            {

                var result = await _context.ConfiguracionNotificaciones.FirstOrDefaultAsync(c => c.idConfigNotificacion == 1);

                if (result is null)
                    return (false, "No se logro guardar la configuracion");

                result.smtpServer = model.smtpServer!;
                result.smtpPort = model.smtpPort!;
                result.requiereSSL = model.requiereSSL!;
                result.requiereTSL = model.requiereTSL!;
                result.smtpUserName = model.smtpUserName!;
                result.smtpPassword = model.smtpPassword!;
                result.correoRemitente = model.correoRemitente!;
                result.NombreRemitente = model.NombreRemitente!;
                result.FechaActualizacion = DateTime.UtcNow;
                result.UltimaModificacion = DateTime.UtcNow;
                result.ModificadoPorId = userId;

                await _context.SaveChangesAsync();
                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public async Task<(bool success, string message)> GuardarWahtsapp(WhatsappVM model, int userId)
        {
            try
            {

                var result = await _context.ConfiguracionNotificaciones.FirstOrDefaultAsync(c => c.idConfigNotificacion == 1);

                if (result is null)
                    return (false, "No se logro guardar la configuracion");

                result.ProveedorWhatsApp = model.ProveedorWhatsApp!;
                result.WhatsAppApiUrl = model.WhatsAppApiUrl!;
                result.WhatsAppApiKey = model.WhatsAppApiKey!;
                result.WhatsAppNumeroEmpresa = model.WhatsAppNumeroEmpresa!;
                result.WhatsAppValidado = model.WhatsAppValidado!;
                result.WhatsAppFechaValidacion = model.WhatsAppFechaValidacion!;
                result.FechaActualizacion = DateTime.UtcNow;
                result.UltimaModificacion = DateTime.UtcNow;
                result.ModificadoPorId = userId;

                await _context.SaveChangesAsync();
                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public (bool success, string message) GuardarBD(BDVM model, int userId)
        {
            try
            {
                var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
                var json = File.ReadAllText(appSettingsPath);

                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.Converters.Add(new ExpandoObjectConverter());
                jsonSettings.Converters.Add(new StringEnumConverter());

                dynamic config = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSettings)!;

                if (config is null)
                    return (false, "No se logro guardar la configuracion");

                config.ConnectionStrings.DatabaseProvider = model.Proveedor;
                config.ConnectionStrings.DefaultConnection = model.Cadena;

                var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);

                File.WriteAllText(appSettingsPath, newJson);

                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public (bool success, string message) GuardarJWT(JWTVM model, int userId)
        {
            try
            {
                var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
                var json = File.ReadAllText(appSettingsPath);

                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.Converters.Add(new ExpandoObjectConverter());
                jsonSettings.Converters.Add(new StringEnumConverter());

                dynamic config = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSettings)!;

                if (config is null)
                    return (false, "No se logro guardar la configuracion");

                config.JwtSettings.SecretKey = model.JwtSecretKey;
                config.JwtSettings.Issuer = model.JwtIssuer;
                config.JwtSettings.Audience = model.JwtAudience;
                config.JwtSettings.ExpirationMinutes = model.JwtExpirationMinutes;

                var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);

                File.WriteAllText(appSettingsPath, newJson);

                return (true, "Se agregaron correctamente los datos");

            }
            catch (Exception ex)
            {
                return (false, $"No ha presentado un error {ex.Message}");
            }
        }
        public List<RolesVM> ObtenerRoles()
        {
            var rolesVM = _context.Roles
                .OrderBy(r => r.nombre)
                .Select(r => new RolesVM
                {
                    id = r.idRol,
                    descripcion = r.nombre
                })
                .ToList();

            return rolesVM;
        }
        public async Task<PermisoRolVM> ObtenerPermisosRol(int idRol)
        {
            var rol = await _context.Roles
                .Include(r => r.Permisos)
                .FirstOrDefaultAsync(r => r.idRol == idRol);

            if (rol == null)
                throw new Exception("Rol no encontrado");

            var procesos = await _context.Procesos
                .Where(x => !string.IsNullOrWhiteSpace(x.area))
                .OrderBy(x => x.area)
                .ThenBy(x => x.proceso)
                .ToListAsync();

            var permisos = rol.Permisos.ToList();

            var areas = procesos
                .GroupBy(x => x.area)
                .Select(g =>
                {
                    var procesosArea = g.ToList();

                    return new AreaPermisoVM
                    {
                        area = g.Key,
                        expandido = true,

                        procesos = procesosArea
                            .Select(x =>
                            {
                                var permiso = permisos
                                    .FirstOrDefault(p => p.idProceso == x.idProceso);

                                return new ProcesoPermisoVM
                                {
                                    idProceso = x.idProceso,
                                    idProcesoPadre = x.idProcesoPadre,
                                    proceso = x.proceso,
                                    icono = x.icono,
                                    controlador = x.controlador,
                                    url = x.url,

                                    lectura = permiso?.lectura ?? false,
                                    crea = permiso?.crea ?? false,
                                    edita = permiso?.edita ?? false,
                                    elimina = permiso?.elimina ?? false,

                                    deny = permiso?.deny ?? false,
                                    hereda = permiso?.hereda ?? true,
                                    apiAccess = permiso?.apiAccess ?? false,
                                    claims = permiso?.claims,

                                    hijos = new List<ProcesoPermisoVM>()
                                };
                            })
                            .ToList()
                    };
                })
                .ToList();

            return new PermisoRolVM
            {
                idRol = rol.idRol,
                nombreRol = rol.nombre,
                areas = areas
            };
        }
        private List<ProcesoPermisoVM> BuildTree(List<Procesos> procesos, List<Permisos> permisos, int? padre, int nivel)
        {
            return procesos
                .Where(x => x.idProcesoPadre == padre)
                .Select(x =>
                {
                    var permiso = permisos
                        .FirstOrDefault(p => p.idProceso == x.idProceso);

                    return new ProcesoPermisoVM
                    {
                        idProceso = x.idProceso,
                        idProcesoPadre = x.idProcesoPadre,
                        proceso = x.proceso,
                        icono = x.icono,
                        controlador = x.controlador,
                        url = x.url,
                        nivel = nivel,

                        lectura = permiso?.lectura ?? false,
                        crea = permiso?.crea ?? false,
                        edita = permiso?.edita ?? false,
                        elimina = permiso?.elimina ?? false,

                        deny = permiso?.deny ?? false,
                        hereda = permiso?.hereda ?? true,
                        apiAccess = permiso?.apiAccess ?? false,
                        claims = permiso?.claims,

                        hijos = BuildTree(
                            procesos,
                            permisos,
                            x.idProceso,
                            nivel + 1
                        )
                    };
                })
                .ToList();
        }
        public void GuardarLogBD(EstadoLogSistema nivel,EventosSistemas evento,string mensaje,string detalle)
        {
            var log = new LogSistema
            {
                Nivel = nivel,
                Evento = evento,
                Mensaje = mensaje,
                Detalle = detalle,
                idUsuario = 1,
                Fecha = DateTime.UtcNow
            };

            _context.LogsSistema.Add(log);
        }
        public async Task<(bool success, string message)> GuardarPermisos(GuardarPermisosVM model)
        {
            try
            {
                if (model == null)
                    return (false, "No se logró guardar la configuración");

                foreach (var item in model.permisos)
                {
                    var permiso = await _context.Permisos
                        .FirstOrDefaultAsync(x =>
                            x.idRol == model.idRol &&
                            x.idProceso == item.idProceso);

                    if (permiso == null)
                    {
                        permiso = new Permisos
                        {
                            idRol = model.idRol,
                            idProceso = item.idProceso
                        };

                        _context.Permisos.Add(permiso);
                    }

                    permiso.lectura = item.lectura;
                    permiso.crea = item.crea;
                    permiso.edita = item.edita;
                    permiso.elimina = item.elimina;

                    permiso.deny = item.deny;
                    permiso.hereda = item.hereda;
                    permiso.apiAccess = item.apiAccess;

                    permiso.fechaModificacion = DateTime.UtcNow;
                }
                _utilities.RegistrarLog($"Se guardó correctamente los procesos", "GuardarPermisos");
                GuardarLogBD(EstadoLogSistema.INFO, EventosSistemas.CREA, $"Procesos actualizados", null!);
                await _context.SaveChangesAsync();

                return (true, "Se guardaron los permisos con éxito");
            }
            catch (Exception ex)
            {
                _utilities.RegistrarLog(ex.Message,"GuardarPermisos","ERROR");
                return (false, ex.Message);
            }
        }

    }
}
