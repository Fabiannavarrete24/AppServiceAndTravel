namespace AppServiceAndTravel.Models
{
    public enum EstadoGeneral { Activo, Inactivo}
    public enum EstadoVehiculo { Activo, Inactivo, EnMantenimientoPreventivo, EnMantenimientoCorrectivo }
    public enum TipoProveedor { Interno, Externo }
    public enum EstadoServicio { Programado, EnCurso, Completado, Cancelado, Pendiente, Finalizado }
    public enum EstadoLicencia { Vigente, Suspendida, Cancelada, Retenida }
    public enum EstadoPersona { Activa, Inactiva, Fallecida }
    public enum EstadoConductor { Activo, Suspendido, Cancelado, Bloqueado }
    public enum EstadoCotizacion { Pendiente, Aprobada, Rechazada }
    public enum EstadoLogSistema { INFO, WARNING, ERROR, CRITICAL }
    public enum EventosSistemas { CREA, EDITA, ELIMINA, LECTURA }
    public enum TipoServicioExterno { Vehiculo, Conductor, Ambos }
}
