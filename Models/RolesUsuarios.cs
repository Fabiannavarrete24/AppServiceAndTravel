using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class RolesUsuarios
    {
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public int idUsuario { get; set; }
        public ApplicationUser? User { get; set; }
        public int idRol { get; set; }
        public Roles? Rol { get; set; }
    }
}
