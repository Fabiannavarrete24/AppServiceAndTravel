using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace AppServiceAndTravel.Services
{
    public interface IAuditoriaService
    {
        Task RegistrarActividadAsync(int tipo,string descripcion,string? entidad = null,int? entidadId = null,string? estadoAnterior = null,string? estadoNuevo = null);

        Task RegistrarLogAsync(EstadoLogSistema nivel,string evento,string mensaje,string? detalle = null);
    }
    public class AuditoriaService : IAuditoriaService
    {
        private readonly ApplicationDBContext _context;
        private readonly IHttpContextAccessor _http;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuditoriaService(ApplicationDBContext context,IHttpContextAccessor http,UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _http = http;
            _userManager = userManager;
        }

        public async Task RegistrarActividadAsync(int tipo,string descripcion,string? entidad = null,int? entidadId = null,string? estadoAnterior = null,string? estadoNuevo = null)
        {
            var user = _http.HttpContext?.User;

            var actividad = new ActividadSistema
            {
                idActividadSistema = tipo,
                Descripcion = descripcion,
                Entidad = entidad,
                EntidadId = entidadId,
                EstadoAnterior = estadoAnterior,
                EstadoNuevo = estadoNuevo,
                idUsuario = Convert.ToInt32(user?.FindFirstValue(ClaimTypes.NameIdentifier)),
                UsuarioNombre = user?.Identity?.Name,
                IpAddress = _http.HttpContext?.Connection.RemoteIpAddress?.ToString()
            };

            _context.ActividadesSistema.Add(actividad);

            await _context.SaveChangesAsync();
        }

        public async Task RegistrarLogAsync(EstadoLogSistema nivel,string evento,string mensaje,string? detalle = null)
        {
            var user = _http.HttpContext?.User;

            var log = new LogSistema
            {
                Nivel = nivel,
                Evento = evento,
                Mensaje = mensaje,
                Detalle = detalle,
                idUsuario = Convert.ToInt32(user?.FindFirstValue(ClaimTypes.NameIdentifier)),
                UsuarioNombre = user?.Identity?.Name,
                Url = _http.HttpContext?.Request.Path,
                MetodoHttp = _http.HttpContext?.Request.Method,
                IpAddress = _http.HttpContext?.Connection.RemoteIpAddress?.ToString(),
                UserAgent = _http.HttpContext?.Request.Headers["User-Agent"]
            };

            _context.LogsSistema.Add(log);

            await _context.SaveChangesAsync();
        }
    }
}