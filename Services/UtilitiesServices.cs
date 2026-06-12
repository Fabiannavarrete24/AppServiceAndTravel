
using AppServiceAndTravel.Areas.Admin.Models;
using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

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
        public ApiResponse<ListSelectVM> ObtenerSelect()
        {
            try
            {
                var response = new ListSelectVM
                {
                    CategoriasVehiculo = _context.CategoriasVehiculos
                    .Select(x => new ComboVM
                    {
                        id = x.idCategoriaVehiculo,
                        descripcion = x.descripcion
                    })
                    .OrderBy(x => x.descripcion)
                    .ToList(),

                    TiposServicio = _context.TiposServicios
                    .Select(x => new ComboVM
                    {
                        id = x.idTipoServicio,
                        descripcion = x.descripcion
                    })
                    .ToList(),

                    Estados = Enum.GetValues<EstadoGeneral>()
                    .Select(x => new ComboVM
                    {
                        id = (int)x,
                        descripcion = x.ToString()
                    })
                    .ToList()
                };

                return new ApiResponse<ListSelectVM>
                {
                    Success = true,
                    Data = response
                };
            }
            catch (Exception ex)
            {
                return new ApiResponse<ListSelectVM>
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
        public List<ComboVM> ObtenerTiposVehiculos(int idCategoria)
        {
            return _context.TiposVehiculos
                .Where(x => x.idCategoriaVehiculo == idCategoria)
                .OrderBy(x => x.descripcion)
                .Select(x => new ComboVM
                {
                    id = x.idTipoVehiculo,
                    descripcion = x.descripcion
                })
                .ToList();
        }

        public string ConvertToBase64(IFormFile file)
        {
            using var ms = new MemoryStream();
            file.CopyTo(ms);
            var base64 = Convert.ToBase64String(ms.ToArray());
            return base64;
        }
        public string GenerateToken(string username, JwtSettings settings)
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
        public void RegistrarLog(string mensaje, string metodo, string nivel = "INFO")
        {
            try
            {
                string ruta = Path.Combine(Directory.GetCurrentDirectory(), _configuration["LogsEjecuciones:Ruta"]!, _configuration["LogsEjecuciones:Archivo"]!);

                Directory.CreateDirectory(Path.GetDirectoryName(ruta)!);

                string texto = $@"
                    ==================================================
                    Fecha   : {DateTime.Now:yyyy-MM-dd HH:mm:ss}
                    Nivel   : {nivel}
                    Metodo  : {metodo}
                    Mensaje : {mensaje}
                    ==================================================

                    ";

                File.AppendAllText(ruta, texto);

                Console.WriteLine($"LOG OK: {ruta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR LOG:");
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
