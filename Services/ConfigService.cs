using AppServiceAndTravel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AppServiceAndTravel.Data;
using Microsoft.Extensions.Options;

namespace AppServiceAndTravel.Services
{    
    public interface IConfiguracionService
    {
        Task<ConfiguracionGeneral> ObtenerAsync();
        Task GuardarAsync(ConfiguracionGeneral config, string userId);
    }

    public class ConfiguracionService : IConfiguracionService
    {
        private readonly ApplicationDBContext _context;
        private static ConfiguracionGeneral? _cache;

        public ConfiguracionService(ApplicationDBContext context) => _context = context;

        public async Task<ConfiguracionGeneral> ObtenerAsync()
        {
            if (_cache != null) return _cache;
            _cache = await _context.ConfiguracionGeneral.FirstOrDefaultAsync()
                     ?? new ConfiguracionGeneral { idConfiguracionGeneral = 1 };
            return _cache;
        }

        public async Task GuardarAsync(ConfiguracionGeneral config, string userId)
        {
            config.UltimaModificacion = DateTime.Now;
            config.ModificadoPorId = userId;

            var existente = await _context.ConfiguracionGeneral.FirstOrDefaultAsync();
            if (existente == null)
                _context.ConfiguracionGeneral.Add(config);
            else
            {
                config.idConfiguracionGeneral = existente.idConfiguracionGeneral;
                _context.Entry(existente).CurrentValues.SetValues(config);
            }

            await _context.SaveChangesAsync();
            _cache = config; // actualizar caché
        }
    }
}
