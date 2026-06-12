using static AppServiceAndTravel.Services.AuthService;

namespace AppServiceAndTravel.ViewModels
{
    public class MenuVM
    {
        public int idProceso { get; set; }

        public string? proceso { get; set; }

        public string? area { get; set; }

        public string? controlador { get; set; }

        public string? url { get; set; }

        public string? icono { get; set; }

        public int? idProcesoPadre { get; set; }
        public int? orden { get; set; }

        public List<MenuVM> hijos { get; set; } = new();
    }
}
