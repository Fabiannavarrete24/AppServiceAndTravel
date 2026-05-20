using AppServiceAndTravel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;

namespace AppServiceAndTravel.Services
{
    public interface IVehiculoValidationService
    {
        Task<ValidacionResultado> ValidarParaServicioAsync(int vehiculoId, int conductorId, string? usuarioId = null, int? servicioId = null);
    }

    public class ValidacionResultado
    {
        public bool Exitoso { get; set; }
        public List<string> Errores { get; set; } = new();
        public List<string> Advertencias { get; set; } = new();
        public Vehiculo? Vehiculo { get; set; }
        public Conductor? Conductor { get; set; }
    }

    public class VehiculoValidationService : IVehiculoValidationService
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<VehiculoValidationService> _logger;

        // Días de alerta anticipada para vencimientos
        private const int DiasAlertaAnticipada = 30;

        public VehiculoValidationService(ApplicationDBContext context, ILogger<VehiculoValidationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ValidacionResultado> ValidarParaServicioAsync(
            int vehiculoId, int conductorId, string? usuarioId = null, int? servicioId = null)
        {
            var resultado = new ValidacionResultado();

            // ── Cargar vehículo ───────────────────────────────────────────
            resultado.Vehiculo = await _context.Vehiculos.FindAsync(vehiculoId);

            if (resultado.Vehiculo == null)
            {
                resultado.Errores.Add("El vehículo seleccionado no existe.");
                resultado.Exitoso = false;
                return resultado;
            }

            // ── Cargar conductor ──────────────────────────────────────────
            resultado.Conductor = await _context.Conductores.FindAsync(conductorId);

            if (resultado.Conductor == null)
            {
                resultado.Errores.Add("El conductor seleccionado no existe.");
                resultado.Exitoso = false;
                return resultado;
            }

            var hoy = DateTime.Today;
            var v = resultado.Vehiculo;
            var c = resultado.Conductor;

            // ── Validaciones de ERRORES (bloquean el servicio) ────────────

            if (v.Estado != EstadoVehiculo.Activo)
                resultado.Errores.Add($"El vehículo {v.Placa} no está activo. Estado actual: {v.Estado}.");

            if (!c.Activo)
                resultado.Errores.Add($"El conductor {c.NombreCompleto} no está activo en el sistema.");

            if (v.FechaVencimientoSOAT < hoy)
                resultado.Errores.Add($"SOAT VENCIDO. Venció el {v.FechaVencimientoSOAT:dd/MM/yyyy}.");

            if (v.FechaVencimientoTecnoMecanica < hoy)
                resultado.Errores.Add($"Revisión Técnico-Mecánica VENCIDA. Venció el {v.FechaVencimientoTecnoMecanica:dd/MM/yyyy}.");

            if (v.FechaVencimientoSeguro < hoy)
                resultado.Errores.Add($"Seguro del vehículo VENCIDO. Venció el {v.FechaVencimientoSeguro:dd/MM/yyyy}.");

            if (c.FechaVencimientoLicencia < hoy)
                resultado.Errores.Add($"Licencia del conductor VENCIDA. Venció el {c.FechaVencimientoLicencia:dd/MM/yyyy}.");

            // ── Validaciones de ADVERTENCIAS (no bloquean) ────────────────
            var alertaFecha = hoy.AddDays(DiasAlertaAnticipada);

            if (v.FechaVencimientoSOAT >= hoy && v.FechaVencimientoSOAT <= alertaFecha)
                resultado.Advertencias.Add($"⚠️ SOAT vence pronto: {v.FechaVencimientoSOAT:dd/MM/yyyy} ({(v.FechaVencimientoSOAT - hoy).Days} días).");

            if (v.FechaVencimientoTecnoMecanica >= hoy && v.FechaVencimientoTecnoMecanica <= alertaFecha)
                resultado.Advertencias.Add($"⚠️ Técnico-Mecánica vence pronto: {v.FechaVencimientoTecnoMecanica:dd/MM/yyyy} ({(v.FechaVencimientoTecnoMecanica - hoy).Days} días).");

            if (v.FechaVencimientoSeguro >= hoy && v.FechaVencimientoSeguro <= alertaFecha)
                resultado.Advertencias.Add($"⚠️ Seguro vence pronto: {v.FechaVencimientoSeguro:dd/MM/yyyy} ({(v.FechaVencimientoSeguro - hoy).Days} días).");

            if (c.FechaVencimientoLicencia >= hoy && c.FechaVencimientoLicencia <= alertaFecha)
                resultado.Advertencias.Add($"⚠️ Licencia del conductor vence pronto: {c.FechaVencimientoLicencia:dd/MM/yyyy} ({(c.FechaVencimientoLicencia - hoy).Days} días).");

            resultado.Exitoso = resultado.Errores.Count == 0;

            // ── Guardar log de validación ─────────────────────────────────
            await _context.ValidacionesVehiculo.AddAsync(new ValidacionVehiculo
            {
                VehiculoId = vehiculoId,
                ServicioId = servicioId,
                SOATVigente = v.FechaVencimientoSOAT >= hoy,
                TecnoVigente = v.FechaVencimientoTecnoMecanica >= hoy,
                SeguroVigente = v.FechaVencimientoSeguro >= hoy,
                EstadoActivo = v.Estado == EstadoVehiculo.Activo,
                LicenciaConductorVigente = c.FechaVencimientoLicencia >= hoy,
                Resultado = resultado.Exitoso,
                Observaciones = resultado.Errores.Count > 0
                    ? string.Join(" | ", resultado.Errores)
                    : "Validación exitosa",
                UsuarioId = usuarioId
            });

            await _context.SaveChangesAsync();

            _logger.LogInformation(
                "Validación vehículo {Placa}: {Resultado}. Errores: {NumErrores}",
                v.Placa, resultado.Exitoso ? "OK" : "FALLO", resultado.Errores.Count);

            return resultado;
        }
    }
}