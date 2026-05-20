using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class Roles
    {
        [Key]
        public int idRol { get; set; }
        [StringLength(200)] public string? descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public DateTime fechaModificacion { get; set; } = DateTime.UtcNow;
    }
}
