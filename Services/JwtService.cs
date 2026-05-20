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
    // ══════════════════════════════════════════════════════════════
    // JWT SERVICE
    // ══════════════════════════════════════════════════════════════
    //public interface IJwtService
    //{
    //    Task<(string accessToken, string refreshToken)> GenerarTokensAsync(Usuarios user);
    //    ClaimsPrincipal? ValidarToken(string token);
    //    Task<(string accessToken, string refreshToken)?> RefrescarTokenAsync(string refreshToken);
    //}

    //public class JwtService : IJwtService
    //{
    //    private readonly IConfiguration _config;
    //    private readonly UserManager<Usuarios> _userManager;
    //    private readonly ApplicationDBContext _context;
    //    private readonly ILogger<JwtService> _logger;

    //    public JwtService(IConfiguration config, UserManager<Usuarios> userManager,
    //        ApplicationDBContext context, ILogger<JwtService> logger)
    //    {
    //        _config = config;
    //        _userManager = userManager;
    //        _context = context;
    //        _logger = logger;
    //    }

    //    public async Task<(string accessToken, string refreshToken)> GenerarTokensAsync(Usuarios user)
    //    {
    //        var Rols = await _userManager.GetRolesAsync(user);
    //        var claims = new List<Claim>
    //        {
    //            new(JwtRegisteredClaimNames.Sub,   user.idUsuario.ToString()),
    //            //new(JwtRegisteredClaimNames.correo, user.correo ?? ""),
    //            new(JwtRegisteredClaimNames.Jti,   Guid.NewGuid().ToString()),
    //            new(JwtRegisteredClaimNames.Iat,   DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()),
    //            new(ClaimTypes.Name,               user.userName ?? ""),
    //            new(ClaimTypes.NameIdentifier,     user.idUsuario.ToString()),
    //            new("nombre_completo",             user.nombreCompleto!),
    //            new("cargo",                       user.cargo ?? ""),
    //            new("foto",                        user.avatar ?? ""),
    //        };

    //        foreach (var Rol in Rols)
    //            claims.Add(new Claim(ClaimTypes.Role, Rol));

    //        var secret = _config["JwtSettings:Secret"] ?? "AppServiceAndTravel_SecretKey_2024!#@";
    //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
    //        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
    //        var expMin = int.Parse(_config["JwtSettings:ExpiracionMinutos"] ?? "60");

    //        var token = new JwtSecurityToken(
    //            issuer: _config["JwtSettings:Issuer"] ?? "AppServiceAndTravel",
    //            audience: _config["JwtSettings:Audience"] ?? "AppServiceAndTravelClients",
    //            claims: claims,
    //            expires: DateTime.UtcNow.AddMinutes(expMin),
    //            signingCredentials: creds
    //        );

    //        var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
    //        var refreshToken = GenerarRefreshToken();

    //        user.refreshToken = refreshToken;
    //        user.refreshTokenExpiry = DateTime.UtcNow.AddDays(7);
    //        user.ultimoAcceso = DateTime.Now;
    //        await _userManager.UpdateAsync(user);

    //        return (accessToken, refreshToken);
    //    }

    //    public ClaimsPrincipal? ValidarToken(string token)
    //    {
    //        try
    //        {
    //            var secret = _config["JwtSettings:Secret"] ?? "AppServiceAndTravel_SecretKey_2024!#@";
    //            var handler = new JwtSecurityTokenHandler();
    //            var principal = handler.ValidateToken(token, new TokenValidationParameters
    //            {
    //                ValidateIssuerSigningKey = true,
    //                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)),
    //                ValidateIssuer = true,
    //                ValidIssuer = _config["JwtSettings:Issuer"] ?? "AppServiceAndTravel",
    //                ValidateAudience = true,
    //                ValidAudience = _config["JwtSettings:Audience"] ?? "AppServiceAndTravelClients",
    //                ValidateLifetime = false // Para refresh
    //            }, out _);
    //            return principal;
    //        }
    //        catch { return null; }
    //    }

    //    public async Task<(string accessToken, string refreshToken)?> RefrescarTokenAsync(string refreshToken)
    //    {
    //        var user = await _context.Usuarios
    //            .FirstOrDefaultAsync(u => u.refreshToken == refreshToken
    //                && u.refreshTokenExpiry > DateTime.UtcNow);

    //        if (user == null) return null;
    //        return await GenerarTokensAsync(user);
    //    }

    //    private static string GenerarRefreshToken()
    //    {
    //        var bytes = new byte[64];
    //        using var rng = RandomNumberGenerator.Create();
    //        rng.GetBytes(bytes);
    //        return Convert.ToBase64String(bytes);
    //    }
    //}

    // ══════════════════════════════════════════════════════════════
    // CLAIMS PRINCIPAL FACTORY — enriquece el ClaimsPrincipal de Identity
    // ══════════════════════════════════════════════════════════════
    public class AppClaimsFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public AppClaimsFactory(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> RolManager, IOptions<IdentityOptions> options)
            : base(userManager, RolManager, options) { }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaims(new[]
            {
                new Claim("nombre_completo", user.nombreCompleto!),
                new Claim("cargo",           user.cargo ?? ""),
                new Claim("foto",            user.avatar ?? ""),
                new Claim("activo",          user.activo.ToString()),
                new Claim("fecha_creacion",  user.fechaCreacion.ToString("o")),
            });

            return identity;
        }
    }

    // ══════════════════════════════════════════════════════════════
    // CONFIGURACIÓN SERVICE — lee/escribe ConfiguracionEmpresa
    // ══════════════════════════════════════════════════════════════
    public interface IConfiguracionService
    {
        Task<ConfiguracionEmpresa> ObtenerAsync();
        Task GuardarAsync(ConfiguracionEmpresa config, string userId);
    }

    public class ConfiguracionService : IConfiguracionService
    {
        private readonly ApplicationDBContext _context;
        private static ConfiguracionEmpresa? _cache;

        public ConfiguracionService(ApplicationDBContext context) => _context = context;

        public async Task<ConfiguracionEmpresa> ObtenerAsync()
        {
            if (_cache != null) return _cache;
            _cache = await _context.ConfiguracionEmpresa.FirstOrDefaultAsync()
                     ?? new ConfiguracionEmpresa { Id = 1 };
            return _cache;
        }

        public async Task GuardarAsync(ConfiguracionEmpresa config, string userId)
        {
            config.UltimaModificacion = DateTime.Now;
            config.ModificadoPorId = userId;

            var existente = await _context.ConfiguracionEmpresa.FirstOrDefaultAsync();
            if (existente == null)
                _context.ConfiguracionEmpresa.Add(config);
            else
            {
                config.Id = existente.Id;
                _context.Entry(existente).CurrentValues.SetValues(config);
            }

            await _context.SaveChangesAsync();
            _cache = config; // actualizar caché
        }
    }
}

// Necesario para IOptions en ClaimsFactory
namespace Microsoft.Extensions.Options
{
    // Re-export para que compile sin using adicional
}