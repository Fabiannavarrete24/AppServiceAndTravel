namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class CotizacionUpdateVM
    {
        public int idCotizacion { get; set; }
        public int idCliente { get; set; }
        public string Origen { get; set; } = "";
        public string Destino { get; set; } = "";
        public DateTime FechaInicioServicio { get; set; }
        public DateTime FechaFinalServicio { get; set; }
        public int diasServicio { get; set; }
        public int cantidad { get; set; }
        public string? Observaciones { get; set; }
        public int NumPasajeros { get; set; }
        public decimal ValorCotizado { get; set; }
        public List<DetalleCotizacionVM>? Detalles { get; set; }
    }
}