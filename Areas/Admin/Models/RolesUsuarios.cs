using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class RolesUsuarios
    {
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public int idUsuario { get; set; }
        [ForeignKey("idUser")]
        public ApplicationUser? Usuario { get; set; }
        public int idRol { get; set; }
        [ForeignKey("idRol")]
        public Roles? Rol { get; set; }        
    }
}
