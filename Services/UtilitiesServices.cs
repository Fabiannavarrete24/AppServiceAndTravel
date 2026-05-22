
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using System.Data;
using MySql.Data.MySqlClient;
using Npgsql;

namespace AppServiceAndTravel.Services
{
    public class UtilitiesServices
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDBContext _context;

        public UtilitiesServices(IConfiguration configuration, ApplicationDBContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public string Encriptar(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("La clave no puede ser nula o vacía");

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
        public string GenerarUserName(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            var palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Convertimos todas las palabras a minúsculas
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = palabras[i].ToLower();
            }

            if (palabras.Length == 2)
            {
                return palabras[0][0] + palabras[1];
            }
            else if (palabras.Length == 3)
            {
                return palabras[0][0] + palabras[1];
            }
            else if (palabras.Length == 4)
            {
                return palabras[0][0] + palabras[2];
            }

            return "";
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
        public FormatosCorreos FormatosCorreos(string tipo)
        {
            try
            {
                var results = _context.FormatosCorreos.FirstOrDefault(f => f.abreviatura == tipo);

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
        public void RegistrarLog(string message, string metodo, string prodimiento)
        {
            try
            {
                string ruta = Path.Combine(Directory.GetCurrentDirectory(), _configuration["RutaAdjuntos:RutaLog"]!, _configuration["RutaAdjuntos:ArchivoLog"]!);

                Directory.CreateDirectory(Path.GetDirectoryName(ruta)!);

                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.WriteLine("==========");
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - inicio de ejecucion del metodo {metodo} - {prodimiento}: {message}");
                    writer.WriteLine("==========================");
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en log: {ex.Message}");
            }
        }
        public string ConvertToBase64(IFormFile file)
        {
            using var ms = new MemoryStream();
            file.CopyTo(ms);
            var base64 = Convert.ToBase64String(ms.ToArray());
            return base64;
        }
        public string GenerateToken(string username, JwtSettings  settings)
        {
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(settings.SecretKey!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username)
            };

            var token = new JwtSecurityToken(
                issuer: settings.Issuer,
                audience: settings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(settings.ExpirationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
