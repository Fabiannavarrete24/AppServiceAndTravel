using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{
    public enum EstadoLogSistema { INFO, WARNING, ERROR, CRITICAL }
    public class LogSistema
    {
        [Key]
        public int idLogSistema { get; set; }

        [Required]
        [MaxLength(50)]
        public EstadoLogSistema Nivel { get; set; } = EstadoLogSistema.INFO;

        [Required]
        [MaxLength(200)]
        public string Evento { get; set; } = string.Empty;

        [Required]
        public string Mensaje { get; set; } = string.Empty;

        // StackTrace / excepción
        public string? Detalle { get; set; }

        public int? idUsuario { get; set; }

        [MaxLength(150)]
        public string? UsuarioNombre { get; set; }

        // Request
        [MaxLength(500)]
        public string? Url { get; set; }

        [MaxLength(10)]
        public string? MetodoHttp { get; set; }

        [MaxLength(100)]
        public string? IpAddress { get; set; }

        [MaxLength(500)]
        public string? UserAgent { get; set; }

        // Fecha
        public DateTime Fecha { get; set; } = DateTime.Now;

        [ForeignKey(nameof(idUsuario))]
        public virtual ApplicationUser? Usuario { get; set; }
    }
}