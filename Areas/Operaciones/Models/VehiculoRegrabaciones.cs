using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoRegrabaciones
    {
        [Key]
        public int idRegrabacion { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public bool RegrabacionMotor { get; set; }
        public string? NumeroRegrabacionMotor { get; set; }

        public bool RegrabacionChasis { get; set; }
        public string? NumeroRegrabacionChasis { get; set; }

        public bool RegrabacionSerie { get; set; }
        public string? NumeroRegrabacionSerie { get; set; }

        public bool RegrabacionVIN { get; set; }
        public string? NumeroRegrabacionVIN { get; set; }
    }
}