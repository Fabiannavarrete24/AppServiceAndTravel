using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.ViewModels
{
    public class LoginVM
    {
        public int Id { get; set; }
        [StringLength(200)] public string? UserName { get; set; }
        [StringLength(200)] public string? Password { get; set; }
        [StringLength(200)] public string? correo { get; set; }
        public int Admin { get; set; }
        public DateTime? dateChangePassword { get; set; }
        public int valid { get; set; }
        public int restaurada { get; set; }
        public int confirmadaed { get; set; }
        [StringLength(200)] public string? message { get; set; }
    }
}


