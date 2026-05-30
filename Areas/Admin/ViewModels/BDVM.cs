using System.ComponentModel.DataAnnotations;
namespace AppServiceAndTravel.Areas.Admin.ViewModels
{
    public class BDVM
    {
        public string? Proveedor { get; set; }
        public string? Cadena { get; set; }
        public DateTime UltimaModificacion { get; set; }
        
    }
}