using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.ViewModels
{
    public class LoginResponseVM
    {
        public int idUsuario { get; set; }
        [StringLength(200)] public string? userName { get; set; }
        [StringLength(200)] public string? password { get; set; }
        [StringLength(200)] public string? correo { get; set; }
        public int admin { get; set; }
        public DateTime? changePassowrdDate { get; set; }
        public bool success { get; set; }
        public int restaurada { get; set; }
        public int confirmada { get; set; }
        public int activo { get; set; }
        [StringLength(200)] public string? message { get; set; }
    }
}


