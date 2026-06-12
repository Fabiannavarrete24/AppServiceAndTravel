using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoCaracteristicas
    {
        [Key]
        public int idCaracteristica { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public string? NumeroSerie { get; set; }

        public string? NumeroMotor { get; set; }

        public string? NumeroChasis { get; set; }

        public string? NumeroVIN { get; set; }

        public string? Cilindraje { get; set; }

        public string? TipoCarroceria { get; set; }

        public string? TipoCombustible { get; set; }
    }
}