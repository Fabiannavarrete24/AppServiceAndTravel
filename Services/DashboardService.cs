using AppServiceAndTravel.Areas.Admin.ViewModels;
using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using AppServiceAndTravel.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace AppServiceAndTravel.Services
{
    public interface IDashboardService
    {
        Task<DashboardVM> ObtenerDashboard();
    }

    public class DashboardService : IDashboardService
    {
        private readonly ApplicationDBContext _context;

        public DashboardService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<DashboardVM> ObtenerDashboard()
        {
            var year = DateTime.Now.Year;

            var dashboard = new DashboardVM();

            // =========================================================
            // KPIs GENERALES
            // =========================================================

            dashboard.IngresosTotales = await _context.Cotizaciones
                .Where(x =>
                    x.Estado == EstadoCotizacion.Aprobada &&
                    x.ValorAprobado != null)
                .SumAsync(x => x.ValorAprobado ?? 0);

            dashboard.IngresosAnioAnterior = await _context.Cotizaciones
                .Where(x =>
                    x.Estado == EstadoCotizacion.Aprobada &&
                    x.ValorAprobado != null &&
                    x.FechaCreacion.Year == year - 1)
                .SumAsync(x => x.ValorAprobado ?? 0);

            dashboard.CostosAnioAnterior = await _context.Servicios
                .Where(x =>
                    x.CostoExterno != null &&
                    x.FechaCreacion.Year == year - 1)
                .SumAsync(x => x.CostoExterno ?? 0);

            dashboard.UtilidadAnioAnterior =
                dashboard.IngresosAnioAnterior -
                dashboard.CostosAnioAnterior;

            dashboard.ServiciosAnioAnterior =
                await _context.Servicios
                    .CountAsync(x =>
                        x.FechaCreacion.Year == year - 1);

            dashboard.CotizacionesAnioAnterior =
                await _context.Cotizaciones
                    .CountAsync(x =>
                        x.FechaCreacion.Year == year - 1);

            dashboard.VariacionUtilidad =
                dashboard.UtilidadAnioAnterior <= 0
                    ? 100
                    : Math.Round(
                        (
                            (dashboard.UtilidadNeta -
                            dashboard.UtilidadAnioAnterior)
                            /
                            dashboard.UtilidadAnioAnterior
                        ) * 100,
                        2
                    );

            dashboard.VariacionCotizaciones =
                dashboard.CotizacionesAnioAnterior <= 0
                    ? 100
                    : Math.Round(
                        (
                            (dashboard.TotalCotizaciones -
                            dashboard.CotizacionesAnioAnterior)
                            /
                            dashboard.CotizacionesAnioAnterior
                        ) * 100,
                        2
                    );

            dashboard.CostosOperativos = await _context.Servicios
                .Where(x => x.CostoExterno != null)
                .SumAsync(x => x.CostoExterno ?? 0);

            dashboard.UtilidadNeta =
                dashboard.IngresosTotales -
                dashboard.CostosOperativos;

            var ingresosAnterior = await _context.Cotizaciones
                .Where(x =>
                    x.Estado == EstadoCotizacion.Aprobada &&
                    x.FechaCreacion.Year == year - 1)
                .SumAsync(x => x.ValorAprobado ?? 0);

            dashboard.VariacionIngresos =
                ingresosAnterior <= 0
                    ? 100
                    : Math.Round(
                        ((dashboard.IngresosTotales - ingresosAnterior)
                        / ingresosAnterior) * 100, 2);
                        
            var costosAnterior = await _context.Servicios
                .Where(x =>
                    x.FechaCreacion.Year == year - 1)
                .SumAsync(x => x.CostoExterno ?? 0);

            dashboard.VariacionCostos =
                costosAnterior <= 0
                    ? 100
                    : Math.Round(
                        ((dashboard.CostosOperativos - costosAnterior)
                        / costosAnterior) * 100, 2);

            var serviciosAnterior = await _context.Servicios
                .CountAsync(x =>
                    x.FechaCreacion.Year == year - 1);

            dashboard.VariacionServicios =
                serviciosAnterior <= 0
                    ? 100
                    : Math.Round(
                        ((dashboard.TotalServicios - serviciosAnterior)
            / (decimal)serviciosAnterior) * 100, 2);                        

            // =========================================================
            // COTIZACIONES
            // =========================================================

            dashboard.TotalCotizaciones =
                await _context.Cotizaciones.CountAsync();

            dashboard.CotizacionesPendientes =
                await _context.Cotizaciones
                    .CountAsync(x =>
                        x.Estado == EstadoCotizacion.Pendiente);

            dashboard.CotizacionesAprobadas =
                await _context.Cotizaciones
                    .CountAsync(x =>
                        x.Estado == EstadoCotizacion.Aprobada);

            dashboard.CotizacionesRechazadas =
                await _context.Cotizaciones
                    .CountAsync(x =>
                        x.Estado == EstadoCotizacion.Rechazada);

            // =========================================================
            // SERVICIOS
            // =========================================================

            dashboard.TotalServicios =
                await _context.Servicios.CountAsync();

            dashboard.ServiciosEnCurso =
                await _context.Servicios
                    .CountAsync(x =>
                        x.Estado == EstadoServicio.EnCurso);

            dashboard.ServiciosPendientes =
                await _context.Servicios
                    .CountAsync(x =>
                        x.Estado == EstadoServicio.Pendiente);

            dashboard.ServiciosFinalizados =
                await _context.Servicios
                    .CountAsync(x =>
                        x.Estado == EstadoServicio.Finalizado);
            // =========================================================
            // INGRESOS VS COSTOS MENSUALES
            // =========================================================

            dashboard.Meses = Enumerable.Range(1, 12)
                .Select(x =>
                    CultureInfo.CurrentCulture
                        .DateTimeFormat
                        .GetAbbreviatedMonthName(x))
                .ToList();

            for (int mes = 1; mes <= 12; mes++)
            {
                // INGRESOS
                var ingresos = await _context.Cotizaciones
                    .Where(x =>
                        x.Estado == EstadoCotizacion.Aprobada &&
                        x.FechaCreacion.Year == year &&
                        x.FechaCreacion.Month == mes)
                    .SumAsync(x => x.ValorAprobado ?? 0);

                // COSTOS
                var costos = await _context.Servicios
                    .Where(x =>
                        x.FechaCreacion.Year == year &&
                        x.FechaCreacion.Month == mes)
                    .SumAsync(x => x.CostoExterno ?? 0);

                dashboard.IngresosMensuales.Add(ingresos);

                dashboard.CostosMensuales.Add(costos);

                dashboard.UtilidadMensual.Add(
                    ingresos - costos
                );
            }

            // =========================================================
            // TENDENCIA SEMANAL (ULTIMAS 8 SEMANAS)
            // =========================================================

            for (int i = 7; i >= 0; i--)
            {
                var start = DateTime.Now.Date.AddDays(-7 * i);

                var end = start.AddDays(7);

                var serviciosSemana = await _context.Servicios
                    .CountAsync(x =>
                        x.FechaCreacion >= start &&
                        x.FechaCreacion < end);

                var ingresosSemana = await _context.Cotizaciones
                    .Where(x =>
                        x.Estado == EstadoCotizacion.Aprobada &&
                        x.FechaCreacion >= start &&
                        x.FechaCreacion < end)
                    .SumAsync(x => x.ValorAprobado ?? 0);

                dashboard.ServiciosSemanal
                    .Add(serviciosSemana);

                dashboard.IngresosSemanal
                    .Add(ingresosSemana);
            }

            // =========================================================
            // INGRESOS POR TIPO DE SERVICIO
            // =========================================================

            var ingresosPorTipo = await _context.Cotizaciones
                .Include(x => x.TipoServicio)
                .Where(x =>
                    x.Estado == EstadoCotizacion.Aprobada &&
                    x.idTipoServicio != null)
                .GroupBy(x => x.TipoServicio!.descripcion)
                .Select(g => new
                {
                    TipoServicio = g.Key,
                    Total = g.Sum(x => x.ValorAprobado ?? x.ValorCotizado)
                })
                .OrderByDescending(x => x.Total)
                .ToListAsync();

            dashboard.TiposServicio = ingresosPorTipo
                .Select(x => x.TipoServicio)
                .ToList();

            dashboard.IngresosPorTipo = ingresosPorTipo
                .Select(x => x.Total)
                .ToList();

            // =========================================================
            // ACTIVIDAD RECIENTE
            // =========================================================

            var cotizacionesRecientes = await _context.Cotizaciones
                .OrderByDescending(x => x.FechaCreacion)
                .Take(5)
                .Select(x => new ActividadRecienteVM
                {
                    Tipo = "Cotización",

                    Descripcion =
                        $"Cotización #{x.idCotizacion} - {x.Estado}",

                    Fecha = x.FechaCreacion
                })
                .ToListAsync();

            var serviciosRecientes = await _context.Servicios
                .Include(x => x.Vehiculo)
                .OrderByDescending(x => x.FechaCreacion)
                .Take(5)
                .Select(x => new ActividadRecienteVM
                {
                    Tipo = "Servicio",

                    Descripcion =
                        $"Servicio #{x.idServicio} - " +
                        $"{x.Vehiculo!.Placa}",

                    Fecha = x.FechaCreacion
                })
                .ToListAsync();

            dashboard.Actividades = cotizacionesRecientes
                .Concat(serviciosRecientes)
                .OrderByDescending(x => x.Fecha)
                .Take(10)
                .ToList();

            return dashboard;
        }
    }
}