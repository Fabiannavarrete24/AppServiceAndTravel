using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class UserVM
    {
        public int idUsuario { get; set; }
        public string? Username { get; set; }
        public string? nombreCompleto { get; set; }
        public string? password { get; set; }
        public string? correo { get; set; }
        public string? telefono { get; set; }
        public string? cargo { get; set; }
        public DateTime? fechaBaja { get; set; }
        public DateTime? dateChangePassword { get; set; }
        public bool admin { get; set; }
        public int idRol { get; set; }
        public string? rol { get; set; }
        public bool activo { get; set; }
        public bool? restaurada { get; set; }
        public bool? confirmada { get; set; }
        public string? token { get; set; }
        public DateTime? fechaUltimoAcceso { get; set; }
        public DateTime? tokenDateExpiration { get; set; }    
    }
}
