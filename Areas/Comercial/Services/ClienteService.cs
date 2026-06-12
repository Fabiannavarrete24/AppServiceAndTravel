using AppServiceAndTravel.Areas.Comercial.ViewModels;
using AppServiceAndTravel.Data;
using AppServiceAndTravel.Areas.Comercial.Models;
using AppServiceAndTravel.Services;
using Microsoft.EntityFrameworkCore;

namespace AppServiceAndTravel.Areas.Comercial.Services
{
    public interface IClienteService
    {
        Task<(bool success, string message)> CrearCliente(ClienteVM model);

        Task<(bool success, string message)> ActualizarCliente(ClienteVM model);

        Task<(bool success, string message, ClienteVM data)> ObtenerCliente(int id);

        Task<(bool success, string message)> CambiarEstado(int id);

        Task<(bool success, string message, object data)> ObtenerDashboard();

        Task<(bool success, string message, IEnumerable<ClienteVM> data, int totalRegistros)> ObtenerClientes(string? busqueda, bool soloActivos, int page, int pageSize);
        Task<List<ClienteVM>> BuscarClientes(string busqueda);
    }

    public class ClienteService : IClienteService
    {
        private readonly ApplicationDBContext _context;
        private readonly UtilitiesServices _utilities;

        public ClienteService(ApplicationDBContext context, UtilitiesServices utilities)
        {
            _context = context;
            _utilities = utilities;
        }
        public async Task<(bool success, string message)> CrearCliente(ClienteVM model)
        {
            try
            {
                var existeNit = await _context.Clientes
                    .AnyAsync(x => x.NitCedula == model.NitCedula);

                if (existeNit)
                    return (false, "Ya existe un cliente con ese NIT o Cédula");

                var existeCorreo = await _context.Clientes
                    .AnyAsync(x => x.Correo == model.correo);

                if (existeCorreo)
                    return (false, "Ya existe un cliente con ese correo");

                var cliente = new Clientes
                {
                    RazonSocial = model.RazonSocial,
                    NitCedula = model.NitCedula,
                    Correo = model.correo,
                    PersonaContacto = model.PersonaContacto,
                    CargoContacto = model.CargoContacto,
                    Telefono = model.Telefono,
                    Direccion = model.Direccion,
                    Ciudad = model.Ciudad,
                    Activo = model.Activo,
                    FechaCreacion = DateTime.Now
                };

                _context.Clientes.Add(cliente);

                await _context.SaveChangesAsync();

                return (true, "Cliente creado correctamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public async Task<(bool success, string message, ClienteVM data)> ObtenerCliente(int id)
        {
            var cliente = await _context.Clientes
                .Include(x => x.Cotizaciones)
                .FirstOrDefaultAsync(x => x.idCliente == id);

            if (cliente == null)
                return (false, "Cliente no encontrado", null!);

            return (true, "Datos encontrados",
                new ClienteVM
                {
                    idCliente = cliente.idCliente,
                    RazonSocial = cliente.RazonSocial,
                    NitCedula = cliente.NitCedula,
                    correo = cliente.Correo,
                    PersonaContacto = cliente.PersonaContacto,
                    CargoContacto = cliente.CargoContacto,
                    Telefono = cliente.Telefono,
                    Direccion = cliente.Direccion,
                    Ciudad = cliente.Ciudad,
                    Activo = cliente.Activo,
                    FechaCreacion = cliente.FechaCreacion,
                    TotalCotizaciones = cliente.Cotizaciones.Count
                });
        }
        public async Task<(bool success, string message)> ActualizarCliente(ClienteVM model)
        {
            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(x => x.idCliente == model.idCliente);

            if (cliente == null)
                return (false, "Cliente no encontrado");

            var existeNit = await _context.Clientes
                .AnyAsync(x =>
                    x.idCliente != model.idCliente &&
                    x.NitCedula == model.NitCedula);

            if (existeNit)
                return (false, "Ya existe un cliente con ese NIT");

            cliente.RazonSocial = model.RazonSocial;
            cliente.NitCedula = model.NitCedula;
            cliente.Correo = model.correo;
            cliente.PersonaContacto = model.PersonaContacto;
            cliente.CargoContacto = model.CargoContacto;
            cliente.Telefono = model.Telefono;
            cliente.Direccion = model.Direccion;
            cliente.Ciudad = model.Ciudad;
            cliente.Activo = model.Activo;

            await _context.SaveChangesAsync();

            return (true, "Cliente actualizado correctamente");
        }
        public async Task<(bool success, string message)> CambiarEstado(int id)
        {
            var cliente = await _context.Clientes
                .FindAsync(id);

            if (cliente == null)
                return (false, "Cliente no encontrado");

            cliente.Activo = !cliente.Activo;

            await _context.SaveChangesAsync();

            return (true,
                cliente.Activo
                    ? "Cliente activado"
                    : "Cliente desactivado");
        }
        public async Task<(bool success, string message, object data)> ObtenerDashboard()
        {
            var total = await _context.Clientes.CountAsync();

            var activos = await _context.Clientes
                .CountAsync(x => x.Activo);

            var inactivos = total - activos;

            return (true,
                "Datos encontrados",
                new
                {
                    totalClientes = total,
                    totalActivos = activos,
                    totalInactivos = inactivos
                });
        }
        public async Task<(bool success, string message, IEnumerable<ClienteVM> data, int totalRegistros)> ObtenerClientes(string? busqueda, bool soloActivos, int page, int pageSize)
        {
            var query = _context.Clientes
                .Include(x => x.Cotizaciones)
                .AsQueryable();

            if (soloActivos)
                query = query.Where(x => x.Activo);

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                query = query.Where(x =>
                        x.RazonSocial.Contains(busqueda) ||
                        x.NitCedula.Contains(busqueda) ||
                        x.Correo.Contains(busqueda) ||
                        x.Telefono.Contains(busqueda));
            }

            if (soloActivos)
            {
                query = query.Where(x => x.Activo);
            }

            var total = await query.CountAsync();

            var data = await query
                .OrderBy(x => x.RazonSocial)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new ClienteVM
                {
                    idCliente = x.idCliente,
                    RazonSocial = x.RazonSocial,
                    NitCedula = x.NitCedula,
                    correo = x.Correo,
                    PersonaContacto = x.PersonaContacto,
                    CargoContacto = x.CargoContacto,
                    Telefono = x.Telefono,
                    Ciudad = x.Ciudad,
                    Activo = x.Activo,
                    FechaCreacion = x.FechaCreacion,
                    TotalCotizaciones = x.Cotizaciones.Count
                })
                .ToListAsync();

            return (true, "Datos encontrados", data, total);
        }
        public async Task<List<ClienteVM>> BuscarClientes(string busqueda)
        {
            busqueda ??= string.Empty;

            return await _context.Clientes
                .Where(x =>
                    x.Activo &&
                    (
                        x.RazonSocial.Contains(busqueda) ||
                        x.NitCedula.Contains(busqueda) ||
                        x.Telefono.Contains(busqueda)
                    ))
                .OrderBy(x => x.RazonSocial)
                .Take(20)
                .Select(x => new ClienteVM
                {
                    idCliente = x.idCliente,
                    RazonSocial = x.RazonSocial,
                    NitCedula = x.NitCedula,
                    Telefono = x.Telefono,
                    Ciudad = x.Ciudad
                })
                .ToListAsync();
        }
    }
}
