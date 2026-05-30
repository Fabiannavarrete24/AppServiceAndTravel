using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class TipoActividadSistema
    {
        [Key]
        public int idTipoActividadSistema { get; set; }

        [Required]
        [MaxLength(100)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Icono { get; set; }

        [MaxLength(20)]
        public string? Color { get; set; }

        public bool Activo { get; set; } = true;
    }
}