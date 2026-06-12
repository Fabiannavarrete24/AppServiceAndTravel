using AppServiceAndTravel.Areas.Comercial.Models;

namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class CotizacionDetalleVM
    {
        public int idCotizacion { get; set; }
        public int idCliente { get; set; }
        public string Cliente { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Origen { get; set; } = "";
        public string Destino { get; set; } = "";
        public DateTime FechaServicioInicio { get; set; }
        public DateTime FechaServicioFin { get; set; }
        public int cantidad { get; set; }
        public string? Observaciones { get; set; }
        public int NumPasajeros { get; set; }
        public decimal ValorCotizado { get; set; }
        public decimal? ValorAprobado { get; set; }
        public string Estado { get; set; } = "";
        public DateTime FechaCreacion { get; set; }
        public string? ObservacionesAprobacion { get; set; }
        public string? ObservacionesRechazo { get; set; }
        public bool TieneServicio { get; set; }
        public List<DetalleCotizacionVM> Detalles { get; set; } = new();
    }
}