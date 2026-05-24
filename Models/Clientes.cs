using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class Clientes
    {
        [Key]
        public int idCliente { get; set; }
        [Required, StringLength(150)] public string NombreCompleto { get; set; } = string.Empty;
        [Required, StringLength(30)] public string NitCedula { get; set; } = string.Empty;
        [Required, StringLength(200)] public string correo { get; set; } = string.Empty;
        [Required, StringLength(25)] public string Telefono { get; set; } = string.Empty;
        [StringLength(250)] public string? Direccion { get; set; }
        [StringLength(100)] public string? Ciudad { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public ICollection<Cotizaciones> Cotizaciones { get; set; } = new List<Cotizaciones>();
    }

}
