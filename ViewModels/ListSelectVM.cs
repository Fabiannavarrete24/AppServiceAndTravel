using AppServiceAndTravel.Areas.Operaciones.ViewModels;

namespace AppServiceAndTravel.ViewModels
{
    public class ListSelectVM
    {
        public List<ComboVM> TiposServicio { get; set; } = [];
        public List<ComboVM> Estados { get; set; } = [];
        public List<ComboVM> TiposVehiculo { get; set; } = [];
        public List<ComboVM> CategoriasVehiculo { get; set; } = [];
        public List<ComboVM> TiposDocumento { get; set; } = [];
        public List<ComboVM> TiposLicencia { get; set; } = [];
    }
}