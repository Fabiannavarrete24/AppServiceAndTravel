using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class VehiculoRTM
    {
        [Key]
        public int idRTM { get; set; }

        public int idVehiculo { get; set; }

        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }

        public string? TipoRevision { get; set; }

        public DateTime? FechaExpedicion { get; set; }

        public DateTime? FechaVigencia { get; set; }

        public string? CDAExpide { get; set; }

        public string? NumeroCertificado { get; set; }

        public string? Estado { get; set; }

        public string? RutaDocumento { get; set; }
    }
}