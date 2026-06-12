using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoTarjetaOperacion
    {
        [Key]
        public int idTarjetaOperacion { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public string? EmpresaAfiliadora { get; set; }

        public string? RadioAccion { get; set; }

        public string? NumeroTarjetaOperacion { get; set; }

        public DateTime? FechaExpedicion { get; set; }

        public DateTime? FechaInicioVigencia { get; set; }

        public DateTime? FechaFinVigencia { get; set; }

        public string? Estado { get; set; }
    }
}