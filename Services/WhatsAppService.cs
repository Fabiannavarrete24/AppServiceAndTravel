using AppServiceAndTravel.Models;
using System.Net;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace AppServiceAndTravel.Services
{
    public interface IWhatsAppService
    {
        Task<bool> EnviarconfirmadaacionServicioAsync(string telefono, Servicios servicio);

        Task<bool> EnviarAprobacionCotizacionAsync(string telefono,string nombreCliente,Cotizaciones cotizacion);

        Task<bool> EnviarMensajeAsync(string telefono, string mensaje);
    }

    public class WhatsAppService : IWhatsAppService
    {
        private readonly IConfiguration _config;
        private readonly ILogger<WhatsAppService> _logger;
        private readonly HttpClient _httpClient;

        public WhatsAppService(
            IConfiguration config,
            ILogger<WhatsAppService> logger,
            HttpClient httpClient)
        {
            _config = config;
            _logger = logger;
            _httpClient = httpClient;
        }

        // =========================================================
        // MENSAJE GENÉRICO
        // =========================================================

        public async Task<bool> EnviarMensajeAsync(string telefono,string mensaje)
        {
            try
            {
                var provider =
                    _config["WhatsAppSettings:Provider"]
                    ?? "CallMeBot";

                return provider switch
                {
                    "Twilio" =>
                        await EnviarTwilioAsync(telefono, mensaje),

                    _ =>
                        await EnviarCallMeBotAsync(telefono, mensaje)
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error enviando WhatsApp a {Telefono}",
                    telefono);

                return false;
            }
        }

        // =========================================================
        // confirmadaACIÓN SERVICIO
        // =========================================================

        public async Task<bool> EnviarconfirmadaacionServicioAsync(string telefono,Servicios servicio)
        {
            var mensaje = $"""
            🚌 *SERVICIO confirmadaADO*
            ━━━━━━━━━━━━━━━━━━━

            📋 Servicio: #{servicio.idCotizacion:D6}

            📅 Fecha:
            {servicio.FechaServicio:dd/MM/yyyy HH:mm}

            🗺️ Ruta:
            {servicio.Cotizacion?.Origen}
            ➡️
            {servicio.Cotizacion?.Destino}

            🚗 Vehículo:
            {servicio.Vehiculo?.Marca}
            {servicio.Vehiculo?.Modelo}

            🔢 Placa:
            {servicio.Vehiculo?.Placa}

            👤 Conductor:
            {servicio.Conductor?.NombreCompleto}

            📞 Tel:
            {servicio.Conductor?.Telefono}

            ━━━━━━━━━━━━━━━━━━━
            Sistema Transporte
            """;

            return await EnviarMensajeAsync(
                telefono,
                mensaje);
        }

        // =========================================================
        // APROBACIÓN COTIZACIÓN
        // =========================================================

        public async Task<bool> EnviarAprobacionCotizacionAsync(string telefono,string nombreCliente,Cotizaciones cotizacion)
        {
            var mensaje = $"""
            ✅ *COTIZACIÓN APROBADA*
            ━━━━━━━━━━━━━━━━━━━

            Hola {nombreCliente}

            📋 Cotización:
            #{cotizacion.idCotizacion:D6}

            🗺️ Ruta:
            {cotizacion.Origen}
            ➡️
            {cotizacion.Destino}

            📅 Fecha:
            {cotizacion.FechaServicio:dd/MM/yyyy}

            💰 Valor:
            ${cotizacion.ValorAprobado ?? cotizacion.ValorCotizado:N0}

            ━━━━━━━━━━━━━━━━━━━
            Pronto recibirá más detalles.
            """;

            return await EnviarMensajeAsync(
                telefono,
                mensaje);
        }

        // =========================================================
        // CALLMEBOT
        // =========================================================

        private async Task<bool> EnviarCallMeBotAsync(
            string telefono,
            string mensaje)
        {
            var apiUrl =
                _config["WhatsAppSettings:CallMeBot:ApiUrl"]
                ?? "https://api.callmebot.com/whatsapp.php";

            var apiKey =
                _config["WhatsAppSettings:CallMeBot:ApiKey"];

            if (string.IsNullOrWhiteSpace(apiKey))
                throw new Exception(
                    "No existe ApiKey CallMeBot.");

            var telefonoLimpio =
                LimpiarTelefono(telefono);

            var mensajeCodificado =
                WebUtility.UrlEncode(mensaje);

            var url =
                $"{apiUrl}?phone={telefonoLimpio}&text={mensajeCodificado}&apikey={apiKey}";

            var response =
                await _httpClient.GetAsync(url);

            return response.IsSuccessStatusCode;
        }

        // =========================================================
        // TWILIO
        // =========================================================

        private async Task<bool> EnviarTwilioAsync(
            string telefono,
            string mensaje)
        {
            try
            {
                var sid =
                    _config["Twilio:AccountSid"];

                var token =
                    _config["Twilio:AuthToken"];

                var from =
                    _config["Twilio:From"];

                TwilioClient.Init(sid, token);

                await MessageResource.CreateAsync(
                    body: mensaje,
                    from: new Twilio.Types.PhoneNumber(
                        $"whatsapp:{from}"),
                    to: new Twilio.Types.PhoneNumber(
                        $"whatsapp:{telefono}")
                );

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Twilio");
                return false;
            }
        }

        // =========================================================
        // LIMPIAR TELÉFONO
        // =========================================================

        private static string LimpiarTelefono(
            string telefono)
        {
            var limpio =
                new string(
                    telefono
                    .Where(char.IsDigit)
                    .ToArray());

            if (limpio.Length == 10)
                limpio = "57" + limpio;

            return limpio;
        }
    }
}