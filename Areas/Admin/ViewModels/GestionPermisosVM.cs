namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class GestionPermisosVM
    {
        public List<RolItemVM> Roles { get; set; } = new();
        public List<AreaPermisoVM> Areas { get; set; } = new();
        public int RolSeleccionado { get; set; }
    }




}
