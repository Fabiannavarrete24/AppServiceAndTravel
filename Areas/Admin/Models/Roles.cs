using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class Roles
    {
        [Key]
        public int idRol { get; set; }
        [StringLength(200)] public string? nombre { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public DateTime fechaModificacion { get; set; } = DateTime.UtcNow;
        public virtual ICollection<RolesUsuarios> RolesUsuarios { get; set; } = new List<RolesUsuarios>();

        public virtual ICollection<Permisos> Permisos { get; set; } = new List<Permisos>();
    }
}
