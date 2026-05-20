using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public partial class Procesos
    {
        [Key]
        public int IdProceso { get; set; }
        [StringLength(250)] public string? url { get; set; }
        [StringLength(200)] public string? proceso { get; set; }
        [StringLength(200)] public string? area { get; set; }
        [StringLength(200)] public string? controlador { get; set; }
        [StringLength(200)] public string? icono { get; set; }
        public int idParentproceso { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public virtual Procesos? idParentprocesoNavigation { get; set; }
        public List<Procesos> InverseidParentprocesoNavigation { get; set; } = new List<Procesos>();
    }
}
