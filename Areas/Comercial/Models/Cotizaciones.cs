using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Comercial.Models
{    
    public class Cotizaciones
    {
        [Key] public int idCotizacion { get; set; }
        [Required] public int idCliente { get; set; }
        [ForeignKey(nameof(idCliente))] public Clientes? Cliente { get; set; }
        [Required, StringLength(200)] public string Origen { get; set; } = string.Empty;
        [Required, StringLength(200)] public string Destino { get; set; } = string.Empty;
        [Required] public DateTime FechaInicioServicio { get; set; }
        [Required] public DateTime FechaFinalServicio { get; set; }
        public int? diasServicio { get; set; }
        public int? cantidad { get; set; }
        public bool disponibilidad { get; set; } = false;
        [StringLength(1000)] public string? Observaciones { get; set; }
        public int NumPasajeros { get; set; }
        [Column(TypeName = "decimal(12,2)")] public decimal ValorCotizado { get; set; }
        [Column(TypeName = "decimal(12,2)")] public decimal? ValorAprobado { get; set; }
        public EstadoCotizacion Estado { get; set; } = EstadoCotizacion.Pendiente;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaAprobacion { get; set; }
        public int TiempoValidez { get; set; } = 15;
        public int? idUsuarioCreador { get; set; }
        [ForeignKey(nameof(idUsuarioCreador))] public ApplicationUser? UsuarioCreador { get; set; }
        public int? idUsuarioAprobador { get; set; }
        [ForeignKey(nameof(idUsuarioAprobador))] public ApplicationUser? UsuarioAprobador { get; set; }
        [StringLength(1000)] public string? ObservacionesAprobacion { get; set; }
        [StringLength(1000)] public string? ObservacionesRechazo { get; set; }
        public ICollection<DetalleCotizacion> Detalles { get; set; } = new List<DetalleCotizacion>();
        public int? idTipoServicio { get; set; }
        public TiposServicios? TipoServicio { get; set; }

        public int? idTipoVehiculo { get; set; }
        public TiposVehiculos? TipoVehiculo { get; set; }
    }
}