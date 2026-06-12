using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Operaciones.Models;
using AppServiceAndTravel.Areas.Operaciones.ViewModels;
using AppServiceAndTravel.Helpers;
using AppServiceAndTravel.ViewModels;
using AppServiceAndTravel.Models;

namespace AppServiceAndTravel.Areas.Operaciones.Services
{
    public interface IVehiculoService
    {
        Task<List<VehiculoListadoVM>> ListarVehiculos(string? busqueda, EstadoVehiculo? estado);
        Task<VehiculoDetalleVM?> ObtenerVehiculo(int id);
        Task<(bool success, string message, VehiculoDetalleVM Data)> GuardarVehiculo(VehiculoDetalleVM model);
        Task<(bool success, string message)> EliminarVehiculo(int id);
        Task<List<object>> BuscarVehiculos(string term);
        Task<VehiculoKpiVM> ObtenerKpis();
        Task<(bool success, string message)> DeshabilitarVehiculo(int idVehiculo);
        List<TiposVehiculosVM> ObtenerTiposVehiculos();
        Task<ValidacionResultado> ValidarParaServicio(int vehiculoId, int conductorId, string? usuarioId = null, int? servicioId = null);
        Task<(bool success, string message)> CambiarEstadoVehiculo(int idVehiculo, EstadoVehiculo estado);
    }

    public class ValidacionResultado
    {
        public bool Success { get; set; }
        public List<string> Errores { get; set; } = new();
        public List<string> Advertencias { get; set; } = new();
        public Vehiculos? Vehiculo { get; set; }
        public Conductores? Conductor { get; set; }
    }

    public class VehiculoService : IVehiculoService
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<VehiculoService> _logger;
        private const int DiasAlertaAnticipada = 30;

