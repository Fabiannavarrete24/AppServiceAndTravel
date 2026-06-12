using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class modifyCotizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Cotizaciones_idCotizacion",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_idCotizacion",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "TipoServicio",
                table: "Servicios");

            migrationBuilder.RenameColumn(
                name: "idCotizacion",
                table: "Servicios",
                newName: "idDetalleCotizacion");

            migrationBuilder.RenameColumn(
                name: "FechaServicio",
                table: "Cotizaciones",
                newName: "FechaInicioServicio");

            migrationBuilder.RenameColumn(
                name: "DescripcionCarga",
                table: "Cotizaciones",
                newName: "Observaciones");

            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Clientes",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Clientes",
                newName: "RazonSocial");

            migrationBuilder.AddColumn<int>(
                name: "idTipoVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TiposServiciosidTipoServicio",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTipoVehiculo",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinalServicio",
                table: "Cotizaciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TiempoValidez",
                table: "Cotizaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoServicioidTipoServicio",
                table: "Cotizaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoVehiculoidTipoVehiculo",
                table: "Cotizaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "Cotizaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "diasServicio",
                table: "Cotizaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "disponibilidad",
                table: "Cotizaciones",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "idTipoServicio",
                table: "Cotizaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTipoVehiculo",
                table: "Cotizaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CargoContacto",
                table: "Clientes",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PersonaContacto",
                table: "Clientes",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposServicios",
                columns: table => new
                {
                    idTipoServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    idUsuarioModifica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposServicios", x => x.idTipoServicio);
                    table.ForeignKey(
                        name: "FK_TiposServicios_Usuarios_idUsuarioModifica",
                        column: x => x.idUsuarioModifica,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposVehiculos",
                columns: table => new
                {
                    idTipoVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    idUsuarioModifica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposVehiculos", x => x.idTipoVehiculo);
                    table.ForeignKey(
                        name: "FK_TiposVehiculos_Usuarios_idUsuarioModifica",
                        column: x => x.idUsuarioModifica,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleCotizacion",
                columns: table => new
                {
                    idDetalleCotizacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idCotizacion = table.Column<int>(type: "int", nullable: false),
                    idTipoServicio = table.Column<int>(type: "int", nullable: true),
                    idTipoVehiculo = table.Column<int>(type: "int", nullable: true),
                    Origen = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destino = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaServicioInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaServicioFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    NumPasajeros = table.Column<int>(type: "int", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Disponibilidad = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Observaciones = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCotizacion", x => x.idDetalleCotizacion);
                    table.ForeignKey(
                        name: "FK_DetalleCotizacion_Cotizaciones_idCotizacion",
                        column: x => x.idCotizacion,
                        principalTable: "Cotizaciones",
                        principalColumn: "idCotizacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCotizacion_TiposServicios_idTipoServicio",
                        column: x => x.idTipoServicio,
                        principalTable: "TiposServicios",
                        principalColumn: "idTipoServicio");
                    table.ForeignKey(
                        name: "FK_DetalleCotizacion_TiposVehiculos_idTipoVehiculo",
                        column: x => x.idTipoVehiculo,
                        principalTable: "TiposVehiculos",
                        principalColumn: "idTipoVehiculo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 4, 10, 16, 19, 245, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1266), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1269), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1270), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1271), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1273), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1274), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1275), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1276), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1277), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1278), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1279), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1280), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1281), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1282), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1283), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1284), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1285), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1286), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1287), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1288), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1289), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1290), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1291), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1292), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1293), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1294), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1295), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1296), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1297), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1298), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1299), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1066), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1070), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1415), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1414), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1417), new DateTime(2026, 6, 4, 15, 16, 19, 242, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_idTipoVehiculo",
                table: "Vehiculos",
                column: "idTipoVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idDetalleCotizacion",
                table: "Servicios",
                column: "idDetalleCotizacion");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idTipoVehiculo",
                table: "Servicios",
                column: "idTipoVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_TiposServiciosidTipoServicio",
                table: "Servicios",
                column: "TiposServiciosidTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_TipoServicioidTipoServicio",
                table: "Cotizaciones",
                column: "TipoServicioidTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_TipoVehiculoidTipoVehiculo",
                table: "Cotizaciones",
                column: "TipoVehiculoidTipoVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCotizacion_idCotizacion",
                table: "DetalleCotizacion",
                column: "idCotizacion");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCotizacion_idTipoServicio",
                table: "DetalleCotizacion",
                column: "idTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCotizacion_idTipoVehiculo",
                table: "DetalleCotizacion",
                column: "idTipoVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_TiposServicios_idUsuarioModifica",
                table: "TiposServicios",
                column: "idUsuarioModifica");

            migrationBuilder.CreateIndex(
                name: "IX_TiposVehiculos_idUsuarioModifica",
                table: "TiposVehiculos",
                column: "idUsuarioModifica");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_TiposServicios_TipoServicioidTipoServicio",
                table: "Cotizaciones",
                column: "TipoServicioidTipoServicio",
                principalTable: "TiposServicios",
                principalColumn: "idTipoServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_TiposVehiculos_TipoVehiculoidTipoVehiculo",
                table: "Cotizaciones",
                column: "TipoVehiculoidTipoVehiculo",
                principalTable: "TiposVehiculos",
                principalColumn: "idTipoVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_DetalleCotizacion_idDetalleCotizacion",
                table: "Servicios",
                column: "idDetalleCotizacion",
                principalTable: "DetalleCotizacion",
                principalColumn: "idDetalleCotizacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_TiposServicios_TiposServiciosidTipoServicio",
                table: "Servicios",
                column: "TiposServiciosidTipoServicio",
                principalTable: "TiposServicios",
                principalColumn: "idTipoServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_TiposVehiculos_idTipoVehiculo",
                table: "Servicios",
                column: "idTipoVehiculo",
                principalTable: "TiposVehiculos",
                principalColumn: "idTipoVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TiposVehiculos_idTipoVehiculo",
                table: "Vehiculos",
                column: "idTipoVehiculo",
                principalTable: "TiposVehiculos",
                principalColumn: "idTipoVehiculo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_TiposServicios_TipoServicioidTipoServicio",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_TiposVehiculos_TipoVehiculoidTipoVehiculo",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_DetalleCotizacion_idDetalleCotizacion",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_TiposServicios_TiposServiciosidTipoServicio",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_TiposVehiculos_idTipoVehiculo",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TiposVehiculos_idTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropTable(
                name: "DetalleCotizacion");

            migrationBuilder.DropTable(
                name: "TiposServicios");

            migrationBuilder.DropTable(
                name: "TiposVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_idTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_idDetalleCotizacion",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_idTipoVehiculo",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_TiposServiciosidTipoServicio",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Cotizaciones_TipoServicioidTipoServicio",
                table: "Cotizaciones");

            migrationBuilder.DropIndex(
                name: "IX_Cotizaciones_TipoVehiculoidTipoVehiculo",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "idTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TiposServiciosidTipoServicio",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "idTipoVehiculo",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "FechaFinalServicio",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "TiempoValidez",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "TipoServicioidTipoServicio",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "TipoVehiculoidTipoVehiculo",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "diasServicio",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "disponibilidad",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "idTipoServicio",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "idTipoVehiculo",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "CargoContacto",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PersonaContacto",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "idDetalleCotizacion",
                table: "Servicios",
                newName: "idCotizacion");

            migrationBuilder.RenameColumn(
                name: "Observaciones",
                table: "Cotizaciones",
                newName: "DescripcionCarga");

            migrationBuilder.RenameColumn(
                name: "FechaInicioServicio",
                table: "Cotizaciones",
                newName: "FechaServicio");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Clientes",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "RazonSocial",
                table: "Clientes",
                newName: "NombreCompleto");

            migrationBuilder.AddColumn<string>(
                name: "TipoServicio",
                table: "Servicios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 1, 16, 23, 36, 753, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4952), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4957), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4959), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4960), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4961), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4962), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4964), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4965), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4966), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4967), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4969), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4970), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4971), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4972), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4973), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4974), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4976), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4977), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4978), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4979), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4980), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5000), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5001), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5002), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5003), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5004), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5006), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5007), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5008), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5009), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5010), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4841), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4845), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5129), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5128), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5130), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_idCotizacion",
                table: "Servicios",
                column: "idCotizacion",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Cotizaciones_idCotizacion",
                table: "Servicios",
                column: "idCotizacion",
                principalTable: "Cotizaciones",
                principalColumn: "idCotizacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
