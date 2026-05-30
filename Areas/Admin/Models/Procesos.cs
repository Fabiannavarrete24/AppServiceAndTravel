using Microsoft.Graph.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public partial class Procesos
    {
        [Key]
        public int idProceso { get; set; }
        [StringLength(250)] public string? url { get; set; }
        [StringLength(200)] public string? proceso { get; set; }
        [StringLength(200)] public string? area { get; set; }
        [StringLength(200)] public string? controlador { get; set; }
        [StringLength(200)] public string? icono { get; set; }        
        public DateTime fechaCreacion { get; set; } = DateTime.UtcNow;
        public int? idProcesoPadre { get; set; }
        [ForeignKey("idProcesoPadre")]
        public virtual Procesos? idProcesoPadreNavigation { get; set; }
        public List<Procesos> inverseidProcesoPadreNavigation { get; set; } = new List<Procesos>();
        public virtual ICollection<Permisos> Permisos { get; set; } = new List<Permisos>();
    }
}
