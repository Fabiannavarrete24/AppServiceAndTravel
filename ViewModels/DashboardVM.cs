using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.ViewModels
{
public class DashboardVM
{

    public decimal IngresosTotales { get; set; }
    public decimal CostosOperativos { get; set; }
    public decimal UtilidadNeta { get; set; }
    public decimal MargenUtilidad => IngresosTotales <= 0 ? 0 : Math.Round((UtilidadNeta / IngresosTotales) * 100, 2);
    public decimal MargenUtilidadAnterior => IngresosAnioAnterior <= 0 ? 0 : Math.Round( (UtilidadAnioAnterior / IngresosAnioAnterior) * 100, 2 );
    public decimal IngresosAnioAnterior { get; set; }
    public decimal CostosAnioAnterior { get; set; }
    public decimal UtilidadAnioAnterior { get; set; }
    public decimal ServiciosAnioAnterior { get; set; }
    public decimal CotizacionesAnioAnterior { get; set; }
    public decimal VariacionIngresos { get; set; }
    public decimal VariacionCostos { get; set; }
    public decimal VariacionUtilidad { get; set; }
    public decimal VariacionServicios { get; set; }
    public decimal VariacionCotizaciones { get; set; }
    public int TotalCotizaciones { get; set; }
    public int CotizacionesPendientes { get; set; }
    public int CotizacionesAprobadas { get; set; }
    public int CotizacionesRechazadas { get; set; }
    public decimal TasaConversionCotizaciones => TotalCotizaciones <= 0 ? 0 : Math.Round( (decimal)CotizacionesAprobadas / TotalCotizaciones * 100, 2);
    public int TotalServicios { get; set; }
    public int ServiciosEnCurso { get; set; }
    public int ServiciosPendientes { get; set; }
    public int ServiciosFinalizados { get; set; }
    public List<string> Meses { get; set; } = [];
    public List<decimal> IngresosMensuales { get; set; } = [];
    public List<decimal> CostosMensuales { get; set; } = [];
    public List<decimal> UtilidadMensual { get; set; } = [];
    public List<int> ServiciosSemanal { get; set; } = [];
    public List<decimal> IngresosSemanal { get; set; } = [];
    public List<string> TiposServicio { get; set; } = [];
    public List<decimal> IngresosPorTipo { get; set; } = [];
    public List<ActividadRecienteVM> Actividades { get; set; } = [];
}
}


