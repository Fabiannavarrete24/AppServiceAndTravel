using AppServiceAndTravel.Data;
using AppServiceAndTravel.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace AppServiceAndTravel.Services
{
    public interface IEmailService
    {
        Task EnviarconfirmadaacionServicioAsync(string destinatario, string nombreCliente, Servicios servicio);
        Task EnviarCotizacionCreadaAsync(string destinatario, string nombreCliente, Cotizaciones cotizacion);
        Task EnviarAprobacionCotizacionAsync(string destinatario, string nombreCliente, Cotizaciones cotizacion);
        Task EnviarRechazoCotizacionAsync(string destinatario, string nombreCliente, Cotizaciones cotizacion);
        Task<(bool isSuccess, string errorMessage)> Enviarcorreo(string destinatario, string nombre, string asunto, string cuerpoHtml, byte[] archivo,string nombreArchivo);
    }

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDBContext _context;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IConfiguration config, ApplicationDBContext context, ILogger<EmailService> logger)
        {
            _configuration = config;
            _context = context;
            _logger = logger;
        }

        // ?? M�todo base para enviar correos ????????????????????????????????
        public async Task<(bool isSuccess, string errorMessage)> Enviarcorreo(string para, string copia, string asunto, string cuerpo, byte[] archivo, string nombreArchivo)
        {
            try
            {
                var configSMTP = _context.ConfiguracionNotificaciones.FirstOrDefault();
                var email = new MimeMessage();

                email.From.Add(MailboxAddress.Parse(configSMTP!.smtpUserName!));
                email.To.Add(MailboxAddress.Parse(para));

                if (!string.IsNullOrEmpty(copia))
                {
                    foreach (var emailCopia in copia.Split(','))
                    {
                        email.Cc.Add(MailboxAddress.Parse(emailCopia.Trim()));
                    }
                }

                email.Subject = asunto;

                var builder = new BodyBuilder { HtmlBody = cuerpo };

                if (archivo != null && archivo.Length > 0)
                {
                    builder.Attachments.Add(nombreArchivo, archivo);
                }

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync(configSMTP.smtpServer!, configSMTP.smtpPort!, true);
                await smtp.AuthenticateAsync(configSMTP.smtpUserName!, configSMTP.smtpPassword!);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);

                return (true, "correo enviado con exito");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task EnviarCotizacionCreadaAsync(string destinatario, string nombreCliente, Cotizaciones cotizacion)
        {
            var html = GenerarPlantillaBase(
                titulo: "Cotización Recibida",
                colorHeader: "#1e3a5f",
                icono: "??",
                contenido: $@"
                    <p>Estimado/a <strong>{nombreCliente}</strong>,</p>
                    <p>Hemos recibido su solicitud de cotizaci�n. A continuaci�n los detalles:</p>
                    <table style='width:100%;border-collapse:collapse;margin:20px 0;'>
                        <tr style='background:#f0f4f8;'>
                            <td style='padding:10px;font-weight:bold;width:40%;border:1px solid #ddd;'>N�mero de Cotizaci�n</td>
                            <td style='padding:10px;border:1px solid #ddd;'>#{cotizacion.idCotizacion:D6}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Origen</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{cotizacion.Origen}</td>
                        </tr>
                        <tr style='background:#f0f4f8;'>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Destino</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{cotizacion.Destino}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Fecha del Servicio</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{cotizacion.FechaServicio:dd/MM/yyyy}</td>
                        </tr>
                        <tr style='background:#f0f4f8;'>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Valor Cotizado</td>
                            <td style='padding:10px;border:1px solid #ddd;color:#1e3a5f;font-weight:bold;font-size:16px;'>${cotizacion.ValorCotizado:N2}</td>
                        </tr>
                    </table>
                    <p>Su cotizaci�n est� siendo <strong>revisada</strong> por nuestro equipo. Le notificaremos cuando sea aprobada.</p>"
            );

            await Enviarcorreo(destinatario, nombreCliente, $"Cotizaci�n #{cotizacion.idCotizacion:D6} - Recibida", html, null!, null!);
        }

        // ?? Cotizaci�n aprobada ???????????????????????????????????????????
        public async Task EnviarAprobacionCotizacionAsync(string destinatario, string nombreCliente, Cotizaciones cotizacion)
        {
            var html = GenerarPlantillaBase(
                titulo: "�Cotizaci�n Aprobada!",
                colorHeader: "#155724",
                icono: "?",
                contenido: $@"
                    <p>Estimado/a <strong>{nombreCliente}</strong>,</p>
                    <p>Nos complace informarle que su cotizaci�n ha sido <strong style='color:#155724;'>APROBADA</strong>.</p>
                    <table style='width:100%;border-collapse:collapse;margin:20px 0;'>
                        <tr style='background:#d4edda;'>
                            <td style='padding:10px;font-weight:bold;width:40%;border:1px solid #c3e6cb;'>Cotizaci�n N�</td>
                            <td style='padding:10px;border:1px solid #c3e6cb;'>#{cotizacion.idCotizacion:D6}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Ruta</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{cotizacion.Origen} ? {cotizacion.Destino}</td>
                        </tr>
                        <tr style='background:#d4edda;'>
                            <td style='padding:10px;font-weight:bold;border:1px solid #c3e6cb;'>Fecha del Servicio</td>
                            <td style='padding:10px;border:1px solid #c3e6cb;'>{cotizacion.FechaServicio:dd/MM/yyyy}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Valor Aprobado</td>
                            <td style='padding:10px;border:1px solid #ddd;color:#155724;font-weight:bold;font-size:16px;'>${cotizacion.ValorAprobado ?? cotizacion.ValorCotizado:N2}</td>
                        </tr>
                    </table>
                    {(string.IsNullOrEmpty(cotizacion.ObservacionesAprobacion) ? "" : $"<p><strong>Observaciones:</strong> {cotizacion.ObservacionesAprobacion}</p>")}
                    <p>Pr�ximamente recibir� la confirmadaaci�n del servicio con el veh�culo y conductor asignados.</p>"
            );

            await Enviarcorreo(destinatario, nombreCliente, $"? Cotizaci�n #{cotizacion.idCotizacion:D6} - Aprobada", html, null!, null!);
        }

        // ?? Cotizaci�n rechazada ??????????????????????????????????????????
        public async Task EnviarRechazoCotizacionAsync(string destinatario, string nombreCliente, Cotizaciones cotizacion)
        {
            var html = GenerarPlantillaBase(
                titulo: "Cotizaci�n No Aprobada",
                colorHeader: "#721c24",
                icono: "?",
                contenido: $@"
                    <p>Estimado/a <strong>{nombreCliente}</strong>,</p>
                    <p>Lamentamos informarle que su cotizaci�n N� <strong>#{cotizacion.idCotizacion:D6}</strong> no pudo ser aprobada en esta oportunidad.</p>
                    {(string.IsNullOrEmpty(cotizacion.ObservacionesRechazo) ? "" : $"<div style='background:#f8d7da;padding:15px;border-radius:8px;border-left:4px solid #f5c6cb;margin:15px 0;'><strong>Motivo:</strong> {cotizacion.ObservacionesRechazo}</div>")}
                    <p>Si desea, puede generar una nueva cotizaci�n con los ajustes correspondientes o contactar a nuestro equipo para m�s informaci�n.</p>"
            );

            await Enviarcorreo(destinatario, nombreCliente, $"Cotizaci�n #{cotizacion.idCotizacion:D6} - No Aprobada", html,null!,null!);
        }

        // ?? confirmadaaci�n de servicio ??????????????????????????????????????
        public async Task EnviarconfirmadaacionServicioAsync(string destinatario, string nombreCliente, Servicios servicio)
        {
            var html = GenerarPlantillaBase(
                titulo: "Servicio confirmadaado",
                colorHeader: "#004085",
                icono: "??",
                contenido: $@"
                    <p>Estimado/a <strong>{nombreCliente}</strong>,</p>
                    <p>Su servicio de transporte ha sido <strong style='color:#004085;'>confirmadaADO</strong>. A continuaci�n los detalles:</p>
                    <table style='width:100%;border-collapse:collapse;margin:20px 0;'>
                        <tr style='background:#cce5ff;'>
                            <td style='padding:10px;font-weight:bold;width:40%;border:1px solid #b8daff;'>N� Servicio</td>
                            <td style='padding:10px;border:1px solid #b8daff;'>#{servicio.idServicio:D6}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Fecha del Servicio</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{servicio.FechaServicio:dd/MM/yyyy HH:mm}</td>
                        </tr>
                        <tr style='background:#cce5ff;'>
                            <td style='padding:10px;font-weight:bold;border:1px solid #b8daff;'>Ruta</td>
                            <td style='padding:10px;border:1px solid #b8daff;'>{servicio.Cotizacion?.Origen} ? {servicio.Cotizacion?.Destino}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Veh�culo</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{servicio.Vehiculo?.Marca} {servicio.Vehiculo?.Modelo} - Placa: <strong>{servicio.Vehiculo?.Placa}</strong></td>
                        </tr>
                        <tr style='background:#cce5ff;'>
                            <td style='padding:10px;font-weight:bold;border:1px solid #b8daff;'>Conductor</td>
                            <td style='padding:10px;border:1px solid #b8daff;'>{servicio.Conductor?.NombreCompleto}</td>
                        </tr>
                        <tr>
                            <td style='padding:10px;font-weight:bold;border:1px solid #ddd;'>Tel�fono Conductor</td>
                            <td style='padding:10px;border:1px solid #ddd;'>{servicio.Conductor?.Telefono}</td>
                        </tr>
                    </table>
                    {(string.IsNullOrEmpty(servicio.Observaciones) ? "" : $"<p><strong>Observaciones:</strong> {servicio.Observaciones}</p>")}"
            );

            await Enviarcorreo(destinatario, nombreCliente, $"?? Servicio #{servicio.idServicio:D6} - confirmadaado", html, null!, null!);
        }

        // ?? Plantilla HTML base ???????????????????????????????????????????
        private static string GenerarPlantillaBase(string titulo, string colorHeader, string icono, string contenido)
        {
            return $@"
                <!DOCTYPE html>
                <html>
                <head>
                  <meta charset='utf-8'>
                  <meta name='viewport' content='width=device-width,initial-scale=1'>
                </head>
                <body style='margin:0;padding:0;font-family:Segoe UI,Arial,sans-serif;background:#f4f6f9;'>
                  <table width='100%' cellpadding='0' cellspacing='0' style='padding:30px 0;'>
                    <tr>
                      <td align='center'>
                        <table width='600' cellpadding='0' cellspacing='0' style='background:#fff;border-radius:12px;overflow:hidden;box-shadow:0 4px 20px rgba(0,0,0,.08);'>
                          <!-- Header -->
                          <tr>
                            <td style='background:{colorHeader};padding:30px;text-align:center;'>
                              <div style='font-size:40px;margin-bottom:10px;'>{icono}</div>
                              <h1 style='color:#fff;margin:0;font-size:24px;font-weight:600;'>{titulo}</h1>
                            </td>
                          </tr>
                          <!-- Content -->
                          <tr>
                            <td style='padding:30px;color:#333;font-size:15px;line-height:1.7;'>
                              {contenido}
                            </td>
                          </tr>
                          <!-- Footer -->
                          <tr>
                            <td style='background:#f8f9fa;padding:20px;text-align:center;border-top:1px solid #eee;'>
                              <p style='color:#888;font-size:13px;margin:0;'>Sistema de Gesti�n de Transporte</p>
                              <p style='color:#aaa;font-size:12px;margin:5px 0 0;'>Este es un mensaje autom�tico, por favor no responda a este correo.</p>
                            </td>
                          </tr>
                        </table>
                      </td>
                    </tr>
                  </table>
                </body>
                </html>";
        }
    }
}