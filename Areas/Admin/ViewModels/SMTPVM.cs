using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class SMTPVM
    {
        public string? correoRemitente { get; set; }
        public string? NombreRemitente { get; set; }
        public string?  smtpServer { get; set; }
        public int smtpPort { get; set; }
        public string? smtpUserName { get; set; }
        public string? smtpPassword { get; set; }
        public bool requiereSSL { get; set; }
        public bool requiereTSL { get; set; }
        public DateTime UltimaModificacion { get; set; }
    }
}