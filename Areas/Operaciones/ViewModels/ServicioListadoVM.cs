namespace AppServiceAndTravel.Areas.Operaciones.ViewModels
{
    public class ServicioListadoVM
    {
        public int idServicio { get; set; }

        public int idCotizacion { get; set; }

        public string Cliente { get; set; } = "";

        public string Origen { get; set; } = "";

        public string Destino { get; set; } = "";

        public string Vehiculo { get; set; } = "";

        public string Conductor { get; set; } = "";

        public DateTime FechaServicio { get; set; }

        public string Estado { get; set; } = "";

        public bool CorreoEnviado { get; set; }

        public bool WhatsAppEnviado { get; set; }
    }
}