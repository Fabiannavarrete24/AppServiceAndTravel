using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.ViewModels
{
    public class LoginVM
    {
        public int idUsuario { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? nombreCompleto { get; set; }        
        public string? correo { get; set; }
        public int admin { get; set; }
        public DateTime? dateChangePassword { get; set; } = DateTime.UtcNow.AddMonths(3);
        public int valido { get; set; }
        public int restaurada { get; set; }
        public int confirmada { get; set; }
    }
}


