namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class ConductoresResponseVM
    {
        public int TotalRegistros { get; set; }

        public int TotalPaginas { get; set; }

        public int PaginaActual { get; set; }

        public int Total { get; set; }

        public int Internos { get; set; }

        public int Externos { get; set; }

        public int LicenciasVencidas { get; set; }

        public List<ConductorListadoVM> Conductores { get; set; } = [];
    }
}