using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;

namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class DetalleCotizacionVM
    {
        [Key]
        public int idDetalleCotizacion { get; set; }

        public int idCotizacion { get; set; }
        [ForeignKey(nameof(idCotizacion))] public Cotizaciones? Cotizacion { get; set; }

        public int? idTipoServicio { get; set; }
        public string TipoServicio { get; set; } = "";
        public int? idTipoVehiculo { get; set; }
        public string TipoVehiculo { get; set; } = "";

        [Required]
        [StringLength(200)] public string Origen { get; set; } = string.Empty;

        [Required]
        [StringLength(200)] public string Destino { get; set; } = string.Empty;

        public DateTime FechaServicioInicio { get; set; }

        public DateTime FechaServicioFin { get; set; }

        public int Cantidad { get; set; } = 1;
        public int diasServicio { get; set; } = 1;
        public int NumPasajeros { get; set; } = 1;

        [Column(TypeName = "decimal(12,2)")] public decimal ValorUnitario { get; set; }

        [Column(TypeName = "decimal(12,2)")] public decimal ValorTotal { get; set; }

        public bool Disponibilidad { get; set; }

        public string? Observaciones { get; set; }

        public ICollection<Servicios> Servicios { get; set; } = new List<Servicios>();
    }
}