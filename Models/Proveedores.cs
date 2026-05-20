using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class Proveedores
    {
        [Key]
        public int idProveedor { get; set; }
        [StringLength(200)] public string? descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
    }
}
