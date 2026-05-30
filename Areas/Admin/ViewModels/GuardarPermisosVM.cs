
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class GuardarPermisosVM
    {
        public int idRol { get; set; }
        public List<PermisoItemVM> permisos { get; set; } = new();
    }


}
