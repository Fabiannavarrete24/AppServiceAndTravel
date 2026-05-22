using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class FormatosCorreos
    {
        [Key]
        public int idCorreo { get; set; }    
        public string? abreviatura { get; set; }
        public string? titulo {  get; set; }
        public string? mensaje { get; set; }
        public DateTime FechaRegistro { get; set; }= DateTime.UtcNow;
    }
}
