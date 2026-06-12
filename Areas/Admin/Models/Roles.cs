using System.ComponentModel.DataAnnotations;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class Roles
    {
        [Key]
        public int idRol { get; set; }
        [StringLength(200)] public string? nombre { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public DateTime fechaModificacion { get; set; } = DateTime.UtcNow;
        public virtual ICollection<ApplicationUser> Usuarios { get; set; } = new List<ApplicationUser>();

        public virtual ICollection<Permisos> Permisos { get; set; } = new List<Permisos>();
    }
}
