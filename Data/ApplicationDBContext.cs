using AppServiceAndTravel.Models;
using Microsoft.EntityFrameworkCore;
using AppServiceAndTravel.Data.Seeds;
using AppServiceAndTravel.Areas.Admin.Models;

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
    public DbSet<Clientes> Clientes { get; set; }    
    public DbSet<Conductores> Conductores { get; set; }
    public DbSet<ConfiguracionGeneral> ConfiguracionGeneral { get; set; }
    public DbSet<ConfigNotificaciones> ConfiguracionNotificaciones { get; set; }    
    public DbSet<Cotizaciones> Cotizaciones { get; set; }
    public DbSet<FormatosCorreos> FormatosCorreos { get; set; }
    public DbSet<HistRefreshToken> HistRefreshToken { get; set; }
    public DbSet<HistLogin> HistLogin { get; set; }
    public DbSet<Notificaciones> Notificaciones { get; set; }
    public DbSet<Permisos> Permisos { get; set; }
    public DbSet<Procesos> Procesos { get; set; }
    public DbSet<Proveedores> Proveedores { get; set; }
    public DbSet<ProveedoresExternos> ProveedoresExternos { get; set; }
    public DbSet<Servicios> Servicios { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<RolesUsuarios> RolesUsuarios { get; set; }
    public DbSet<ApplicationUser> Usuarios { get; set; }
    public DbSet<ValidacionVehiculo> ValidacionesVehiculo { get; set; }
    public DbSet<Vehiculos> Vehiculos { get; set; }
    public DbSet<ActividadSistema> ActividadesSistema { get; set; }
    public DbSet<TipoActividadSistema> TiposActividadSistema { get; set; }
    public DbSet<LogSistema> LogsSistema { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfiguration(new procesoSeed());
        builder.ApplyConfiguration(new RolesSeed());
        builder.ApplyConfiguration(new RolesUsuariosSeed());
        builder.ApplyConfiguration(new PermissionsSeed());
        builder.ApplyConfiguration(new UserSeed());
        builder.ApplyConfiguration(new TypeActitySeed());

        builder.Entity<RolesUsuarios>(entity =>
        {
            entity.HasKey(p => new { p.idUsuario, p.idRol });

            entity.HasOne(c => c.Usuario)
                  .WithMany(c => c.RolesUsuarios)
                  .HasForeignKey(c => c.idUsuario)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.Rol)
                  .WithMany(c => c.RolesUsuarios)
                  .HasForeignKey(c => c.idRol)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Procesos>(entity =>
        {
            entity.HasKey(x => x.idProceso);

            entity.Property(x => x.idProceso)
                  .ValueGeneratedNever();

            entity.HasOne(x => x.idProcesoPadreNavigation)
                  .WithMany(x => x.inverseidProcesoPadreNavigation)
                  .HasForeignKey(x => x.idProcesoPadre)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Permisos>(entity =>
        {
            entity.HasKey(p => new { p.idProceso, p.idRol });

            entity.HasOne(c => c.proceso)
                  .WithMany(c => c.Permisos)
                  .HasForeignKey(c => c.idProceso)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.rol)
                  .WithMany(c => c.Permisos)
                  .HasForeignKey(c => c.idRol)
                  .OnDelete(DeleteBehavior.Restrict);
        });


        // ── Cotizacion ────────────────────────────────────────────────
        builder.Entity<Cotizaciones>(entity =>
        {
            entity.HasOne(c => c.Cliente)
                  .WithMany(cl => cl.Cotizaciones)
                  .HasForeignKey(c => c.idCliente)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.UsuarioCreador)
                  .WithMany()
                  .HasForeignKey(c => c.idUsuarioCreador)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(c => c.UsuarioAprobador)
                  .WithMany()
                  .HasForeignKey(c => c.idUsuarioAprobador)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.Property(c => c.Estado)
                  .HasConversion<string>();
        });

        // ── Servicio ──────────────────────────────────────────────────
        builder.Entity<Servicios>(entity =>
        {
            entity.HasOne(s => s.Cotizacion)
                  .WithOne(c => c.Servicio)
                  .HasForeignKey<Servicios>(s => s.idCotizacion)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.Vehiculo)
                  .WithMany(v => v.Servicios)
                  .HasForeignKey(s => s.idVehiculo)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.Conductor)
                  .WithMany(c => c.Servicios)
                  .HasForeignKey(s => s.idConductor)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(s => s.ProveedorExterno).WithMany()
                  .HasForeignKey(s => s.idProveedorExterno)
                  .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(s => s.UsuarioCreador)
                  .WithMany()
                  .HasForeignKey(s => s.idUsuarioCreador)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.Property(s => s.Estado)
                  .HasConversion<string>();
        });

        // ── Vehiculo ──────────────────────────────────────────────────
        builder.Entity<Vehiculos>(entity =>
        {
            entity.Property(v => v.Estado)
                  .HasConversion<string>();

            entity.Property(v => v.Estado).HasConversion<string>();
            entity.Property(v => v.TipoProveedor).HasConversion<string>();
            entity.HasIndex(v => v.Placa).IsUnique();
        });

        // ── Conductor ─────────────────────────────────────────────────
        builder.Entity<Conductores>(entity =>
        {
            entity.HasIndex(c => c.Cedula).IsUnique();
            entity.HasIndex(c => c.NumeroLicencia).IsUnique();
            entity.Property(c => c.TipoProveedor).HasConversion<string>();
        });

        // ── ValidacionVehiculo ─────────────────────────────────────────
        builder.Entity<ValidacionVehiculo>(entity =>
        {
            entity.HasOne(v => v.Vehiculo).WithMany()
             .HasForeignKey(v => v.idVehiculo).OnDelete(DeleteBehavior.Restrict)
                  .HasForeignKey(v => v.idVehiculo)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<ConfiguracionGeneral>(entity =>
        entity.HasData(new ConfiguracionGeneral { idConfiguracionGeneral = 1, NombreEmpresa = "Service And Travel" }));

    }
}



