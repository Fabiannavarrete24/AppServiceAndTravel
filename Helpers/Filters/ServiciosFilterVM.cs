using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Helpers.Filters
{
    public class ServiciosFilterVM
{
    public EstadoServicio? Estado { get; set; }

    public string? Busqueda { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? idVehiculo { get; set; }

    public int? idConductor { get; set; }

    public int? idCliente { get; set; }

    public int Pagina { get; set; } = 1;

    public int RegistrosPorPagina { get; set; } = 10;
}
}