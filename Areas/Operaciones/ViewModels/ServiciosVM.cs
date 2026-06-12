using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class ServiciosVM
    {
        public int idServicio { get; set; }
        public int idConductor { get; set; }
        public string? Conductor { get; set; }
        public int? idProveedorExterno { get; set; }
        public string? ProveedorExterno { get; set; }
        public string? VehiculoExternoPlaca { get; set; }
        public string? VehiculoExternoDescripcion { get; set; }
        public string? ConductorExternoNombre { get; set; }
        public string? ConductorExternoCedula { get; set; }
        public string? ConductorExternoTelefono { get; set; }
        public bool UsaRecursoExterno { get; set; } = false;
        public decimal? CostoExterno { get; set; }
        public DateTime FechaServicio { get; set; }
        public EstadoServicio Estado { get; set; } = EstadoServicio.Programado;
        public string? Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public int? idUsuarioCreador { get; set; }
        public int? UsuarioCreador { get; set; }
        public int idDetalleCotizacion { get; set; }
        public DetalleCotizacion? DetalleCotizacion { get; set; }
        public int? idTipoVehiculo { get; set; }
        public string? TipoVehiculo { get; set; }
        public int idVehiculo { get; set; }
        public Vehiculos? Vehiculo { get; set; }
        public bool NotificacioncorreoEnviada { get; set; } = false;
        public bool NotificacionWhatsAppEnviada { get; set; } = false;
        public DateTime? FechaNotificacion { get; set; }
    }
}
