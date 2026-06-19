using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Helpers.Filters
{
    public class VehiculosFilterVM
    {
        public string? Busqueda { get; set; }

        public EstadoVehiculo? Estado { get; set; }

        public int Page { get; set; } = 1;

        public int PageSize { get; set; } = 10;
    }
}