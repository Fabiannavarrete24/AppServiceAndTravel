using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{
    public enum EstadoCotizacion { Pendiente, Aprobada, Rechazada }
    public class Cotizacion
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [Required, StringLength(200)]
        public string Origen { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Destino { get; set; } = string.Empty;

        [Required]
        public DateTime FechaServicioRequerido { get; set; }

        [StringLength(1000)]
        public string? DescripcionCarga { get; set; }

        public int NumPasajeros { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorCotizado { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal? ValorAprobado { get; set; }

        public EstadoCotizacion Estado { get; set; } = EstadoCotizacion.Pendiente;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public DateTime? FechaAprobacion { get; set; }
        public int? UsuarioCreadorId { get; set; }
        public ApplicationUser? UsuarioCreador { get; set; }
        public int? UsuarioAprobadorId { get; set; }
        public ApplicationUser? UsuarioAprobador { get; set; }

        [StringLength(1000)]
        public string? ObservacionesAprobacion { get; set; }

        [StringLength(1000)]
        public string? ObservacionesRechazo { get; set; }

        public Servicio? Servicio { get; set; }
    }
}