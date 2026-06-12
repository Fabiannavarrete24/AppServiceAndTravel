using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class CategoriasVehiculos
    {
        [Key]
        public int idCategoriaVehiculo { get; set; }

        [Required] [StringLength(100)] public string descripcion { get; set; } = string.Empty;

        public ICollection<TiposVehiculos> TiposVehiculos { get; set; } = new List<TiposVehiculos>();
    }
}
