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
        [Required, StringLength(25)] public string Cedula { get; set; } = string.Empty;
        [Required, StringLength(25)] public string Telefono { get; set; } = string.Empty;
        [StringLength(200)] public string? correo { get; set; }
        [Required, StringLength(25)] public string NumeroLicencia { get; set; } = string.Empty;
        [Required, StringLength(10)] public string CategoriaLicencia { get; set; } = string.Empty;
        public DateTime FechaExpedicionLicencia { get; set; }
        public DateTime FechaVencimientoLicencia { get; set; }
        [StringLength(100)]
        public string? OrganismoTransitoExpideLicencia { get; set; }
        [StringLength(200)]
        public string? RestriccionesLicencia { get; set; }
        public bool TieneRetencionLicencia { get; set; }
        [StringLength(500)]
        public string? RetencionLicencia { get; set; }
        [StringLength(100)]
        public string? OrganismoTransitoCancelaLicencia { get; set; }
        [StringLength(50)]
        public EstadoLicencia EstadoLicencia { get; set; }
        [StringLength(10)]
        public string? CategoriaLicenciaAnterior { get; set; }
        [StringLength(50)]
        public string? NumeroInscripcion { get; set; }
        public DateTime? FechaInscripcion { get; set; }
        public TipoProveedor TipoProveedor { get; set; } = TipoProveedor.Interno;
        [StringLength(150)] public string? RazonSocialExterna { get; set; }
        [StringLength(25)] public string? NitExterno { get; set; }
        [Column(TypeName = "decimal(12,2)")] public decimal? TarifaExterna { get; set; }
        [StringLength(500)] public string? ObservacionesExterno { get; set; }
        public bool Activo { get; set; } = true;
        public EstadoPersona EstadoPersona { get; set; }
        public EstadoConductor EstadoConductor { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public ICollection<Servicios> Servicios { get; set; } = new List<Servicios>();
        [NotMapped] public bool LicenciaVigente => FechaVencimientoLicencia >= DateTime.Today;
        [NotMapped] public bool EsExterno => TipoProveedor == TipoProveedor.Externo;

    }
}
