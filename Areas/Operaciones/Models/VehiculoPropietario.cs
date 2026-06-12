using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoPropietario
    {
        [Key]
        public int idPropietario { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public string? Nombre { get; set; }

        public string? Cedula { get; set; }

        public string? Telefono { get; set; }

        public string? Correo { get; set; }

        public decimal? TarifaExterna { get; set; }
    }
}