        public VehiculoService(ApplicationDBContext context, ILogger<VehiculoService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<VehiculoKpiVM> ObtenerKpis()
        {
            var hoy = DateTime.Today;
            var alerta = hoy.AddDays(30);

            return new VehiculoKpiVM
            {
                Activos = await _context.Vehiculos
                    .CountAsync(x =>
                        x.Estado == EstadoVehiculo.Activo),

                Inactivos = await _context.Vehiculos
                    .CountAsync(x =>
                        x.Estado == EstadoVehiculo.Inactivo),

                Mantenimiento = await _context.Vehiculos
                    .CountAsync(x =>
                        x.Estado == EstadoVehiculo.EnMantenimientoPreventivo ||
                        x.Estado == EstadoVehiculo.EnMantenimientoCorrectivo),

                ConAlertas =
                    await _context.VehiculoSOAT
                        .CountAsync(x =>
                            x.FechaFinVigencia <= alerta)
            };
        }        
        public async Task<List<object>> BuscarVehiculos(string term)
        {
            term = term?.Trim() ?? string.Empty;

            var vehiculos = await _context.Vehiculos
                .Include(x => x.Propietario)
                .Where(x =>
                    x.Placa.Contains(term) ||
                    x.Marca.Contains(term) ||
                    x.Modelo.Contains(term) ||
                    (x.Propietario != null &&
                     x.Propietario.Nombre!.Contains(term)))
                .OrderBy(x => x.Placa)
                .Take(20)
                .Select(x => new
                {
                    id = x.idVehiculo,
                    label = $"{x.Placa} - {x.Marca} {x.Modelo}" +
                            (x.Propietario != null
                                ? $" ({x.Propietario.Nombre})"
                                : ""),
                    value = x.Placa
                })
                .ToListAsync();

            return vehiculos.Cast<object>().ToList();
        }
        public async Task<List<VehiculoListadoVM>> ListarVehiculos(string? busqueda, EstadoVehiculo? estado)
        {
            var query = _context.Vehiculos
                .Include(x => x.SOAT)
                .Include(x => x.RTM)
                .Include(x => x.TarjetaOperacion)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                query = query.Where(x =>
                    x.Placa.Contains(busqueda) ||
                    x.Marca.Contains(busqueda) ||
                    x.Modelo.Contains(busqueda));
            }

            if (estado.HasValue)
            {
                query = query.Where(x => x.Estado == estado);
            }

            return await query
                .OrderBy(x => x.Placa)
                .Select(x => new VehiculoListadoVM
                {
                    idVehiculo = x.idVehiculo,
                    Placa = x.Placa,
                    Marca = x.Marca,
                    Modelo = x.Modelo,
                    Estado = x.Estado,
                    CapacidadPasajeros = x.CapacidadPasajeros,

                    SoatVence = x.SOAT != null
                        ? x.SOAT.FechaFinVigencia
                        : null,

                    RtmVence = x.RTM != null
                        ? x.RTM.FechaVigencia
                        : null,

                    TarjetaOperacionVence = x.TarjetaOperacion != null
                        ? x.TarjetaOperacion.FechaFinVigencia
                        : null
                })
                .ToListAsync();
        }
        public async Task<VehiculoDetalleVM?> ObtenerVehiculo(int id)
        {
            return await _context.Vehiculos
                .Include(x => x.TipoVehiculo)
                .Include(x => x.Propietario)
                .Include(x => x.Caracteristicas)
                .Include(x => x.Matricula)
                .Include(x => x.SOAT)
                .Include(x => x.PolizaRC)
                .Include(x => x.RTM)
                .Include(x => x.TarjetaOperacion)
                .Include(x => x.Blindaje)
                .Include(x => x.Regrabaciones)
                .Where(x => x.idVehiculo == id)
                .Select(x => new VehiculoDetalleVM
                {
                    idVehiculo = x.idVehiculo,
                    Placa = x.Placa,
                    Marca = x.Marca,
                    Modelo = x.Modelo,
                    Linea = x.Linea!,
                    Color = x.Color!,
                    //ClaseVehiculo = x.ClaseVehiculo,

                    //TipoServicio = x.TipoServicio.ToString(),
                    ModalidadServicio = x.ModalidadServicio,
                    ModalidadTransporte = x.ModalidadTransporte,

                    CapacidadPasajeros = x.CapacidadPasajeros,
                    CapacidadPasajerosSentados = x.CapacidadPasajerosSentados,
                    CapacidadCarga = x.CapacidadCarga,
                    PesoBrutoVehicular = x.PesoBrutoVehicular,

                    NumeroEjes = x.NumeroEjes,
                    Puertas = x.Puertas,

                    Estado = x.Estado,
                    TipoProveedor = x.TipoProveedor,

                    ClasicoAntiguo = x.ClasicoAntiguo,
                    Repotenciado = x.Repotenciado,
                    VehiculoEnsenanza = x.VehiculoEnsenanza,

                    Observaciones = x.Observaciones,

                    //idTipoVehiculo = x.idTipoVehiculo,
                    //TipoVehiculo = x.TipoVehiculo!.descripcion,

                    NombrePropietario = x.Propietario!.Nombre,
                    CedulaPropietario = x.Propietario.Cedula,
                    TelefonoPropietario = x.Propietario.Telefono,

                    NumeroVIN = x.Caracteristicas!.NumeroVIN,
                    NumeroMotor = x.Caracteristicas.NumeroMotor,
                    NumeroChasis = x.Caracteristicas.NumeroChasis,
                    NumeroSerie = x.Caracteristicas.NumeroSerie,

                    LicenciaTransito = x.Matricula!.LicenciaTransito,
                    FechaMatriculaInicial = x.Matricula.FechaMatriculaInicial,
                    AutoridadTransito = x.Matricula.AutoridadTransito,

                    SoatNumeroPoliza = x.SOAT!.NumeroPoliza,
                    SoatEntidadExpide = x.SOAT.EntidadExpide,
                    SoatEstado = x.SOAT.Estado,

                    PolizaNumero = x.PolizaRC!.NumeroPoliza,
                    PolizaTipo = x.PolizaRC.TipoPoliza,
                    PolizaEntidadExpide = x.PolizaRC.EntidadExpide,

                    RtmTipoRevision = x.RTM!.TipoRevision,
                    RtmNumeroCertificado = x.RTM.NumeroCertificado,

                    EmpresaAfiliadora = x.TarjetaOperacion!.EmpresaAfiliadora,

                    Blindado = x.Blindaje != null && x.Blindaje.Blindado,

                    RegrabacionMotor = x.Regrabaciones!.NumeroRegrabacionMotor
                })
                .FirstOrDefaultAsync();
        }
        public List<TiposVehiculosVM> ObtenerTiposVehiculos()
        {
            var TipoVehiculoVM = _context.TiposVehiculos
                .OrderBy(r => r.descripcion)
                .Select(r => new TiposVehiculosVM
                {
                    id = r.idTipoVehiculo,
                    descripcion = r.descripcion
                })
                .ToList();

            return TipoVehiculoVM;
        }
        public async Task<(bool success, string message, VehiculoDetalleVM Data)> GuardarVehiculo(VehiculoDetalleVM model)
        {
            try
            {
                Vehiculos? vehiculo;

                if (model.idVehiculo > 0)
                {
                    vehiculo = await _context.Vehiculos
                        .Include(x => x.Propietario)
                        .Include(x => x.Caracteristicas)
                        .Include(x => x.Matricula)
                        .Include(x => x.SOAT)
                        .Include(x => x.PolizaRC)
                        .Include(x => x.RTM)
                        .Include(x => x.TarjetaOperacion)
                        .Include(x => x.Blindaje)
                        .Include(x => x.Regrabaciones)
                        .FirstOrDefaultAsync(x => x.idVehiculo == model.idVehiculo);

                    if (vehiculo == null)
                        return (false, "Vehículo no encontrado", null!);
                }
                else
                {
                    vehiculo = new Vehiculos();

                    _context.Vehiculos.Add(vehiculo);
                }

                // Datos generales
                vehiculo.Placa = model.Placa;
                vehiculo.Marca = model.Marca;
                vehiculo.Modelo = model.Modelo;
                vehiculo.Linea = model.Linea;
                vehiculo.Color = model.Color;
                vehiculo.Estado = model.Estado;
                vehiculo.idTipoVehiculo = model.TipoVehiculo;
                vehiculo.CapacidadPasajeros = model.CapacidadPasajeros ?? 0;
                vehiculo.CapacidadCarga = model.CapacidadCarga ?? 0;

                // Propietario
                vehiculo.Propietario ??= new VehiculoPropietario();

                vehiculo.Propietario.Nombre = model.NombrePropietario;
                vehiculo.Propietario.Cedula = model.CedulaPropietario;
                vehiculo.Propietario.Telefono = model.TelefonoPropietario;

                // Características
                vehiculo.Caracteristicas ??= new VehiculoCaracteristicas();

                vehiculo.Caracteristicas.NumeroVIN = model.NumeroVIN;
                vehiculo.Caracteristicas.NumeroMotor = model.NumeroMotor;
                vehiculo.Caracteristicas.NumeroChasis = model.NumeroChasis;
                vehiculo.Caracteristicas.NumeroSerie = model.NumeroSerie;

                // SOAT
                vehiculo.SOAT ??= new VehiculoSOAT();

                vehiculo.SOAT.NumeroPoliza = model.SoatNumeroPoliza;
                vehiculo.SOAT.EntidadExpide = model.SoatEntidadExpide;
                vehiculo.SOAT.Estado = model.SoatEstado;

                // RTM
                vehiculo.RTM ??= new VehiculoRTM();

                vehiculo.RTM.NumeroCertificado = model.RtmNumeroCertificado;
                vehiculo.RTM.TipoRevision = model.RtmTipoRevision;

                await _context.SaveChangesAsync();

                return (
                    true,
                    model.idVehiculo > 0
                        ? "Vehículo actualizado correctamente"
                        : "Vehículo guardado correctamente",
                    model
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error guardando vehículo");

                return (
                    false,
                    ex.Message,
                    null!
                );
            }
        }
        public async Task<(bool success, string message)> EliminarVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos
                .FirstOrDefaultAsync(x =>
                    x.idVehiculo == id);

            if (vehiculo == null)
                return (false, "Vehículo no encontrado");

            _context.Vehiculos.Remove(vehiculo);

            await _context.SaveChangesAsync();

            return (true, "Vehículo eliminado");
        }
        public async Task<(bool success, string message)> DeshabilitarVehiculo(int idVehiculo)
        {
            var vehiculo = await _context.Vehiculos
                .FirstOrDefaultAsync(x => x.idVehiculo == idVehiculo);

            if (vehiculo == null)
            {
                return new(false, "Vehículo no encontrado.");
            }

            vehiculo.Estado = EstadoVehiculo.Inactivo;

            await _context.SaveChangesAsync();

            _logger.LogInformation(
                "Vehículo {Placa} deshabilitado",
                vehiculo.Placa);

            return new(true, $"Vehículo {vehiculo.Placa} deshabilitado correctamente.");
        }
        public async Task<ValidacionResultado> ValidarParaServicio(int vehiculoId, int conductorId, string? usuarioId = null, int? servicioId = null)
        {
            var resultado = new ValidacionResultado();

            resultado.Vehiculo = await _context.Vehiculos
                .Include(x => x.SOAT)
                .Include(x => x.RTM)
                .Include(x => x.TarjetaOperacion)
                .FirstOrDefaultAsync(x => x.idVehiculo == vehiculoId);

            if (resultado.Vehiculo == null)
            {
                resultado.Errores.Add("El vehículo seleccionado no existe.");
                resultado.Success = false;
                return resultado;
            }

            resultado.Conductor = await _context.Conductores.FirstOrDefaultAsync(x => x.idConductor == conductorId);

            if (resultado.Conductor == null)
            {
                resultado.Errores.Add("El conductor seleccionado no existe.");
                resultado.Success = false;
                return resultado;
            }

            var hoy = DateTime.Today;
            var alertaFecha = hoy.AddDays(DiasAlertaAnticipada);

            var v = resultado.Vehiculo;
            var c = resultado.Conductor;

            #region Errores

            if (v.Estado != EstadoVehiculo.Activo)
            {
                resultado.Errores.Add($"El vehículo {v.Placa} no está activo. Estado actual: {v.Estado}.");
            }

            if (!c.Activo)
            {
                resultado.Errores.Add($"El conductor {c.NombreCompleto} no está activo en el sistema.");
            }

            if (v.SOAT == null)
            {
                resultado.Errores.Add("El vehículo no tiene SOAT registrado.");
            }
            else if (v.SOAT.FechaFinVigencia < hoy)
            {
                resultado.Errores.Add($"SOAT vencido. Venció el {v.SOAT.FechaFinVigencia:dd/MM/yyyy}.");
            }

            if (v.RTM == null)
            {
                resultado.Errores.Add("El vehículo no tiene revisión técnico mecánica registrada.");
            }
            else if (v.RTM.FechaVigencia < hoy)
            {
                resultado.Errores.Add($"RTM vencida. Venció el {v.RTM.FechaVigencia:dd/MM/yyyy}.");
            }

            if (v.TarjetaOperacion == null)
            {
                resultado.Errores.Add("El vehículo no tiene tarjeta de operación registrada.");
            }
            else if (v.TarjetaOperacion.FechaFinVigencia < hoy)
            {
                resultado.Errores.Add($"Tarjeta de operación vencida. Venció el {v.TarjetaOperacion.FechaFinVigencia:dd/MM/yyyy}.");
            }

            if (c.FechaVencimientoLicencia < hoy)
            {
                resultado.Errores.Add($"Licencia del conductor vencida. Venció el {c.FechaVencimientoLicencia:dd/MM/yyyy}.");
            }

            #endregion

            #region Advertencias

            if (v.SOAT?.FechaFinVigencia >= hoy &&
                v.SOAT.FechaFinVigencia <= alertaFecha)
            {
                var diasSOAT = (v.SOAT.FechaFinVigencia.Value - hoy).Days;

                resultado.Advertencias.Add($"⚠️ SOAT vence pronto: {v.SOAT.FechaFinVigencia:dd/MM/yyyy} ({diasSOAT} días).");
            }

            if (v.RTM?.FechaVigencia >= hoy &&
                v.RTM.FechaVigencia <= alertaFecha)
            {
                var diasRTM = (v.RTM.FechaVigencia.Value - hoy).Days;
                resultado.Advertencias.Add($"⚠️ RTM vence pronto: {v.RTM.FechaVigencia:dd/MM/yyyy} ({diasRTM} días).");
            }

            if (v.TarjetaOperacion?.FechaFinVigencia >= hoy &&
                v.TarjetaOperacion.FechaFinVigencia <= alertaFecha)
            {
                var diasTO = (v.TarjetaOperacion.FechaFinVigencia.Value - hoy).Days;
                resultado.Advertencias.Add($"⚠️ Tarjeta de operación vence pronto: {v.TarjetaOperacion.FechaFinVigencia:dd/MM/yyyy} ({diasTO} días).");
            }

            if (c.FechaVencimientoLicencia >= hoy &&
                c.FechaVencimientoLicencia <= alertaFecha)
            {
                resultado.Advertencias.Add($"⚠️ Licencia del conductor vence pronto: {c.FechaVencimientoLicencia:dd/MM/yyyy} ({(c.FechaVencimientoLicencia - hoy).Days} días).");
            }

            #endregion

            resultado.Success = resultado.Errores.Count == 0;

            await _context.ValidacionesVehiculo.AddAsync(new ValidacionVehiculo
            {
                idVehiculo = vehiculoId,
                idServicio = servicioId,

                EstadoActivo =
                    v.Estado == EstadoVehiculo.Activo,

                LicenciaConductorVigente =
                    c.FechaVencimientoLicencia >= hoy,

                Resultado = resultado.Success,

                Observaciones = resultado.Errores.Any()
                    ? string.Join(" | ", resultado.Errores)
                    : "Validación exitosa",

                UsuarioId = usuarioId
            });

            await _context.SaveChangesAsync();

            _logger.LogInformation("Validación vehículo {Placa}: {Resultado}", v.Placa, resultado.Success ? "OK" : "FALLO");

            return resultado;
        }
        public async Task<(bool success, string message)> CambiarEstadoVehiculo(int idVehiculo, EstadoVehiculo estado)
        {
            var vehiculo = await _context.Vehiculos
                .FirstOrDefaultAsync(x => x.idVehiculo == idVehiculo);

            if (vehiculo == null)
            {
                return new(false, "Vehículo no encontrado");
            }

            vehiculo.Estado = estado;

            await _context.SaveChangesAsync();

            return new(true, $"Estado actualizado a {estado}");
        }
    }
}