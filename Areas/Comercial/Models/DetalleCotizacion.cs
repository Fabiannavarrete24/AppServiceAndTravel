using AppServiceAndTravel.Areas.Operaciones.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Comercial.Models
{
    public class DetalleCotizacion
    {
        [Key]
        public int idDetalleCotizacion { get; set; }

        public int idCotizacion { get; set; }

        [ForeignKey(nameof(idCotizacion))]
        public Cotizaciones? Cotizacion { get; set; }

        public int? idTipoServicio { get; set; }

        [ForeignKey(nameof(idTipoServicio))]
        public TiposServicios? TipoServicio { get; set; }

        public int? idTipoVehiculo { get; set; }

        [ForeignKey(nameof(idTipoVehiculo))]
        public TiposVehiculos? TipoVehiculo { get; set; }

        [Required]
        [StringLength(200)]
        public string Origen { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Destino { get; set; } = string.Empty;

        public DateTime FechaServicioInicio { get; set; }

        public DateTime FechaServicioFin { get; set; }

        public int Cantidad { get; set; } = 1;

        public int NumPasajeros { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorTotal { get; set; }

        public bool Disponibilidad { get; set; } = false;

        public string? Observaciones { get; set; }
        public int? idServicio { get; set; }
        [ForeignKey(nameof(idServicio))]
        public bool Realizado { get; set; } = false;
        public ICollection<Servicios> Servicios { get; set; } = new List<Servicios>();
    }
}