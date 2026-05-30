namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class PermisoProcesoVM
    {
        public int idProceso { get; set; }

        public string? proceso { get; set; }

        public string? area { get; set; }

        public bool lectura { get; set; }

        public bool crea { get; set; }

        public bool edita { get; set; }

        public bool elimina { get; set; }
    }

}
