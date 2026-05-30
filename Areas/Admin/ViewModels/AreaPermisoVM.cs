namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class AreaPermisoVM
    {
        public string? area { get; set; }

        public bool expandido { get; set; }

        public List<ProcesoPermisoVM> procesos { get; set; } = new();
    }

}
