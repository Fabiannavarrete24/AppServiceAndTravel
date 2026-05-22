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
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Clientes", x => x.Id);
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
                    correoRemitente = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreRemitente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NotificarPorcorreo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificarPorWhatsApp = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DiasAlertaVencimiento = table.Column<int>(type: "int", nullable: false),
                    JwtSecret = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JwtExpiracionMinutos = table.Column<int>(type: "int", nullable: false),
                    UltimaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificadoPorId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    smtpServer = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtpPort = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtpUserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    smtpPassword = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    requiereSSL = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    requiereTSL = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionNotificaciones", x => x.smtpServer);
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
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_ProveedoresExternos", x => x.Id);
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
                    admin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    crypt = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hast = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    fechaBaja = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaCambioClave = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    fechaExpiracionToken = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ultimoAcceso = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    restaurada = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    confirmada = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    token = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    avatar = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    refreshToken = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    refreshTokenExpiry = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                name: "Cotizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Origen = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destino = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaServicioRequerido = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DescripcionCarga = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumPasajeros = table.Column<int>(type: "int", nullable: false),
                    ValorCotizado = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ValorAprobado = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaAprobacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UsuarioCreadorId = table.Column<int>(type: "int", nullable: true),
                    UsuarioAprobadorId = table.Column<int>(type: "int", nullable: true),
                    ObservacionesAprobacion = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObservacionesRechazo = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Usuarios_UsuarioAprobadorId",
                        column: x => x.UsuarioAprobadorId,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Usuarios_UsuarioCreadorId",
                        column: x => x.UsuarioCreadorId,
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CotizacionId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    ConductorId = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProveedorExternoId = table.Column<int>(type: "int", nullable: true),
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
                    UsuarioCreadorId = table.Column<int>(type: "int", nullable: true),
                    NotificacioncorreoEnviada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificacionWhatsAppEnviada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FechaNotificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_Conductores_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Conductores",
                        principalColumn: "idConductor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicios_Cotizaciones_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicios_ProveedoresExternos_ProveedorExternoId",
                        column: x => x.ProveedorExternoId,
                        principalTable: "ProveedoresExternos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Servicios_Usuarios_UsuarioCreadorId",
                        column: x => x.UsuarioCreadorId,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicios_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ConfiguracionGeneral",
                columns: new[] { "idConfiguracionGeneral", "Ciudad", "ColorAcento", "ColorFondo", "ColorPrimario", "ColorSecundario", "ColorTexto", "DiasAlertaVencimiento", "Direccion", "Eslogan", "FormatoFecha", "Idioma", "JwtExpiracionMinutos", "JwtSecret", "ModificadoPorId", "Moneda", "NitEmpresa", "NombreEmpresa", "NombreRemitente", "NotificarPorWhatsApp", "NotificarPorcorreo", "Pais", "RutaFavicon", "RutaLogo", "SeparadorDecimal", "SeparadorMiles", "SimboloMoneda", "SitioWeb", "Telefono", "Telefono2", "UltimaModificacion", "ZonaHoraria", "correo", "correoRemitente" },
                values: new object[] { 1, null, "#16a34a", "#f0f4f8", "#1a6fc4", "#0f1c2e", "#1e293b", 30, null, null, "dd/MM/yyyy", "es-CO", 60, null, null, "COP", null, "Service And Travel", null, true, true, "Colombia", null, null, ",", ".", "$", null, null, null, new DateTime(2026, 5, 22, 9, 22, 58, 330, DateTimeKind.Local).AddTicks(9319), "America/Bogota", null, null });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4679), "fa-gear", null, "Configuracion", null },
                    { 2, null, null, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4688), "fa-shop", null, "Productos", null },
                    { 11, null, null, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4703), "fa-store", null, "Ventas", "Ventas" },
                    { 12, null, "Home", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4704), null, null, "Dashboard", "index" },
                    { 14, null, "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4739), "fa-shop", null, "Productos", "Products" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "idRol", "fechaCreacion", "fechaModificacion", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4968), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4968), "Administrador" },
                    { 2, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4973), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4973), "Usuarios" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "idUsuario", "activo", "admin", "avatar", "cargo", "confirmada", "correo", "crypt", "fechaBaja", "fechaCambioClave", "fechaCreacion", "fechaExpiracionToken", "fechaModificacion", "hast", "nombreCompleto", "password", "refreshToken", "refreshTokenExpiry", "restaurada", "telefono", "token", "ultimoAcceso", "userName" },
                values: new object[] { 1, true, true, null, "Administrador", true, "admin@correo.com", true, null, new DateTime(2026, 8, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5151), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5150), null, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5152), true, "Administrador", "admin", null, null, false, null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[,]
                {
                    { 3, null, null, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4690), "fa-user", 1, "Usuarios", null },
                    { 5, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4693), null, 1, "Apariencia", "Appearance" },
                    { 6, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4695), null, 1, "Base de datos", "DatabaseConnections" },
                    { 7, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4697), null, 2, "Gestion de productos", "ProductsManagement" },
                    { 9, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4700), null, 1, "Provedores", "SupplierManagement" },
                    { 10, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4701), null, 1, "Sistema", "SystemConfiguration" },
                    { 13, null, "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4705), "fa-cart-shopping", 11, "Venta", "Sales" },
                    { 15, null, "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4740), null, 14, "Gestion de Productos", "ProductsManagement" },
                    { 16, null, "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4742), null, 14, "Pedidos", "Orders" },
                    { 17, null, "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4743), null, 14, "Gestion de Pedidos", "OrdersManagement" }
                });

            migrationBuilder.InsertData(
                table: "RolesUsuarios",
                columns: new[] { "idRol", "idUsuario", "fechaCreacion", "idUser" },
                values: new object[] { 1, 1, new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5058), null });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[,]
                {
                    { 4, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4691), null, 3, "Users", "AdminManagement" },
                    { 8, "Admin", "App", new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4698), null, 3, "notification", "RolPermissions" }
                });

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
                name: "IX_Cotizaciones_ClienteId",
                table: "Cotizaciones",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_UsuarioAprobadorId",
                table: "Cotizaciones",
                column: "UsuarioAprobadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_UsuarioCreadorId",
                table: "Cotizaciones",
                column: "UsuarioCreadorId");

            migrationBuilder.CreateIndex(
                name: "IX_HistRefreshToken_idUsuarioNavigationidUsuario",
                table: "HistRefreshToken",
                column: "idUsuarioNavigationidUsuario");

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
                name: "IX_Servicios_ConductorId",
                table: "Servicios",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CotizacionId",
                table: "Servicios",
                column: "CotizacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_ProveedorExternoId",
                table: "Servicios",
                column: "ProveedorExternoId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_UsuarioCreadorId",
                table: "Servicios",
                column: "UsuarioCreadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_VehiculoId",
                table: "Servicios",
                column: "VehiculoId");

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
