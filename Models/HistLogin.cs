
using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class HistLogin
    {
        [Key]
        public int? idHist  {get; set;} 
        public int? idUsuario {get; set;} 
        [StringLength(200)] public string? userName {get; set;} 
        public bool valido {get; set;}
        public bool inSesion { get; set; }
        [StringLength(200)] public string? mensaje {get; set;}    
         public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;

        
    }
}

