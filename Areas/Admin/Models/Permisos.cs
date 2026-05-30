using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class Permisos
    {

        public int idProceso { get; set; }

        public int idRol { get; set; }

        public bool lectura { get; set; }

        public bool crea { get; set; }

        public bool edita { get; set; }

        public bool elimina { get; set; }
      
        public bool deny { get; set; }

        public bool hereda { get; set; } = true;

        public bool apiAccess { get; set; }

        public string? claims { get; set; }

        public string? endpoint { get; set; }

        public string? controllerAction { get; set; }

        public DateTime fechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime fechaModificacion { get; set; } = DateTime.UtcNow;

        public int? modificadoPorId { get; set; }

        [ForeignKey("idRol")]
        public virtual Roles? rol { get; set; }

        [ForeignKey("idProceso")]
        public virtual Procesos? proceso { get; set; }
    }
}

