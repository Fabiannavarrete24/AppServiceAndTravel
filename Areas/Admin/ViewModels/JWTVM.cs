using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class JWTVM
    {
        public string? JwtSecretKey { get; set; }
        public string? JwtIssuer { get; set; }
        public string? JwtAudience { get; set; }
        public int JwtExpirationMinutes { get; set; } = 60;
        public DateTime UltimaModificacion { get; set; }
    }
}