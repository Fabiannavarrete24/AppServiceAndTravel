using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.ViewModels
{
    public class HistLoginVM
    {
        public int Id { get; set; }
        [StringLength(200)] public string? UserName { get; set; }
        public bool success { get; set; }
        public bool restaurada { get; set; }
        public bool confirmado { get; set; }
        [StringLength(200)] public string? message { get; set; }
    }
}


