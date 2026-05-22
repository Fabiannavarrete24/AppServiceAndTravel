using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.ViewModels;
using System.Security.Claims;

namespace AppServiceAndTravel.Services
{
    public interface IJwtService
    {
        JwtSettings ConfigJWT();
    }
    public class JwtService : IJwtService
    {        
        private readonly IConfiguration _configuration;
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public JwtSettings ConfigJWT() {
            
            var result = new JwtSettings
            {
                SecretKey = _configuration["JwtSettings:SecretKey"],
                Issuer = _configuration["JwtSettings:Issuer"],
                Audience = _configuration["JwtSettings:Audience"],
                ExpirationMinutes = Convert.ToInt32(_configuration["JwtSettings:ExpirationMinutes"])
            };

            return result;

        }
    }
}
