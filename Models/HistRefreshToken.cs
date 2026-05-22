using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class HistRefreshToken
    {
        [Key]
        public int IdHistRefreshToken { get; set; }
        public int idUsuario { get; set; }
        [StringLength(200)] public string? Token { get; set; }
        [StringLength(200)] public string? RefreshToken { get; set; }        
        public DateTime fechaCreacion { get; set; } = DateTime.Now;
        public DateTime fechaExpiracion { get; set; }
        public bool activo { get; set; }
        public virtual ApplicationUser? idUsuarioNavigation { get; set; }
    }
}
