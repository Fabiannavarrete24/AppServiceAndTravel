using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class ConductorVM
    {
        public int idConductor { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string? Correo { get; set; }

        public string NumeroLicencia { get; set; } = string.Empty;
        public string CategoriaLicencia { get; set; } = string.Empty;
        public string? CategoriaLicenciaAnterior { get; set; }

        public DateTime? FechaExpedicionLicencia { get; set; }
        public DateTime? FechaVencimientoLicencia { get; set; }

        public string? OrganismoTransitoExpideLicencia { get; set; }
        public string? RestriccionesLicencia { get; set; }

        public bool TieneRetencionLicencia { get; set; }
        public string? RetencionLicencia { get; set; }

        public string? OrganismoTransitoCancelaLicencia { get; set; }

        public EstadoLicencia EstadoLicencia { get; set; }

        public TipoProveedor TipoProveedor { get; set; }

        public string? RazonSocialExterna { get; set; }
        public string? NitExterno { get; set; }
        public decimal? TarifaExterna { get; set; }
        public string? ObservacionesExterno { get; set; }

        public EstadoPersona EstadoPersona { get; set; }
        public EstadoConductor EstadoConductor { get; set; }

        public bool Activo { get; set; } = true;
    }
}