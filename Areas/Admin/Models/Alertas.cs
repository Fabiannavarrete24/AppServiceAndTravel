using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class Alertas
    {
        [Key]
        public int idAlerta { get; set; }
        public bool success {get;set;}
        public string? message { get; set; }
        public string? icon { get; set; }
         public DateTime registerDate { get; set; }= DateTime.UtcNow;
    }
}
