using System.ComponentModel.DataAnnotations;

namespace AppServiceAndTravel.Areas.Admin.Models
{
    public class ConfiguracionGeneral
    {
        [Key]
        public int idConfiguracionGeneral { get; set; }
        [Required, StringLength(200)] public string NombreEmpresa { get; set; } = "AppServiceAndTravel";
        [StringLength(500)] public string? Eslogan { get; set; }
        [StringLength(500)] public string? RutaLogo { get; set; }
        [StringLength(500)] public string? RutaFavicon { get; set; }
        [StringLength(300)] public string? Direccion { get; set; }
        [StringLength(100)] public string? Ciudad { get; set; }
        [StringLength(100)] public string? Departamento { get; set; }
        [StringLength(100)] public string? Pais { get; set; } = "Colombia";
        [StringLength(25)] public string? Telefono { get; set; }
        [StringLength(25)] public string? Telefono2 { get; set; }
        [StringLength(200)] public string? correo { get; set; }
        [StringLength(200)] public string? SitioWeb { get; set; }
        [StringLength(30)] public string? NitEmpresa { get; set; }

        [StringLength(10)] public string Moneda { get; set; } = "COP";
        [StringLength(10)] public string SimboloMoneda { get; set; } = "$";
        [StringLength(10)] public string Idioma { get; set; } = "es-CO";
        [StringLength(50)] public string ZonaHoraria { get; set; } = "America/Bogota";
        [StringLength(20)] public string FormatoFecha { get; set; } = "dd/MM/yyyy";
        [StringLength(10)] public string SeparadorDecimal { get; set; } = ",";
        [StringLength(10)] public string SeparadorMiles { get; set; } = ".";
        
        [StringLength(100)] public string TemaSeleccionado { get; set; } = "Azul corporativo";
        [StringLength(100)] public string FuenteSistema { get; set; } = "Inter";
        [StringLength(20)] public string TamanoFuenteBase { get; set; } = "14px";
        [StringLength(7)] public string ColorPrimario { get; set; } = "#0080ff";
        [StringLength(7)] public string ColorSecundario { get; set; } = "#52e5ff";
        [StringLength(7)] public string ColorAcento { get; set; } = "#16a34a";
        [StringLength(7)] public string ColorTexto { get; set; } = "#1e293b";
        [StringLength(7)] public string ColorFondo { get; set; } = "#f0f4f8";
        [StringLength(7)] public string ColorPeligro { get; set; } = "#dc2626";
        [StringLength(7)] public string ColorAdvertencia { get; set; } = "#f59e0b";

        public bool NotificarPorcorreo { get; set; } = true;
        public bool NotificarPorWhatsApp { get; set; } = true;
        public int DiasAlertaVencimiento { get; set; } = 30;
        
        [StringLength(500)] public string? JwtSecretKey { get; set; } = "EstaEsUnaLlaveSecretaSeguraYBienLarga";
        [StringLength(500)] public string? JwtIssuer { get; set; } = "AppServiceAndTravelAPI";
        [StringLength(500)] public string? JwtAudience { get; set; } = "AppServiceAndTravelApp";
        public int JwtExpirationMinutes { get; set; } = 60;
        public DateTime UltimaModificacion { get; set; } = DateTime.Now;
        [StringLength(200)] public int? ModificadoPorId { get; set; }
    }
}
