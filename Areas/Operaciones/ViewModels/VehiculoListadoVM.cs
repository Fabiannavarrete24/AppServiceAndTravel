using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class VehiculoListadoVM
    {
        public int idVehiculo { get; set; }

        public string Placa { get; set; } = string.Empty;

        public string Marca { get; set; } = string.Empty;

        public string Modelo { get; set; } = string.Empty;

        public int? CapacidadPasajeros { get; set; }

        public EstadoVehiculo Estado { get; set; }

        public DateTime? SoatVence { get; set; }

        public DateTime? RtmVence { get; set; }

        public DateTime? TarjetaOperacionVence { get; set; }

        public bool TieneAlertas =>
            (SoatVence.HasValue && SoatVence <= DateTime.Today.AddDays(30))
            ||
            (RtmVence.HasValue && RtmVence <= DateTime.Today.AddDays(30))
            ||
            (TarjetaOperacionVence.HasValue &&
             TarjetaOperacionVence <= DateTime.Today.AddDays(30));
    }
}