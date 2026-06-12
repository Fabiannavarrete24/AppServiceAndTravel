namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class CotizacionVM
    {
        public int idCotizacion { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string? Correo { get; set; }
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public DateTime FechaInicioServicio { get; set; }
        public DateTime FechaFinalServicio { get; set; }
        public int diasServicio { get; set; }
        public int cantidad { get; set; }
        public bool disponibilidad { get; set; } = false;
        public string? Observaciones { get; set; }
        public int NumPasajeros { get; set; }
        public decimal ValorCotizado { get; set; }
        public decimal? ValorAprobado { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string? ObservacionesAprobacion { get; set; }
        public string? ObservacionesRechazo { get; set; }
        public int idCliente { get; set; }
        public int? idUsuarioCreador { get; set; }
        public int? idUsuarioAprobador { get; set; }
        public bool TieneServicio { get; set; }
        public List<DetalleCotizacionVM>? Detalles { get; set; }
    }
}