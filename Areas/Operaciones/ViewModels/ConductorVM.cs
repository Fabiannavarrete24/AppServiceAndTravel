using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class ConductorVM
    {
        public int idConductor { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.CC;
        public int Vigencia { get; set; } = 0;
        public string Cedula { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string? Correo { get; set; }
        public string NumeroLicencia { get; set; } = string.Empty;
        public TipoLicencia CategoriaLicencia { get; set; }
        public string? CategoriaLicenciaAnterior { get; set; }
        public DateTime? FechaExpedicionLicencia { get; set; }
        public DateTime? FechaVencimientoLicencia { get; set; }
        public string? OrganismoExpide { get; set; }
        public EstadoLicencia EstadoLicencia { get; set; }
        public TipoProveedor TipoConductor { get; set; }
        public string? RazonSocialExterna { get; set; }
        public string? NitExterno { get; set; }
        public decimal? TarifaExterna { get; set; }
        public string? ObservacionesExterno { get; set; }
        public EstadoPersona EstadoPersona { get; set; }
        public bool EstadoConductor { get; set; } = false;
        public bool Activo { get; set; } = true;
        public string? RestriccionesLicencia { get; set; }
    }
}