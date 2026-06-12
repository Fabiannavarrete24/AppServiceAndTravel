namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class CotizacionComboVM
    {
        public int idCotizacion { get; set; }

        public string cliente { get; set; } = string.Empty;

        public DateTime fechaCreacion { get; set; }

        public decimal valorCotizado { get; set; }

        public string display =>
            $"#{idCotizacion} - {cliente} - {fechaCreacion:dd/MM/yyyy}";
    }
}