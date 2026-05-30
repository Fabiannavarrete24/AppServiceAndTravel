namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class AuditoriaPermisos
    {
        public int idAuditoria { get; set; }

        public int idRol { get; set; }

        public int idProceso { get; set; }

        public string? accion { get; set; }

        public int usuarioId { get; set; }

        public DateTime fecha { get; set; }
    }

}
