using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{

    public class Conductores
    {
        [Key]

        public int idConductor { get; set; }
        [Required, StringLength(150)] public string NombreCompleto { get; set; } = string.Empty;
        [Required, StringLength(25)] public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.CC;
        [Required, StringLength(25)] public string Cedula { get; set; } = string.Empty;
        [Required, StringLength(25)] public string Telefono { get; set; } = string.Empty;
        [StringLength(200)] public string? correo { get; set; }
        [Required, StringLength(25)] public string NumeroLicencia { get; set; } = string.Empty;
        [Required, StringLength(10)] public TipoLicencia CategoriaLicencia { get; set; }
        public DateTime FechaExpedicionLicencia { get; set; }
        public DateTime FechaVencimientoLicencia { get; set; }
        [StringLength(100)] public string? OrganismoExpide { get; set; }
        [StringLength(200)] public string? RestriccionesLicencia { get; set; }
        [StringLength(50)] public EstadoLicencia EstadoLicencia { get; set; }
        [StringLength(50)] public TipoProveedor TipoProveedor { get; set; } = TipoProveedor.Interno;
        public bool Activo { get; set; } = true;
        public int Vigencia { get; set; } = 0;
        public EstadoConductor EstadoConductor { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public ICollection<Servicios> Servicios { get; set; } = new List<Servicios>();
        [NotMapped] public bool LicenciaVigente => FechaVencimientoLicencia >= DateTime.Today;
        [NotMapped] public bool EsExterno => TipoProveedor == TipoProveedor.Externo;

    }
}
