using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class ConfigNotificaciones
    {
        [Key]
        public string?  smtpServer { get; set; }
        public string? smtpPort { get; set; }
        public string? smtpUserName { get; set; }
        public string? smtpPassword { get; set; }
        public bool requiereSSL { get; set; } = false;
        public bool requiereTSL { get; set; } = false;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
        public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
