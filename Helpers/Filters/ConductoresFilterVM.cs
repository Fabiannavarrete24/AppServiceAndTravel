using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Helpers.Filters
{
    public class ConductoresFilterVM
    {
        public string? Busqueda { get; set; }

        public TipoProveedor? Tipo { get; set; }

        public int Page { get; set; } = 1;

        public int PageSize { get; set; } = 10;
    }
}