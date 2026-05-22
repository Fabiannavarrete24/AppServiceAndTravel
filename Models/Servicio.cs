using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppServiceAndTravel.Models
{    
    public enum EstadoServicio { Programado, EnCurso, Completado, Cancelado }

    public class Servicio
    {
        public int Id { get; set; }
        [Required] public int CotizacionId { get; set; }
        public Cotizacion? Cotizacion { get; set; }

        // Interno
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }
        public int ConductorId { get; set; }
        public Conductor? Conductor { get; set; }
        [StringLength(200)] public string? TipoServicio { get; set; }

        // Externo
        public int? ProveedorExternoId { get; set; }
        public ProveedorExterno? ProveedorExterno { get; set; }
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
        public int? UsuarioCreadorId { get; set; }
        public ApplicationUser? UsuarioCreador { get; set; }

        public bool NotificacioncorreoEnviada { get; set; } = false;
        public bool NotificacionWhatsAppEnviada { get; set; } = false;
        public DateTime? FechaNotificacion { get; set; }
    }

}