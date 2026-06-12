using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Comercial.Models
{
    public class Clientes
    {
        [Key]
        public int idCliente { get; set; }
        [Required, StringLength(150)] public string RazonSocial { get; set; } = string.Empty;
        [Required, StringLength(30)] public string NitCedula { get; set; } = string.Empty;
        [Required, StringLength(200)] public string PersonaContacto { get; set; } = string.Empty;
        [Required, StringLength(200)] public string CargoContacto { get; set; } = string.Empty;
        [Required, StringLength(200)] public string Correo { get; set; } = string.Empty;
        [Required, StringLength(25)] public string Telefono { get; set; } = string.Empty;
        [StringLength(250)] public string? Direccion { get; set; }
        [StringLength(100)] public string? Ciudad { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public ICollection<Cotizaciones> Cotizaciones { get; set; } = new List<Cotizaciones>();
    }

}
