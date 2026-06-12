using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    
    public class Vehiculos
    {
        [Key]
        public int idVehiculo { get; set; }

        [Required, StringLength(12)]
        public string Placa { get; set; } = string.Empty;

        [Required, StringLength(60)]
        public string Marca { get; set; } = string.Empty;

        [Required, StringLength(60)]
        public string Modelo { get; set; } = string.Empty;

        public int Anio { get; set; }

        [StringLength(60)]
        public string? Linea { get; set; }

        [StringLength(30)]
        public string? Color { get; set; }

        [StringLength(50)]
        public string? ClaseVehiculo { get; set; }

        [StringLength(50)]
        public string? TipoServicio { get; set; }

        [StringLength(50)]
        public string? ModalidadServicio { get; set; }

        [StringLength(50)]
        public string? ModalidadTransporte { get; set; }

        public int? CapacidadPasajeros { get; set; }

        public int? CapacidadPasajerosSentados { get; set; }

        [Column(TypeName = "decimal(10,2)")] public decimal? CapacidadCarga { get; set; }

        [Column(TypeName = "decimal(10,2)")] public decimal? PesoBrutoVehicular { get; set; }

        public int? NumeroEjes { get; set; }

        public int? Puertas { get; set; }

        public EstadoVehiculo Estado { get; set; }

        public TipoProveedor TipoProveedor { get; set; }

        public bool ClasicoAntiguo { get; set; }

        public bool Repotenciado { get; set; }

        public bool VehiculoEnsenanza { get; set; }

        [StringLength(1000)] public string? Observaciones { get; set; }

        // Relaciones
        public int idTipoVehiculo { get; set; }

        [ForeignKey(nameof(idTipoVehiculo))]
        public TiposVehiculos? TipoVehiculo { get; set; }

        public VehiculoCaracteristicas? Caracteristicas { get; set; }

        public VehiculoMatricula? Matricula { get; set; }

        public VehiculoPropietario? Propietario { get; set; }

        public VehiculoSOAT? SOAT { get; set; }

        public VehiculoPolizaRC? PolizaRC { get; set; }

        public VehiculoRTM? RTM { get; set; }

        public VehiculoTarjetaOperacion? TarjetaOperacion { get; set; }

        public VehiculoBlindaje? Blindaje { get; set; }

        public VehiculoRegrabaciones? Regrabaciones { get; set; }

        public ICollection<Servicios> Servicios { get; set; } = new List<Servicios>();
    }
}
