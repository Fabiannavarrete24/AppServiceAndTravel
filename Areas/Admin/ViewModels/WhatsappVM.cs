using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class WhatsappVM
    {
        public string? ProveedorWhatsApp { get; set; }
        public string? WhatsAppApiUrl { get; set; }
        public string? WhatsAppApiKey { get; set; }
        public string? WhatsAppNumeroEmpresa { get; set; }
        public bool WhatsAppValidado { get; set; }
        public DateTime? WhatsAppFechaValidacion { get; set; }
        public DateTime UltimaModificacion { get; set; }
    }
}