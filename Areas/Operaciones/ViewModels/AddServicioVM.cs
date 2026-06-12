namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class AddServicioVM
    {
        public int idDetalleCotizacion { get; set; }

        public int idVehiculo { get; set; }

        public int idConductor { get; set; }

        public DateTime FechaServicio { get; set; }

        public string? Observaciones { get; set; }
    }
}