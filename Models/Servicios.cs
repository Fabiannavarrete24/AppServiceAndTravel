using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{    
    public enum EstadoServicio { Programado, EnCurso, Completado, Cancelado,Pendiente, Finalizado }

    public class Servicios
    {
        [Key]
        public int idServicio { get; set; }
        [Required] public int idCotizacion { get; set; }
        [ForeignKey(nameof(idCotizacion))]
        public Cotizaciones? Cotizacion { get; set; }
        public int idVehiculo { get; set; }
        [ForeignKey(nameof(idVehiculo))]
        public Vehiculos? Vehiculo { get; set; }
        public int idConductor { get; set; }
        [ForeignKey(nameof(idConductor))]
        public Conductores? Conductor { get; set; }
        [StringLength(200)] public string? TipoServicio { get; set; }
        public int? idProveedorExterno { get; set; }
        [ForeignKey(nameof(idProveedorExterno))]
        public ProveedoresExternos? ProveedorExterno { get; set; }
        [StringLength(20)] public string? VehiculoExternoPlaca { get; set; }
        [StringLength(120)] public string? VehiculoExternoDescripcion { get; set; }
        [StringLength(150)] public string? ConductorExternoNombre { get; set; }
        [StringLength(25)] public string? ConductorExternoCedula { get; set; }
        [StringLength(25)] public string? ConductorExternoTelefono { get; set; }
        public bool UsaRecursoExterno { get; set; } = false;
        [Column(TypeName = "decimal(14,2)")] public decimal? CostoExterno { get; set; }
        public DateTime FechaServicio { get; set; }
        public EstadoServicio Estado { get; set; } = EstadoServicio.Programado;
        [StringLength(1000)] public string? Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public int? idUsuarioCreador { get; set; }
        [ForeignKey(nameof(idUsuarioCreador))]
        public ApplicationUser? UsuarioCreador { get; set; }
        public bool NotificacioncorreoEnviada { get; set; } = false;
        public bool NotificacionWhatsAppEnviada { get; set; } = false;
        public DateTime? FechaNotificacion { get; set; }
    }

}