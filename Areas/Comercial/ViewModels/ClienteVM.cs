using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Comercial.ViewModels
{
    public class ClienteVM
    {
        public int idCliente { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string RazonSocial { get; set; } = string.Empty;

        [Required(ErrorMessage = "El NIT o Cédula es obligatorio")]
        public string NitCedula { get; set; } = string.Empty;
        [Required(ErrorMessage = "La persona de contacto es obligatoria")]
        public string PersonaContacto { get; set; } = string.Empty;
        public string CargoContacto { get; set; } = string.Empty;
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress]
        public string correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Telefono { get; set; } = string.Empty;

        public string? Direccion { get; set; }

        public string? Ciudad { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; }

        public int TotalCotizaciones { get; set; }
    }
}