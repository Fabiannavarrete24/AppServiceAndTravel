using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class VehiculoDetalleVM
    {

        // General
        public int idVehiculo { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Linea { get; set; } = string.Empty;

        // Propietario
        public string? NombrePropietario { get; set; }
        public string? CedulaPropietario { get; set; }
        public string? TelefonoPropietario { get; set; }

        // Características
        public string? NumeroVIN { get; set; }
        public string? NumeroMotor { get; set; }
        public string? NumeroChasis { get; set; }
        public string? NumeroSerie { get; set; }

        // Matrícula
        public string? LicenciaTransito { get; set; }
        public DateTime? FechaMatriculaInicial { get; set; }
        public string? AutoridadTransito { get; set; }

        // SOAT
        public string? SoatNumeroPoliza { get; set; }
        public string? SoatEntidadExpide { get; set; }
        public string? SoatEstado { get; set; }
        public DateTime? SoatFechaExpedicion { get; set; }
        public DateTime? SoatFechaInicioVigencia { get; set; }
        public DateTime? SoatFechaFinVigencia { get; set; }

        // Póliza RC
        public string? PolizaNumero { get; set; }
        public string? PolizaTipo { get; set; }
        public string? PolizaEntidadExpide { get; set; }
        public DateTime? PolizaFechaExpedicion { get; set; }
        public DateTime? PolizaFechaInicioVigencia { get; set; }
        public DateTime? PolizaFechaFinVigencia { get; set; }
        public string? PolizaEstado { get; set; }

        // RTM
        public string? RtmTipoRevision { get; set; }
        public string? RtmNumeroCertificado { get; set; }
        public string? RtmCDAExpide { get; set; }
        public DateTime? RtmFechaExpedicion { get; set; }
        public DateTime? RtmFechaVigencia { get; set; }
        public string? RtmEstado { get; set; }

        // Tarjeta Operación
        public string? EmpresaAfiliadora { get; set; }
        public string? RadioAccion { get; set; }
        public string? NumeroTarjetaOperacion { get; set; }
        public DateTime? FechaExpedicionTarjeta { get; set; }
        public DateTime? FechaInicioVigenciaTarjeta { get; set; }
        public DateTime? FechaFinVigenciaTarjeta { get; set; }
        public string? EstadoTarjetaOperacion { get; set; }

        // Blindaje
        public bool Blindado { get; set; } = false;

        // Regrabaciones
        public string? RegrabacionMotor { get; set; }
        public string? RegrabacionChasis { get; set; }
        public string? RegrabacionSerie { get; set; }
        public string? RegrabacionVIN { get; set; }
        // Indicadores visuales
        public bool? SoatVigente { get; set; } = false;
        public bool? PolizaVigente { get; set; } = false;
        public bool? RtmVigente { get; set; } = false;
        public bool? TarjetaOperacionVigente { get; set; } = false;
        // Vehículo

        public int TipoServicio { get; set; }
        public string? ModalidadServicio { get; set; }
        public string? ModalidadTransporte { get; set; }

        public int? CapacidadPasajeros { get; set; }
        public int? CapacidadPasajerosSentados { get; set; }

        public decimal? CapacidadCarga { get; set; }
        public decimal? PesoBrutoVehicular { get; set; }

        public int? NumeroEjes { get; set; }
        public int? Puertas { get; set; }

        public EstadoVehiculo Estado { get; set; }
        public TipoProveedor TipoProveedor { get; set; }

        public bool ClasicoAntiguo { get; set; } = false;
        public bool Repotenciado { get; set; } = false;
        public bool VehiculoEnsenanza { get; set; } = false;

        public string? Observaciones { get; set; }

        public int TipoVehiculo { get; set; }

        // SOAT
        public DateTime? SoatFechaVencimiento { get; set; }

        // Póliza RC
        public string? PolizaEntidad { get; set; }
        public DateTime? PolizaFechaInicio { get; set; }
        public DateTime? PolizaFechaFin { get; set; }

    }
}