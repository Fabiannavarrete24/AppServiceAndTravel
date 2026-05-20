using AppServiceAndTravel.Models;
using Microsoft.EntityFrameworkCore;
using AppServiceAndTravel.Data.Seeds;

namespace AppServiceAndTravel.Data;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
    }
    private readonly IConfiguration? _configuration;

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IConfiguration? configuration = null)
        : base(options)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (optionsBuilder.IsConfigured) return;

    var provider = _configuration!["ConnectionStrings:DbProvider"]?.ToLower();

    switch (provider)
    {
        case "mysql":
            optionsBuilder.UseMySql(
                _configuration.GetConnectionString("MysqlConnection"),
                ServerVersion.AutoDetect(_configuration.GetConnectionString("MysqlConnection")));
            break;
        case "postgresql":
            optionsBuilder.UseNpgsql(
                _configuration.GetConnectionString("PostgreSqlConnection"));
            break;
    }
}
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Conductor> Conductores { get; set; }
    public DbSet<ProveedorExterno> ProveedoresExternos { get; set; }
    public DbSet<Cotizacion> Cotizaciones { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<ValidacionVehiculo> ValidacionesVehiculo { get; set; }
    public DbSet<ConfiguracionEmpresa> ConfiguracionEmpresa { get; set; }
    public DbSet<HistRefreshToken> HistRefreshToken { get; set; }
    public DbSet<HistLogin> HistLogin { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Permisos> Permisos { get; set; }
    public DbSet<Procesos> Procesos { get; set; }
    public DbSet<Proveedores> Proveedores { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<RolesUsuarios> RolsUsuarios { get; set; }
    public DbSet<ApplicationUser> Usuarios { get; set; }    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new PermissionsSeed());
        builder.ApplyConfiguration(new procesoSeed());
        builder.ApplyConfiguration(new RolesSeed());
        builder.ApplyConfiguration(new RolesUsuariosSeed());
        builder.ApplyConfiguration(new UserSeed());

        builder.Entity<RolesUsuarios>(entity =>
        {
            entity.HasOne(c => c.User)
                  .WithMany()
                  .HasForeignKey(c => c.idUsuario)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.Rol)
                  .WithMany()
                  .HasForeignKey(c => c.idRol)
                  .OnDelete(DeleteBehavior.SetNull);
        });
        builder.Entity<Permisos>(entity =>
        {
            entity.HasOne(c => c.proceso)
                  .WithMany()
                  .HasForeignKey(c => c.IdProceso)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.Rol)
                  .WithMany()
                  .HasForeignKey(c => c.idRol)
                  .OnDelete(DeleteBehavior.SetNull);
        });


        // ── Cotizacion ────────────────────────────────────────────────
        builder.Entity<Cotizacion>(entity =>
        {
            entity.HasOne(c => c.Cliente)
                  .WithMany(cl => cl.Cotizaciones)
                  .HasForeignKey(c => c.ClienteId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.UsuarioCreador)
                  .WithMany()
                  .HasForeignKey(c => c.UsuarioCreadorId)
                  .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(c => c.UsuarioAprobador)
                  .WithMany()
                  .HasForeignKey(c => c.UsuarioAprobadorId)
                  .OnDelete(DeleteBehavior.SetNull);

            entity.Property(c => c.Estado)
                  .HasConversion<string>();
        });

        // ── Servicio ──────────────────────────────────────────────────
        builder.Entity<Servicio>(entity =>
        {
            entity.HasOne(s => s.Cotizacion)
                  .WithOne(c => c.Servicio)
                  .HasForeignKey<Servicio>(s => s.CotizacionId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.Vehiculo)
                  .WithMany(v => v.Servicios)
                  .HasForeignKey(s => s.VehiculoId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.Conductor)
                  .WithMany(c => c.Servicios)
                  .HasForeignKey(s => s.ConductorId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.ProveedorExterno).WithMany()
                  .HasForeignKey(s => s.ProveedorExternoId)
                  .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(s => s.UsuarioCreador)
                  .WithMany()
                  .HasForeignKey(s => s.UsuarioCreadorId)
                  .OnDelete(DeleteBehavior.SetNull);

            entity.Property(s => s.Estado)
                  .HasConversion<string>();
        });

        // ── Vehiculo ──────────────────────────────────────────────────
        builder.Entity<Vehiculo>(entity =>
        {
            entity.Property(v => v.Estado)
                  .HasConversion<string>();

            entity.Property(v => v.Estado).HasConversion<string>();
            entity.Property(v => v.TipoProveedor).HasConversion<string>();
            entity.HasIndex(v => v.Placa).IsUnique();
        });

        // ── Conductor ─────────────────────────────────────────────────
        builder.Entity<Conductor>(entity =>
        {
            entity.HasIndex(c => c.Cedula).IsUnique();
            entity.HasIndex(c => c.NumeroLicencia).IsUnique();
            entity.Property(c => c.TipoProveedor).HasConversion<string>();
        });

        // ── ValidacionVehiculo ─────────────────────────────────────────
        builder.Entity<ValidacionVehiculo>(entity =>
        {
            entity.HasOne(v => v.Vehiculo).WithMany()
             .HasForeignKey(v => v.VehiculoId).OnDelete(DeleteBehavior.Restrict)
                  .HasForeignKey(v => v.VehiculoId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<ConfiguracionEmpresa>(entity =>
        entity.HasData(new ConfiguracionEmpresa { Id = 1, NombreEmpresa = "AppServiceAndTravel" }));

    }
}



