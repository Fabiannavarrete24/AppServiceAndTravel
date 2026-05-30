using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.ViewModels
{
    public class RegionalVM
    {
        public string? Moneda { get; set; }
        public string? SimboloMoneda { get; set; }
        public string? Idioma { get; set; }
        public string? ZonaHoraria { get; set; }
        public string? FormatoFecha { get; set; }
        public string? SeparadorDecimal { get; set; }
        public string? SeparadorMiles { get; set; }
        public DateTime UltimaModificacion { get; set; }
    }
}