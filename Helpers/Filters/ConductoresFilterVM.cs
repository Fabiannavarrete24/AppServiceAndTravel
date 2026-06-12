using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Helpers.Filters
{
    public class ConductoresFilterVM
    {
        public string? Busqueda { get; set; }

        public TipoProveedor? Tipo { get; set; }

        public int Pagina { get; set; } = 1;

        public int TotalPaginas { get; set; }

        public int TotalRegistros { get; set; }

        public List<Conductores> Conductores { get; set; } = [];
    }
}