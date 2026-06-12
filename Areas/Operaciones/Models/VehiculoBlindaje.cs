using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoBlindaje
    {
        [Key]
        public int idBlindaje { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public bool Blindado { get; set; }

        public string? NivelBlindaje { get; set; }

        public DateTime? FechaBlindaje { get; set; }

        public DateTime? FechaDesblindaje { get; set; }
    }
}