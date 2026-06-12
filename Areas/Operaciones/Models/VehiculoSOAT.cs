using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoSOAT
    {
        [Key]
        public int idSOAT { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public string? NumeroPoliza { get; set; }

        public DateTime? FechaExpedicion { get; set; }

        public DateTime? FechaInicioVigencia { get; set; }

        public DateTime? FechaFinVigencia { get; set; }

        public string? EntidadExpide { get; set; }

        public string? Estado { get; set; }

        public string? RutaDocumento { get; set; }
    }
}