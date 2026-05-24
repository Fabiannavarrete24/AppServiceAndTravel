using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{
    public enum EstadoCotizacion { Pendiente, Aprobada, Rechazada }
    public class Cotizaciones
    {
        [Key]
        public int idCotizacion { get; set; }

        [Required]
        public int idCliente { get; set; }
        [ForeignKey(nameof(idCliente))]
        public Clientes? Cliente { get; set; }

        [Required, StringLength(200)]
        public string Origen { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Destino { get; set; } = string.Empty;
        [Required]
        public DateTime FechaServicio { get; set; }
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
        public int? idUsuarioCreador { get; set; }
        [ForeignKey(nameof(idUsuarioCreador))]
        public ApplicationUser? UsuarioCreador { get; set; }
        public int? idUsuarioAprobador { get; set; }
        [ForeignKey(nameof(idUsuarioAprobador))]
        public ApplicationUser? UsuarioAprobador { get; set; }

        [StringLength(1000)]
        public string? ObservacionesAprobacion { get; set; }
        [StringLength(1000)]
        public string? ObservacionesRechazo { get; set; }
        public Servicios? Servicio { get; set; }
    }
}