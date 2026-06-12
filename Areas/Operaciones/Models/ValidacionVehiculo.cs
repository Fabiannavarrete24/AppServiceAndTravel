using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{    
    public class ValidacionVehiculo
    {
        [Key]
        public int idValidacionVehiculo { get; set; }
        public int idVehiculo { get; set; }
        public Vehiculos? Vehiculo { get; set; }
        public int? idServicio { get; set; }
        public DateTime FechaValidacion { get; set; } = DateTime.Now;
        public bool SOATVigente { get; set; }
        public bool TecnoVigente { get; set; }
        public bool SeguroVigente { get; set; }
        public bool EstadoActivo { get; set; }
        public bool LicenciaConductorVigente { get; set; }
        public bool Resultado { get; set; }
        [StringLength(200)] public string? Observaciones { get; set; }
        [StringLength(200)] public string? UsuarioId { get; set; }
    }
}
