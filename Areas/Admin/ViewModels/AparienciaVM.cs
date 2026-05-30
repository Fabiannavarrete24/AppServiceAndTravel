using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class AparienciaVM
    {
        public string? TemaSeleccionado { get; set; }
        public string? FuenteSistema { get; set; }
        public string? TamanoFuenteBase { get; set; }
        public string? ColorPrimario { get; set; }
        public string? ColorSecundario { get; set; }
        public string? ColorAcento { get; set; }
        public string? ColorTexto { get; set; }
        public string? ColorFondo { get; set; }
        public string? ColorPeligro { get; set; }
        public string? ColorAdvertencia { get; set; }
        public DateTime UltimaModificacion { get; set; }
    }
}