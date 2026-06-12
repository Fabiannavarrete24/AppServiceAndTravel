using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class updateVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaVencimientoSOAT",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "FechaVencimientoSeguro",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "FechaVencimientoTecnoMecanica",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PropietarioCedula",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PropietarioNombre",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PropietarioTelefono",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Propietariocorreo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "RutaSOAT",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "RutaSeguro",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "RutaTecnoMecanica",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TarifaExterna",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "NitEmpresa",
                table: "Conductores",
                newName: "NitExterno");

            migrationBuilder.RenameColumn(
                name: "EmpresaExterna",
                table: "Conductores",
                newName: "RazonSocialExterna");

            migrationBuilder.AddColumn<int>(
                name: "CapacidadPasajerosSentados",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaseVehiculo",
                table: "Vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "ClasicoAntiguo",
                table: "Vehiculos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Vehiculos",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Linea",
                table: "Vehiculos",
                type: "varchar(60)",
                maxLength: 60,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ModalidadServicio",
                table: "Vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ModalidadTransporte",
                table: "Vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "NumeroEjes",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PesoBrutoVehicular",
                table: "Vehiculos",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Puertas",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Repotenciado",
                table: "Vehiculos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TipoServicio",
                table: "Vehiculos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "VehiculoEnsenanza",
                table: "Vehiculos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CategoriaLicenciaAnterior",
                table: "Conductores",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EstadoConductor",
                table: "Conductores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoLicencia",
                table: "Conductores",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoPersona",
                table: "Conductores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaExpedicionLicencia",
                table: "Conductores",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Conductores",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroInscripcion",
                table: "Conductores",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "OrganismoTransitoCancelaLicencia",
                table: "Conductores",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "OrganismoTransitoExpideLicencia",
                table: "Conductores",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RestriccionesLicencia",
                table: "Conductores",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RetencionLicencia",
                table: "Conductores",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "TieneRetencionLicencia",
                table: "Conductores",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "VehiculoBlindaje",
                columns: table => new
                {
                    idBlindaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    Blindado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NivelBlindaje = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaBlindaje = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaDesblindaje = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoBlindaje", x => x.idBlindaje);
                    table.ForeignKey(
                        name: "FK_VehiculoBlindaje_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoCaracteristicas",
                columns: table => new
                {
                    idCaracteristica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    NumeroSerie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroMotor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroChasis = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroVIN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cilindraje = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoCarroceria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoCombustible = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoCaracteristicas", x => x.idCaracteristica);
                    table.ForeignKey(
                        name: "FK_VehiculoCaracteristicas_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoMatriculas",
                columns: table => new
                {
                    idMatricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    LicenciaTransito = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaMatriculaInicial = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AutoridadTransito = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GravamenesPropiedad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoMatriculas", x => x.idMatricula);
                    table.ForeignKey(
                        name: "FK_VehiculoMatriculas_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoPolizaRC",
                columns: table => new
                {
                    idPolizaRC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    NumeroPoliza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPoliza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaExpedicion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaInicioVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaFinVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EntidadExpide = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaDocumento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoPolizaRC", x => x.idPolizaRC);
                    table.ForeignKey(
                        name: "FK_VehiculoPolizaRC_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoPropietarios",
                columns: table => new
                {
                    idPropietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cedula = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TarifaExterna = table.Column<decimal>(type: "decimal(65,30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoPropietarios", x => x.idPropietario);
                    table.ForeignKey(
                        name: "FK_VehiculoPropietarios_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoRegrabaciones",
                columns: table => new
                {
                    idRegrabacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    RegrabacionMotor = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NumeroRegrabacionMotor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegrabacionChasis = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NumeroRegrabacionChasis = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegrabacionSerie = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NumeroRegrabacionSerie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegrabacionVIN = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NumeroRegrabacionVIN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoRegrabaciones", x => x.idRegrabacion);
                    table.ForeignKey(
                        name: "FK_VehiculoRegrabaciones_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoRTM",
                columns: table => new
                {
                    idRTM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    TipoRevision = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaExpedicion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CDAExpide = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroCertificado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaDocumento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoRTM", x => x.idRTM);
                    table.ForeignKey(
                        name: "FK_VehiculoRTM_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoSOAT",
                columns: table => new
                {
                    idSOAT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    NumeroPoliza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaExpedicion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaInicioVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaFinVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EntidadExpide = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RutaDocumento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoSOAT", x => x.idSOAT);
                    table.ForeignKey(
                        name: "FK_VehiculoSOAT_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VehiculoTarjetaOperacion",
                columns: table => new
                {
                    idTarjetaOperacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idVehiculo = table.Column<int>(type: "int", nullable: false),
                    EmpresaAfiliadora = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RadioAccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroTarjetaOperacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaExpedicion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaInicioVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FechaFinVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculoTarjetaOperacion", x => x.idTarjetaOperacion);
                    table.ForeignKey(
                        name: "FK_VehiculoTarjetaOperacion_Vehiculos_idVehiculo",
                        column: x => x.idVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "idVehiculo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 9, 9, 2, 16, 800, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1697), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1702), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1703), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1705), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1706), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1732), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1738), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1740), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1742), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1743), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1744), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1746), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1747), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1749), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1750), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1751), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1752), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1754), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1756), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1757), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1758), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1759), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1761), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1762), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1763), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1764), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1765), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1767), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1768), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1769), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1770), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1600), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1603), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1903), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1903), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1904), new DateTime(2026, 6, 9, 14, 2, 16, 797, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoBlindaje_idVehiculo",
                table: "VehiculoBlindaje",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoCaracteristicas_idVehiculo",
                table: "VehiculoCaracteristicas",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoMatriculas_idVehiculo",
                table: "VehiculoMatriculas",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoPolizaRC_idVehiculo",
                table: "VehiculoPolizaRC",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoPropietarios_idVehiculo",
                table: "VehiculoPropietarios",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoRegrabaciones_idVehiculo",
                table: "VehiculoRegrabaciones",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoRTM_idVehiculo",
                table: "VehiculoRTM",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoSOAT_idVehiculo",
                table: "VehiculoSOAT",
                column: "idVehiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoTarjetaOperacion_idVehiculo",
                table: "VehiculoTarjetaOperacion",
                column: "idVehiculo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiculoBlindaje");

            migrationBuilder.DropTable(
                name: "VehiculoCaracteristicas");

            migrationBuilder.DropTable(
                name: "VehiculoMatriculas");

            migrationBuilder.DropTable(
                name: "VehiculoPolizaRC");

            migrationBuilder.DropTable(
                name: "VehiculoPropietarios");

            migrationBuilder.DropTable(
                name: "VehiculoRegrabaciones");

            migrationBuilder.DropTable(
                name: "VehiculoRTM");

            migrationBuilder.DropTable(
                name: "VehiculoSOAT");

            migrationBuilder.DropTable(
                name: "VehiculoTarjetaOperacion");

            migrationBuilder.DropColumn(
                name: "CapacidadPasajerosSentados",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ClaseVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ClasicoAntiguo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Linea",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ModalidadServicio",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ModalidadTransporte",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "NumeroEjes",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PesoBrutoVehicular",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Puertas",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Repotenciado",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TipoServicio",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoEnsenanza",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "CategoriaLicenciaAnterior",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "EstadoConductor",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "EstadoLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "EstadoPersona",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "FechaExpedicionLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "NumeroInscripcion",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "OrganismoTransitoCancelaLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "OrganismoTransitoExpideLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "RestriccionesLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "RetencionLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "TieneRetencionLicencia",
                table: "Conductores");

            migrationBuilder.RenameColumn(
                name: "RazonSocialExterna",
                table: "Conductores",
                newName: "EmpresaExterna");

            migrationBuilder.RenameColumn(
                name: "NitExterno",
                table: "Conductores",
                newName: "NitEmpresa");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimientoSOAT",
                table: "Vehiculos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimientoSeguro",
                table: "Vehiculos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimientoTecnoMecanica",
                table: "Vehiculos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PropietarioCedula",
                table: "Vehiculos",
                type: "varchar(25)",
                maxLength: 25,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PropietarioNombre",
                table: "Vehiculos",
                type: "varchar(150)",
                maxLength: 150,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PropietarioTelefono",
                table: "Vehiculos",
                type: "varchar(25)",
                maxLength: 25,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Propietariocorreo",
                table: "Vehiculos",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RutaSOAT",
                table: "Vehiculos",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RutaSeguro",
                table: "Vehiculos",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RutaTecnoMecanica",
                table: "Vehiculos",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "TarifaExterna",
                table: "Vehiculos",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 5, 16, 32, 18, 514, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2056), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2061), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2063), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2064), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2066), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2068), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2069), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2071), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2073), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2075), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2076), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2078), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2079), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2081), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2082), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2084), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2088), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2089), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2091), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2092), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2094), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2095), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2097), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2099), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2100), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2101), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2103), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2104), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2106), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2108), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2109), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1902), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1909), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2352), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2352), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2353), new DateTime(2026, 6, 5, 21, 32, 18, 509, DateTimeKind.Utc).AddTicks(2332) });
        }
    }
}
