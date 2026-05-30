
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class PermisoRolVM
    {
        public int idRol { get; set; }

        public string? nombreRol { get; set; }

        public List<AreaPermisoVM> areas { get; set; } = new List<AreaPermisoVM>();
    }

}
