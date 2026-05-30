using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class ConfigNotificaciones
    {
        [Key]
        public int idConfigNotificacion { get; set; }
        [StringLength(100)] public string? correoRemitente { get; set; }
        [StringLength(100)] public string? NombreRemitente { get; set; }
        [StringLength(100)] public string  smtpServer { get; set; } = "smtp.gmail.com";
        public int smtpPort { get; set; } = 465;
        [StringLength(100)] public string smtpUserName { get; set; } = "noresponder213@gmail.com";
        [StringLength(100)] public string smtpPassword { get; set; } = "phiduwyhgcknxsiy";
        public bool requiereSSL { get; set; } = true;
        public bool requiereTSL { get; set; } = false;        
        [StringLength(100)] public string? ProveedorWhatsApp { get; set; }
        [StringLength(500)] public string? WhatsAppApiUrl { get; set; }
        [StringLength(500)] public string? WhatsAppApiKey { get; set; }
        [StringLength(30)] public string? WhatsAppNumeroEmpresa { get; set; }
        public bool WhatsAppValidado { get; set; }
        public DateTime? WhatsAppFechaValidacion { get; set; }
        public DateTime UltimaModificacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;    
        public int? ModificadoPorId { get; set; }
    }
}
