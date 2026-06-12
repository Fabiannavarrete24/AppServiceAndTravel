using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class ConductorListadoVM
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = "";

        public string Cedula { get; set; } = "";

        public string Telefono { get; set; } = "";

        public string Correo { get; set; } = "";

        public string NumeroLicencia { get; set; } = "";

        public DateTime? FechaVencimientoLicencia { get; set; }

        public bool Activo { get; set; }

        public TipoProveedor TipoProveedor { get; set; }
    }
}