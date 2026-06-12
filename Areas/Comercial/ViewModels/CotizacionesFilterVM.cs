using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.Areas.Comercial.ViewModels;
using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Models;

public class CotizacionesFilterVM : PaginationVM
{
    public string? Search { get; set; } 
    public EstadoCotizacion? Estado { get; set; }
}