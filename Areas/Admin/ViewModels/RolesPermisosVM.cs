using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class RolesPermisosVM
    {
        public int id { get; set; }

        public string? descripcion { get; set; }

        public List<PermisoProcesoVM> permisos { get; set; } = new();
    }
}
