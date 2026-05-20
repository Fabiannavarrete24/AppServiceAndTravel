using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class ApplicationUser
    {
        [Key]
         public int idUsuario { get; set; }
        [StringLength(200)] public string? userName { get; set; }
        [StringLength(200)] public string? password { get; set; }
        [Required, StringLength(150)] public  string? nombreCompleto { get; set;  } = string.Empty;
        [StringLength(20)] public string? telefono { get; set; }
        [StringLength(100)] public string? cargo { get; set; }
        [StringLength(200)] public string? correo { get; set; }
        public bool admin { get; set; } = false;
        public bool activo { get; set; } = false;
        public bool crypt { get; set; } = false;
        public bool hast { get; set; } = false;
        public DateTime? fechaBaja { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public  DateTime? fechaCambioClave { get; set; } = DateTime.UtcNow.AddMonths(3);
        public  DateTime? fechaModificacion { get; set; }
        public DateTime? fechaExpiracionToken { get; set; }
        public DateTime? ultimoAcceso { get; set; }
        public bool restaurada { get; set; } = false;
        public bool confirmada { get; set; } = false;
        [StringLength(200)] public string? token { get; set; }
        [StringLength(200)] public string? avatar { get; set; }
        [StringLength(200)] public string? refreshToken { get; set; }
        public DateTime? refreshTokenExpiry { get; set; }
    }
}
