using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Models
{
    public class Permisos
    {
        public int IdProceso { get; set; }
        public int idRol { get; set; }
        public bool lectura { get; set; }
        public bool crea { get; set; }
        public bool edita { get; set; }        
        public bool elimina { get; set; }
        public DateTime fechaCreacion { get; set; }= DateTime.UtcNow;
        public Roles? Rol { get; set; }
        public Procesos? proceso { get; set; }
    }
}

