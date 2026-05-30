using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class Notificaciones
    {
        [Key]
        public int? idNotificacion { get; set; }
        public DateTime? fechaCreacion { get; set; }= DateTime.UtcNow;
        [StringLength(200)] public string? titulo { get; set; }
        [StringLength(200)] public string? mensjae { get; set; }
        public bool leido {  get; set; }
        [StringLength(200)] public string? categoriaNotificacion { get; set; }

    }
}
