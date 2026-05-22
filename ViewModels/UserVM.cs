using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.ViewModels
{
    public class UserVM
    {
        public int idUser { get; set; }

        [StringLength(200)] public string? Username { get; set; }

        [StringLength(200)] public string? nombreCompleto { get; set; }

        [StringLength(200)] public string? Password { get; set; }

        [StringLength(200)] public string? confirmadaPassword { get; set; }

        [StringLength(200)] public string? correo { get; set; }

        public DateTime? fechaBaja { get; set; }

        public DateTime? dateChangePassword { get; set; }

        public bool Valid { get; set; }

        public int Admin { get; set; }

        [StringLength(200)] public string? message { get; set; }

        public int IdRol { get; set; }

        public bool? restaurada { get; set; }

        public bool? confirmada { get; set; }

        [StringLength(200)] public string? Token { get; set; }

        public DateTime? tokenDateExpiration { get; set; }    
    }
}
