namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class ProcesoPermisoVM
    {
        public int idProceso { get; set; }

        public string? proceso { get; set; }

        public string? area { get; set; }

        public string? icono { get; set; }

        public int? idProcesoPadre { get; set; }

        public bool lectura { get; set; }

        public bool crea { get; set; }

        public bool edita { get; set; }

        public bool elimina { get; set; }
        public string? controlador { get; set; }

        public string? url { get; set; }

        public int nivel { get; set; }

        public bool deny { get; set; }

        public bool hereda { get; set; }

        public bool apiAccess { get; set; }

        public string? claims { get; set; }

        public List<ProcesoPermisoVM> hijos { get; set; } = new();
    }

}
