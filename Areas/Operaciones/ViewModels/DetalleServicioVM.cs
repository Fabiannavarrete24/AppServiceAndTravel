namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class DetalleServicioVM
    {
        public int idCotizacion { get; set; }

        public int idDetalleCotizacion { get; set; }

        public int? idTipoVehiculo { get; set; }

        public string cliente { get; set; } = string.Empty;

        public string origen { get; set; } = string.Empty;

        public string destino { get; set; } = string.Empty;

        public string tipoVehiculo { get; set; } = string.Empty;

        public DateTime fechaInicioServicio { get; set; }

        public DateTime fechaFinServicio { get; set; }

        public int numPasajeros { get; set; }

        public int cantidad { get; set; }

        public decimal valorUnitario { get; set; }

        public decimal valorTotal { get; set; }

        public string? observaciones { get; set; }
    }
}