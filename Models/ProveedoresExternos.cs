using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{
    
    public class ProveedoresExternos
    {
        [Key]
        public int IdProveedorExterno { get; set; }
        [Required, StringLength(200)] public string RazonSocial { get; set; } = string.Empty;
        [Required, StringLength(30)] public string NitCedula { get; set; } = string.Empty;
        [StringLength(200)] public string? Contacto { get; set; }
        [Required, StringLength(25)] public string Telefono { get; set; } = string.Empty;
        [StringLength(200)] public string? correo { get; set; }
        [StringLength(250)] public string? Direccion { get; set; }
        public TipoServicioExterno TipoServicio { get; set; } = TipoServicioExterno.Ambos;
        [Column(TypeName = "decimal(12,2)")] public decimal? TarifaBase { get; set; }
        [StringLength(1000)] public string? Observaciones { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
