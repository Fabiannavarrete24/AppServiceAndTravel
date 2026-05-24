using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class addDashobardService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Clientes_ClienteId",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Usuarios_UsuarioAprobadorId",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Usuarios_UsuarioCreadorId",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Conductores_ConductorId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Cotizaciones_CotizacionId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_ProveedoresExternos_ProveedorExternoId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Usuarios_UsuarioCreadorId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Vehiculos_VehiculoId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "NombreRemitente",
                table: "ConfiguracionGeneral");

            migrationBuilder.DropColumn(
                name: "correoRemitente",
                table: "ConfiguracionGeneral");

            migrationBuilder.RenameColumn(
                name: "VehiculoId",
                table: "Servicios",
                newName: "idVehiculo");

            migrationBuilder.RenameColumn(
                name: "UsuarioCreadorId",
                table: "Servicios",
                newName: "idUsuarioCreador");

            migrationBuilder.RenameColumn(
                name: "ProveedorExternoId",
                table: "Servicios",
                newName: "idProveedorExterno");

            migrationBuilder.RenameColumn(
                name: "CotizacionId",
                table: "Servicios",
                newName: "idCotizacion");

            migrationBuilder.RenameColumn(
                name: "ConductorId",
                table: "Servicios",
                newName: "idConductor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Servicios",
                newName: "idServicio");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_VehiculoId",
                table: "Servicios",
                newName: "IX_Servicios_idVehiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_UsuarioCreadorId",
                table: "Servicios",
                newName: "IX_Servicios_idUsuarioCreador");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_ProveedorExternoId",
                table: "Servicios",
                newName: "IX_Servicios_idProveedorExterno");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_CotizacionId",
                table: "Servicios",
                newName: "IX_Servicios_idCotizacion");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_ConductorId",
                table: "Servicios",
                newName: "IX_Servicios_idConductor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProveedoresExternos",
                newName: "IdProveedorExterno");

            migrationBuilder.RenameColumn(
                name: "UsuarioCreadorId",
                table: "Cotizaciones",
                newName: "idUsuarioCreador");

            migrationBuilder.RenameColumn(
                name: "UsuarioAprobadorId",
                table: "Cotizaciones",
                newName: "idUsuarioAprobador");

            migrationBuilder.RenameColumn(
                name: "FechaServicioRequerido",
                table: "Cotizaciones",
                newName: "FechaServicio");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Cotizaciones",
                newName: "idCliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cotizaciones",
                newName: "idCotizacion");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizaciones_UsuarioCreadorId",
                table: "Cotizaciones",
                newName: "IX_Cotizaciones_idUsuarioCreador");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizaciones_UsuarioAprobadorId",
                table: "Cotizaciones",
                newName: "IX_Cotizaciones_idUsuarioAprobador");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizaciones_ClienteId",
                table: "Cotizaciones",
                newName: "IX_Cotizaciones_idCliente");

            migrationBuilder.RenameColumn(
                name: "JwtSecret",
                table: "ConfiguracionGeneral",
                newName: "JwtSecretKey");

            migrationBuilder.RenameColumn(
                name: "JwtExpiracionMinutos",
                table: "ConfiguracionGeneral",
                newName: "JwtExpirationMinutes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "idCliente");

            migrationBuilder.AlterColumn<int>(
                name: "ModificadoPorId",
                table: "ConfiguracionGeneral",
                type: "int",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "JwtAudience",
                table: "ConfiguracionGeneral",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "JwtIssuer",
                table: "ConfiguracionGeneral",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true)
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

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                columns: new[] { "JwtAudience", "JwtIssuer", "JwtSecretKey", "ModificadoPorId", "UltimaModificacion" },
                values: new object[] { "AppServiceAndTravelApp", "AppServiceAndTravelAPI", "EstaEsUnaLlaveSecretaSeguraYBienLarga", null, new DateTime(2026, 5, 23, 23, 2, 44, 458, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4783), new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4787), new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "RolesUsuarios",
                keyColumns: new[] { "idRol", "idUsuario" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(4908));

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

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 8, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5216), new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5216), new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5217), new DateTime(2026, 5, 24, 4, 2, 44, 455, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesSistema_idTipoActividadSistema",
                table: "ActividadesSistema",
                column: "idTipoActividadSistema");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesSistema_idUsuario",
                table: "ActividadesSistema",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_LogsSistema_idUsuario",
                table: "LogsSistema",
                column: "idUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Clientes_idCliente",
                table: "Cotizaciones",
                column: "idCliente",
                principalTable: "Clientes",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Usuarios_idUsuarioAprobador",
                table: "Cotizaciones",
                column: "idUsuarioAprobador",
                principalTable: "Usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Usuarios_idUsuarioCreador",
                table: "Cotizaciones",
                column: "idUsuarioCreador",
                principalTable: "Usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Conductores_idConductor",
                table: "Servicios",
                column: "idConductor",
                principalTable: "Conductores",
                principalColumn: "idConductor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Cotizaciones_idCotizacion",
                table: "Servicios",
                column: "idCotizacion",
                principalTable: "Cotizaciones",
                principalColumn: "idCotizacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_ProveedoresExternos_idProveedorExterno",
                table: "Servicios",
                column: "idProveedorExterno",
                principalTable: "ProveedoresExternos",
                principalColumn: "IdProveedorExterno",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Usuarios_idUsuarioCreador",
                table: "Servicios",
                column: "idUsuarioCreador",
                principalTable: "Usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Vehiculos_idVehiculo",
                table: "Servicios",
                column: "idVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "idVehiculo",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Clientes_idCliente",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Usuarios_idUsuarioAprobador",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Usuarios_idUsuarioCreador",
                table: "Cotizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Conductores_idConductor",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Cotizaciones_idCotizacion",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_ProveedoresExternos_idProveedorExterno",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Usuarios_idUsuarioCreador",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Vehiculos_idVehiculo",
                table: "Servicios");

            migrationBuilder.DropTable(
                name: "ActividadesSistema");

            migrationBuilder.DropTable(
                name: "LogsSistema");

            migrationBuilder.DropTable(
                name: "TiposActividadSistema");

            migrationBuilder.DropColumn(
                name: "JwtAudience",
                table: "ConfiguracionGeneral");

            migrationBuilder.DropColumn(
                name: "JwtIssuer",
                table: "ConfiguracionGeneral");

            migrationBuilder.RenameColumn(
                name: "idVehiculo",
                table: "Servicios",
                newName: "VehiculoId");

            migrationBuilder.RenameColumn(
                name: "idUsuarioCreador",
                table: "Servicios",
                newName: "UsuarioCreadorId");

            migrationBuilder.RenameColumn(
                name: "idProveedorExterno",
                table: "Servicios",
                newName: "ProveedorExternoId");

            migrationBuilder.RenameColumn(
                name: "idCotizacion",
                table: "Servicios",
                newName: "CotizacionId");

            migrationBuilder.RenameColumn(
                name: "idConductor",
                table: "Servicios",
                newName: "ConductorId");

            migrationBuilder.RenameColumn(
                name: "idServicio",
                table: "Servicios",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_idVehiculo",
                table: "Servicios",
                newName: "IX_Servicios_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_idUsuarioCreador",
                table: "Servicios",
                newName: "IX_Servicios_UsuarioCreadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_idProveedorExterno",
                table: "Servicios",
                newName: "IX_Servicios_ProveedorExternoId");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_idCotizacion",
                table: "Servicios",
                newName: "IX_Servicios_CotizacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_idConductor",
                table: "Servicios",
                newName: "IX_Servicios_ConductorId");

            migrationBuilder.RenameColumn(
                name: "IdProveedorExterno",
                table: "ProveedoresExternos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "idUsuarioCreador",
                table: "Cotizaciones",
                newName: "UsuarioCreadorId");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAprobador",
                table: "Cotizaciones",
                newName: "UsuarioAprobadorId");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Cotizaciones",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "FechaServicio",
                table: "Cotizaciones",
                newName: "FechaServicioRequerido");

            migrationBuilder.RenameColumn(
                name: "idCotizacion",
                table: "Cotizaciones",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizaciones_idUsuarioCreador",
                table: "Cotizaciones",
                newName: "IX_Cotizaciones_UsuarioCreadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizaciones_idUsuarioAprobador",
                table: "Cotizaciones",
                newName: "IX_Cotizaciones_UsuarioAprobadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizaciones_idCliente",
                table: "Cotizaciones",
                newName: "IX_Cotizaciones_ClienteId");

            migrationBuilder.RenameColumn(
                name: "JwtSecretKey",
                table: "ConfiguracionGeneral",
                newName: "JwtSecret");

            migrationBuilder.RenameColumn(
                name: "JwtExpirationMinutes",
                table: "ConfiguracionGeneral",
                newName: "JwtExpiracionMinutos");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "ModificadoPorId",
                table: "ConfiguracionGeneral",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NombreRemitente",
                table: "ConfiguracionGeneral",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "correoRemitente",
                table: "ConfiguracionGeneral",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                columns: new[] { "JwtSecret", "ModificadoPorId", "NombreRemitente", "UltimaModificacion", "correoRemitente" },
                values: new object[] { null, null, null, new DateTime(2026, 5, 22, 14, 54, 57, 145, DateTimeKind.Local).AddTicks(7925), null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1165), new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1170), new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "RolesUsuarios",
                keyColumns: new[] { "idRol", "idUsuario" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 8, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1464), new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1463), new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1465), null });

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Clientes_ClienteId",
                table: "Cotizaciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Usuarios_UsuarioAprobadorId",
                table: "Cotizaciones",
                column: "UsuarioAprobadorId",
                principalTable: "Usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Usuarios_UsuarioCreadorId",
                table: "Cotizaciones",
                column: "UsuarioCreadorId",
                principalTable: "Usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Conductores_ConductorId",
                table: "Servicios",
                column: "ConductorId",
                principalTable: "Conductores",
                principalColumn: "idConductor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Cotizaciones_CotizacionId",
                table: "Servicios",
                column: "CotizacionId",
                principalTable: "Cotizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_ProveedoresExternos_ProveedorExternoId",
                table: "Servicios",
                column: "ProveedorExternoId",
                principalTable: "ProveedoresExternos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Usuarios_UsuarioCreadorId",
                table: "Servicios",
                column: "UsuarioCreadorId",
                principalTable: "Usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Vehiculos_VehiculoId",
                table: "Servicios",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "idVehiculo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
