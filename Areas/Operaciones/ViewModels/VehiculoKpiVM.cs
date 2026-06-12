namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class VehiculoKpiVM
    {
        public int Activos { get; set; }

        public int Inactivos { get; set; }

        public int Mantenimiento { get; set; }

        public int ConAlertas { get; set; }

        public int Total => Activos + Inactivos + Mantenimiento;
    }
}