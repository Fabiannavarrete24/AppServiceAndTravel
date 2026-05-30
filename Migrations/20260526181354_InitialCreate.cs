using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NitCedula = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ciudad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idCliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Conductores",
                columns: table => new
                {
                    idConductor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cedula = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroLicencia = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaLicencia = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaVencimientoLicencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoProveedor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmpresaExterna = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NitEmpresa = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TarifaExterna = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    ObservacionesExterno = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductores", x => x.idConductor);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConfiguracionGeneral",
                columns: table => new
                {
                    idConfiguracionGeneral = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEmpresa = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eslogan = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaLogo = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaFavicon = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ciudad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Departamento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono2 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SitioWeb = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NitEmpresa = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Moneda = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SimboloMoneda = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idioma = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZonaHoraria = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormatoFecha = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeparadorDecimal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeparadorMiles = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TemaSeleccionado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FuenteSistema = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TamanoFuenteBase = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorPrimario = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorSecundario = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorAcento = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorTexto = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorFondo = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorPeligro = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorAdvertencia = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NotificarPorcorreo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificarPorWhatsApp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DiasAlertaVencimiento = table.Column<int>(type: "int", nullable: false),
                    JwtSecretKey = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JwtIssuer = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JwtAudience = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JwtExpirationMinutes = table.Column<int>(type: "int", nullable: false),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificadoPorId = table.Column<int>(type: "int", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionGeneral", x => x.idConfiguracionGeneral);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConfiguracionNotificaciones",
                columns: table => new
                {
                    idConfigNotificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    correoRemitente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreRemitente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtpServer = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtpPort = table.Column<int>(type: "int", nullable: false),
                    smtpUserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtpPassword = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    requiereSSL = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    requiereTSL = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProveedorWhatsApp = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhatsAppApiUrl = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhatsAppApiKey = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhatsAppNumeroEmpresa = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhatsAppValidado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    WhatsAppFechaValidacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificadoPorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionNotificaciones", x => x.idConfigNotificacion);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormatosCorreos",
                columns: table => new
                {
                    idCorreo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    abreviatura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mensaje = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormatosCorreos", x => x.idCorreo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistLogin",
                columns: table => new
                {
                    idHist = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    userName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    inSesion = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    mensaje = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistLogin", x => x.idHist);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    idNotificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    titulo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    mensjae = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    leido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    categoriaNotificacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.idNotificacion);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Procesos",
                columns: table => new
                {
                    idProceso = table.Column<int>(type: "int", nullable: false),
                    url = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    proceso = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    area = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    controlador = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    icono = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    idProcesoPadre = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesos", x => x.idProceso);
                    table.ForeignKey(
                        name: "FK_Procesos_Procesos_idProcesoPadre",
                        column: x => x.idProcesoPadre,
                        principalTable: "Procesos",
                        principalColumn: "idProceso",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    idProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.idProveedor);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProveedoresExternos",
                columns: table => new
                {
                    IdProveedorExterno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RazonSocial = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NitCedula = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contacto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoServicio = table.Column<int>(type: "int", nullable: false),
                    TarifaBase = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Observaciones = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedoresExternos", x => x.IdProveedorExterno);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.idRol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposActividadSistema",
                columns: table => new
                {
                    idTipoActividadSistema = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Activo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposActividadSistema", x => x.idTipoActividadSistema);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombreCompleto = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cargo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    avatar = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    admin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    crypt = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hast = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    restaurada = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    confirmada = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    token = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    refreshToken = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaExpiracionToken = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    refreshTokenExpiry = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    fechaBaja = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ultimoAcceso = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    fechaCambioClave = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    idVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    CapacidadPasajeros = table.Column<int>(type: "int", nullable: false),
                    CapacidadCarga = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoProveedor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PropietarioNombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PropietarioCedula = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PropietarioTelefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Propietariocorreo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TarifaExterna = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    FechaVencimientoSOAT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaVencimientoTecnoMecanica = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaVencimientoSeguro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RutaSOAT = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaTecnoMecanica = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaSeguro = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observaciones = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.idVehiculo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    idProceso = table.Column<int>(type: "int", nullable: false),
                    idRol = table.Column<int>(type: "int", nullable: false),
                    lectura = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    crea = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    edita = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    elimina = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => new { x.idProceso, x.idRol });
                    table.ForeignKey(
                        name: "FK_Permisos_Procesos_idProceso",
                        column: x => x.idProceso,
                        principalTable: "Procesos",
                        principalColumn: "idProceso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permisos_Roles_idRol",
                        column: x => x.idRol,
                        principalTable: "Roles",
                        principalColumn: "idRol",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActividadesSistema",
                columns: table => new
                {
                    idActividadSistema = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    UsuarioNombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Entidad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntidadId = table.Column<int>(type: "int", nullable: true),
                    EstadoAnterior = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoNuevo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IpAddress = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idTipoActividadSistema = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadesSistema", x => x.idActividadSistema);
                    table.ForeignKey(
                        name: "FK_ActividadesSistema_TiposActividadSistema_idTipoActividadSist~",
                        column: x => x.idTipoActividadSistema,
                        principalTable: "TiposActividadSistema",
                        principalColumn: "idTipoActividadSistema",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActividadesSistema_Usuarios_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    idCotizacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    Origen = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destino = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaServicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DescripcionCarga = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumPasajeros = table.Column<int>(type: "int", nullable: false),
                    ValorCotizado = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ValorAprobado = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaAprobacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    idUsuarioCreador = table.Column<int>(type: "int", nullable: true),
                    idUsuarioAprobador = table.Column<int>(type: "int", nullable: true),
                    ObservacionesAprobacion = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObservacionesRechazo = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.idCotizacion);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Clientes_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Clientes",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Usuarios_idUsuarioAprobador",
                        column: x => x.idUsuarioAprobador,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Usuarios_idUsuarioCreador",
                        column: x => x.idUsuarioCreador,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistRefreshToken",
                columns: table => new
                {
                    IdHistRefreshToken = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshToken = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaExpiracion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    idUsuarioNavigationidUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistRefreshToken", x => x.IdHistRefreshToken);
                    table.ForeignKey(
                        name: "FK_HistRefreshToken_Usuarios_idUsuarioNavigationidUsuario",
                        column: x => x.idUsuarioNavigationidUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LogsSistema",
                columns: table => new
                {
                    idLogSistema = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nivel = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Evento = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensaje = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Detalle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    UsuarioNombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MetodoHttp = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IpAddress = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserAgent = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsSistema", x => x.idLogSistema);
                    table.ForeignKey(
                        name: "FK_LogsSistema_Usuarios_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolesUsuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    idRol = table.Column<int>(type: "int", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    idUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesUsuarios", x => new { x.idUsuario, x.idRol });
                    table.ForeignKey(
                        name: "FK_RolesUsuarios_Roles_idRol",
                        column: x => x.idRol,
                        principalTable: "Roles",
                        principalColumn: "idRol",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolesUsuarios_Usuarios_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ValidacionesVehiculo",
                columns: table => new
                {
                    idValidacionVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    idServicio = table.Column<int>(type: "int", nullable: true),
                    FechaValidacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SOATVigente = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TecnoVigente = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeguroVigente = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EstadoActivo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LicenciaConductorVigente = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Resultado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidacionesVehiculo", x => x.idValidacionVehiculo);
                    table.ForeignKey(
                        name: "FK_ValidacionesVehiculo_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    idServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idCotizacion = table.Column<int>(type: "int", nullable: false),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    idConductor = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idProveedorExterno = table.Column<int>(type: "int", nullable: true),
                    VehiculoExternoPlaca = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehiculoExternoDescripcion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConductorExternoNombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConductorExternoCedula = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConductorExternoTelefono = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsaRecursoExterno = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CostoExterno = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    FechaServicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observaciones = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    idUsuarioCreador = table.Column<int>(type: "int", nullable: true),
                    NotificacioncorreoEnviada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificacionWhatsAppEnviada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaNotificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.idServicio);
                    table.ForeignKey(
                        name: "FK_Servicios_Conductores_idConductor",
                        column: x => x.idConductor,
                        principalTable: "Conductores",
                        principalColumn: "idConductor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicios_Cotizaciones_idCotizacion",
                        column: x => x.idCotizacion,
                        principalTable: "Cotizaciones",
                        principalColumn: "idCotizacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicios_ProveedoresExternos_idProveedorExterno",
                        column: x => x.idProveedorExterno,
                        principalTable: "ProveedoresExternos",
                        principalColumn: "IdProveedorExterno",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Servicios_Usuarios_idUsuarioCreador",
                        column: x => x.idUsuarioCreador,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicios_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ConfiguracionGeneral",
                columns: new[] { "idConfiguracionGeneral", "Ciudad", "ColorAcento", "ColorAdvertencia", "ColorFondo", "ColorPeligro", "ColorPrimario", "ColorSecundario", "ColorTexto", "Departamento", "DiasAlertaVencimiento", "Direccion", "Eslogan", "FormatoFecha", "FuenteSistema", "Idioma", "JwtAudience", "JwtExpirationMinutes", "JwtIssuer", "JwtSecretKey", "ModificadoPorId", "Moneda", "NitEmpresa", "NombreEmpresa", "NotificarPorWhatsApp", "NotificarPorcorreo", "Pais", "RutaFavicon", "RutaLogo", "SeparadorDecimal", "SeparadorMiles", "SimboloMoneda", "SitioWeb", "TamanoFuenteBase", "Telefono", "Telefono2", "TemaSeleccionado", "UltimaModificacion", "ZonaHoraria", "correo" },
                values: new object[] { 1, null, "#16a34a", "#f59e0b", "#f0f4f8", "#dc2626", "#0080ff", "#52e5ff", "#1e293b", null, 30, null, null, "dd/MM/yyyy", "Inter", "es-CO", "AppServiceAndTravelApp", 60, "AppServiceAndTravelAPI", "EstaEsUnaLlaveSecretaSeguraYBienLarga", null, "COP", null, "Service And Travel", true, true, "Colombia", null, null, ",", ".", "$", null, "14px", null, null, "Azul corporativo", new DateTime(2026, 5, 26, 13, 13, 53, 752, DateTimeKind.Local).AddTicks(2490), "America/Bogota", null });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4129), "fa-user-shield", null, "Seguridad", null },
                    { 7, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4144), "fa-users-rectangle", null, "Proveedores", null },
                    { 10, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4148), "fa-address-card", null, "Conductores", null },
                    { 13, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4152), "fa-car", null, "Vehiculos", null },
                    { 16, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4157), "fa-handshake", null, "Cotizaciones", null },
                    { 19, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4161), "fa-handshake", null, "Clientes", null },
                    { 22, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4167), "fa-car-side", null, "Servicios", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "idRol", "fechaCreacion", "fechaModificacion", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4431), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4432), "Administrador" },
                    { 2, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4436), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4437), "Usuarios" }
                });

            migrationBuilder.InsertData(
                table: "TiposActividadSistema",
                columns: new[] { "idTipoActividadSistema", "Activo", "Codigo", "Color", "Icono", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "COTIZACION_CREADA", "primary", "bi-file-earmark-plus", "Cotización Creada" },
                    { 2, true, "COTIZACION_EDITADA", "warning", "bi-pencil-square", "Cotización Editada" },
                    { 3, true, "COTIZACION_APROBADA", "success", "bi-check-circle", "Cotización Aprobada" },
                    { 4, true, "COTIZACION_RECHAZADA", "danger", "bi-x-circle", "Cotización Rechazada" },
                    { 5, true, "COTIZACION_CANCELADA", "secondary", "bi-slash-circle", "Cotización Cancelada" },
                    { 6, true, "SERVICIO_CREADO", "primary", "bi-truck", "Servicio Creado" },
                    { 7, true, "SERVICIO_PROGRAMADO", "info", "bi-calendar-event", "Servicio Programado" },
                    { 8, true, "SERVICIO_ASIGNADO", "warning", "bi-person-check", "Servicio Asignado" },
                    { 9, true, "SERVICIO_INICIADO", "primary", "bi-play-circle", "Servicio Iniciado" },
                    { 10, true, "SERVICIO_EN_CURSO", "warning", "bi-arrow-repeat", "Servicio En Curso" },
                    { 11, true, "SERVICIO_FINALIZADO", "success", "bi-check2-all", "Servicio Finalizado" },
                    { 12, true, "SERVICIO_CANCELADO", "danger", "bi-x-octagon", "Servicio Cancelado" },
                    { 13, true, "VEHICULO_ASIGNADO", "info", "bi-truck-flatbed", "Vehículo Asignado" },
                    { 14, true, "VEHICULO_LIBERADO", "secondary", "bi-truck", "Vehículo Liberado" },
                    { 15, true, "CONDUCTOR_ASIGNADO", "primary", "bi-person-badge", "Conductor Asignado" },
                    { 16, true, "CONDUCTOR_LIBERADO", "secondary", "bi-person-dash", "Conductor Liberado" },
                    { 17, true, "USUARIO_CREADO", "success", "bi-person-plus", "Usuario Creado" },
                    { 18, true, "USUARIO_ACTUALIZADO", "warning", "bi-person-gear", "Usuario Actualizado" },
                    { 19, true, "USUARIO_DESACTIVADO", "danger", "bi-person-x", "Usuario Desactivado" },
                    { 20, true, "LOGIN", "success", "bi-box-arrow-in-right", "Inicio de Sesión" },
                    { 21, true, "LOGOUT", "secondary", "bi-box-arrow-right", "Cierre de Sesión" },
                    { 22, true, "DOCUMENTO_SUBIDO", "primary", "bi-upload", "Documento Subido" },
                    { 23, true, "PDF_GENERADO", "danger", "bi-file-earmark-pdf", "PDF Generado" },
                    { 24, true, "WHATSAPP_ENVIADO", "success", "bi-whatsapp", "WhatsApp Enviado" },
                    { 25, true, "EMAIL_ENVIADO", "info", "bi-envelope", "Correo Enviado" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "idUsuario", "activo", "admin", "avatar", "cargo", "confirmada", "correo", "crypt", "fechaBaja", "fechaCambioClave", "fechaCreacion", "fechaExpiracionToken", "fechaModificacion", "hast", "nombreCompleto", "password", "refreshToken", "refreshTokenExpiry", "restaurada", "telefono", "token", "ultimoAcceso", "userName" },
                values: new object[] { 1, true, true, null, "Administrador", true, "admin@correo.com", true, null, new DateTime(2026, 8, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4952), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4951), null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4953), true, "Administrador", "admin", null, null, false, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4932), "admin" });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "idProceso", "idRol", "crea", "edita", "elimina", "fechaCreacion", "lectura" },
                values: new object[,]
                {
                    { 1, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4702), true },
                    { 7, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4768), true },
                    { 10, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4771), true },
                    { 13, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4775), true },
                    { 16, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4778), true },
                    { 19, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4781), true },
                    { 22, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4784), true }
                });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[,]
                {
                    { 2, null, null, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4135), "fa-gear", 1, "Configuracion", null },
                    { 8, "Admin", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4145), null, 7, "Listado de Proveedores", "Proveedores" },
                    { 9, "Admin", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4146), null, 7, "Nuevo Proveedor", "CrearProveedor" },
                    { 11, "Operaciones", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4149), null, 10, "Listado de Conductores", "Conductores" },
                    { 12, "Operaciones", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4151), null, 10, "Nuevo Conductor", "CrearConductor" },
                    { 14, "Operaciones", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4154), null, 13, "Listado de Vehiculos", "Vehiculos" },
                    { 15, "Operaciones", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4155), null, 13, "Nuevo Vehiculo", "CrearVehiculo" },
                    { 17, "Comercial", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4158), null, 16, "Historial", "Cotizaciones" },
                    { 18, "Comercial", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4160), null, 16, "Nueva Cotización", "CrearCotizacion" },
                    { 20, "Comercial", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4163), null, 19, "Listado de Clientes", "Clientes" },
                    { 21, "Comercial", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4164), null, 19, "Nuevo Cliente", "CrearCliente" },
                    { 23, "Operaciones", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4169), null, 22, "Historial", "Servicios" },
                    { 24, "Operaciones", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4171), null, 22, "Nuevo Servicio", "CrearServicio" }
                });

            migrationBuilder.InsertData(
                table: "RolesUsuarios",
                columns: new[] { "idRol", "idUsuario", "fechaCreacion", "idUser" },
                values: new object[] { 1, 1, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4581), null });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "idProceso", "idRol", "crea", "edita", "elimina", "fechaCreacion", "lectura" },
                values: new object[,]
                {
                    { 2, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4709), true },
                    { 8, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4769), true },
                    { 9, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4770), true },
                    { 11, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4772), true },
                    { 12, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4773), true },
                    { 14, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4776), true },
                    { 15, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4777), true },
                    { 17, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4779), true },
                    { 18, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4780), true },
                    { 20, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4782), true },
                    { 21, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4783), true },
                    { 23, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4786), true },
                    { 24, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4787), true }
                });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[,]
                {
                    { 3, "Admin", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4137), null, 2, "Configuracion General", "ConfiguracionGeneral" },
                    { 4, "Admin", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4139), null, 2, "Usuarios", "Usuarios" },
                    { 5, "Admin", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4140), null, 2, "Roles", "Roles" },
                    { 6, "Admin", "App", new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4142), null, 2, "Permisos", "Permisos" }
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "idProceso", "idRol", "crea", "edita", "elimina", "fechaCreacion", "lectura" },
                values: new object[,]
                {
                    { 3, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4762), true },
                    { 4, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4764), true },
                    { 5, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4765), true },
                    { 6, 1, false, true, true, new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4767), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesSistema_idTipoActividadSistema",
                table: "ActividadesSistema",
                column: "idTipoActividadSistema");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesSistema_idUsuario",
                table: "ActividadesSistema",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Conductores_Cedula",
                table: "Conductores",
                column: "Cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conductores_NumeroLicencia",
                table: "Conductores",
                column: "NumeroLicencia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_idCliente",
                table: "Cotizaciones",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_idUsuarioAprobador",
                table: "Cotizaciones",
                column: "idUsuarioAprobador");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_idUsuarioCreador",
                table: "Cotizaciones",
                column: "idUsuarioCreador");

            migrationBuilder.CreateIndex(
                name: "IX_HistRefreshToken_idUsuarioNavigationidUsuario",
                table: "HistRefreshToken",
                column: "idUsuarioNavigationidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_LogsSistema_idUsuario",
                table: "LogsSistema",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_idRol",
                table: "Permisos",
                column: "idRol");

            migrationBuilder.CreateIndex(
                name: "IX_Procesos_idProcesoPadre",
                table: "Procesos",
                column: "idProcesoPadre");

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsuarios_idRol",
                table: "RolesUsuarios",
                column: "idRol");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idConductor",
                table: "Servicios",
                column: "idConductor");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idCotizacion",
                table: "Servicios",
                column: "idCotizacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idProveedorExterno",
                table: "Servicios",
                column: "idProveedorExterno");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idUsuarioCreador",
                table: "Servicios",
                column: "idUsuarioCreador");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idVehiculo",
                table: "Servicios",
                column: "idVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_ValidacionesVehiculo_idVehiculo",
                table: "ValidacionesVehiculo",
                column: "idVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Placa",
                table: "Vehiculos",
                column: "Placa",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActividadesSistema");

            migrationBuilder.DropTable(
                name: "ConfiguracionGeneral");

            migrationBuilder.DropTable(
                name: "ConfiguracionNotificaciones");

            migrationBuilder.DropTable(
                name: "FormatosCorreos");

            migrationBuilder.DropTable(
                name: "HistLogin");

            migrationBuilder.DropTable(
                name: "HistRefreshToken");

            migrationBuilder.DropTable(
                name: "LogsSistema");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "RolesUsuarios");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "ValidacionesVehiculo");

            migrationBuilder.DropTable(
                name: "TiposActividadSistema");

            migrationBuilder.DropTable(
                name: "Procesos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Conductores");

            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "ProveedoresExternos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
