using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class TiposVehiculosVM
    {
        public int? id { get; set; }
        public string? descripcion { get; set; }
    }
}
