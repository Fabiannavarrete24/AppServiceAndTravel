using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoMatricula
    {
        [Key]
        public int idMatricula { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public string? LicenciaTransito { get; set; }

        public DateTime? FechaMatriculaInicial { get; set; }

        public string? AutoridadTransito { get; set; }

        public string? GravamenesPropiedad { get; set; }
    }
}