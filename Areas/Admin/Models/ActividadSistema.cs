using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class ActividadSistema
    {
        [Key]
        public int idActividadSistema { get; set; }
        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; } = string.Empty;   
        public int? idUsuario { get; set; }
        [MaxLength(150)]
        public string? UsuarioNombre { get; set; }
        [MaxLength(100)]
        public string? Entidad { get; set; }
        public int? EntidadId { get; set; }
        [MaxLength(100)]
        public string? EstadoAnterior { get; set; }
        [MaxLength(100)]
        public string? EstadoNuevo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [MaxLength(100)]
        public string? IpAddress { get; set; }        
        
        [ForeignKey(nameof(idUsuario))]
        public virtual ApplicationUser? Usuario { get; set; }
        public int idTipoActividadSistema { get; set; }
        [ForeignKey(nameof(idTipoActividadSistema))]
        public virtual TipoActividadSistema? TipoActividad { get; set; }
    }
}