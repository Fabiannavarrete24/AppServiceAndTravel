namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class DetalleCotizacionComboVM
    {
        public int idDetalleCotizacion { get; set; }

        public int idCotizacion { get; set; }

        public string origen { get; set; } = string.Empty;

        public string destino { get; set; } = string.Empty;

        public string tipoVehiculo { get; set; } = string.Empty;

        public DateTime fechaInicio { get; set; }

        public DateTime fechaFin { get; set; }

        public string descripcion { get; set; } = string.Empty;
    }
}