using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{
    public enum TipoProveedor { Interno, Externo }
    public class Vehiculo
    {
        [Key]
        public int idVehiculo { get; set; }
        [Required, StringLength(12)] public string Placa { get; set; } = string.Empty;
        [Required, StringLength(60)] public string Marca { get; set; } = string.Empty;
        [Required, StringLength(60)] public string Modelo { get; set; } = string.Empty;
        public int Anio { get; set; }
        public int CapacidadPasajeros { get; set; }
        [Column(TypeName = "decimal(10,2)")] public decimal CapacidadCarga { get; set; }
        public EstadoVehiculo Estado { get; set; } = EstadoVehiculo.Activo;
        public TipoProveedor TipoProveedor { get; set; } = TipoProveedor.Interno;

        [StringLength(150)] public string? PropietarioNombre { get; set; }
        [StringLength(25)] public string? PropietarioCedula { get; set; }
        [StringLength(25)] public string? PropietarioTelefono { get; set; }
        [StringLength(200)] public string? Propietariocorreo { get; set; }
        [Column(TypeName = "decimal(12,2)")] public decimal? TarifaExterna { get; set; }

        public DateTime FechaVencimientoSOAT { get; set; }
        public DateTime FechaVencimientoTecnoMecanica { get; set; }
        public DateTime FechaVencimientoSeguro { get; set; }
        [StringLength(200)] public string? RutaSOAT { get; set; }
        [StringLength(200)] public string? RutaTecnoMecanica { get; set; }
        [StringLength(200)] public string? RutaSeguro { get; set; }
        [StringLength(1000)] public string? Observaciones { get; set; }

        public ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

        [NotMapped] public bool SOATVigente => FechaVencimientoSOAT >= DateTime.Today;
        [NotMapped] public bool TecnoVigente => FechaVencimientoTecnoMecanica >= DateTime.Today;
        [NotMapped] public bool SeguroVigente => FechaVencimientoSeguro >= DateTime.Today;
        [NotMapped] public bool DocumentosOk => SOATVigente && TecnoVigente && SeguroVigente;
        [NotMapped] public bool EsExterno => TipoProveedor == TipoProveedor.Externo;
    }
}
