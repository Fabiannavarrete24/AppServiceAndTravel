using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class TiposVehiculos
    {
        [Key]
        public int idTipoVehiculo { get; set; }
        [Required] [StringLength(100)] public string descripcion { get; set; } = string.Empty;
        public DateTime fechaCreacion { get; set; } = DateTime.UtcNow;
        public int? idCategoriaVehiculo { get; set; }
        [ForeignKey(nameof(idCategoriaVehiculo))]
        public CategoriasVehiculos? Categoria { get; set; }
        public int idUsuarioModifica { get; set; }
        [ForeignKey(nameof(idUsuarioModifica))]
        public ApplicationUser? usuario { get; set; }
        public ICollection<Cotizaciones>? Cotizaciones { get; set; }
        public ICollection<Vehiculos>? Vehiculos { get; set; }
    }
}