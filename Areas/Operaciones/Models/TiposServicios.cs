using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.Models
{
    public class TiposServicios
    {
        [Key]
        public int idTipoServicio{get;set;}
        public string descripcion {get;set;} = string.Empty;
        public DateTime fechaCreacion {get;set;} = DateTime.UtcNow;
        public int idUsuarioModifica {get;set;}
        [ForeignKey(nameof(idUsuarioModifica))]
        public ApplicationUser?  usuario {get;set;}
        public ICollection<Servicios>? servicios {get;set;} = new List<Servicios>();
        public ICollection<Cotizaciones>? cotizaciones { get; set; } = new List<Cotizaciones>();
    }
}