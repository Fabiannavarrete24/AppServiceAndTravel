using Microsoft.Graph.Models;
using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class ApplicationUser
    {
        [Key]
         public int idUsuario { get; set; }
        [StringLength(200)] public string? userName { get; set; } = string.Empty;
        [StringLength(200)] public string? password { get; set; } = string.Empty;
        [Required, StringLength(150)] public  string? nombreCompleto { get; set;  } = string.Empty;
        [StringLength(20)] public string? telefono { get; set; }
        [StringLength(100)] public string? cargo { get; set; }
        [StringLength(200)] public string? correo { get; set; } = string.Empty;
        [StringLength(200)] public string? avatar { get; set; }
        public bool admin { get; set; } = false;
        public bool activo { get; set; } = true;
        public bool crypt { get; set; } = true;
        public bool hast { get; set; } = true;
        public bool? restaurada { get; set; } = false;
        public bool? confirmada { get; set; } = false;   
        [StringLength(500)] public string? token { get; set; }
        [StringLength(500)] public string? refreshToken { get; set; }
        public DateTime? fechaExpiracionToken { get; set; }        
        public DateTime? refreshTokenExpiry { get; set; }
        public DateTime? fechaBaja { get; set; }
        public DateTime? ultimoAcceso { get; set; } = DateTime.UtcNow;
        public DateTime fechaCambioClave { get; set; } = DateTime.UtcNow.AddMonths(3);
        public DateTime fechaModificacion { get; set; } = DateTime.UtcNow;
        public DateTime fechaCreacion { get; set; } = DateTime.UtcNow;        
        public virtual ICollection<RolesUsuarios>? RolesUsuarios { get; set; }        
    }
}
