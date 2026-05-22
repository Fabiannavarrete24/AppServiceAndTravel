using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{
    public class Permisos
    {
        public int idProceso { get; set; }
        public int idRol { get; set; }
        public bool lectura { get; set; }
        public bool crea { get; set; }
        public bool edita { get; set; }        
        public bool elimina { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        [ForeignKey("idRol")]
        public virtual Roles? rol { get; set; }
        [ForeignKey("idProceso")]
        public virtual Procesos? proceso { get; set; }
    }
}

