using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class updatePermisos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "apiAccess",
                table: "Permisos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "claims",
                table: "Permisos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "controllerAction",
                table: "Permisos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "deny",
                table: "Permisos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "endpoint",
                table: "Permisos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaModificacion",
                table: "Permisos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "hereda",
                table: "Permisos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "idPermiso",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "modificadoPorId",
                table: "Permisos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 5, 27, 15, 40, 38, 978, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9440), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9440), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9444), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9444), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9445), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9445), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9446), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9446), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9447), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9448), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9448), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9449), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9450), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9450), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9451), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9451), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9451), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9452), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9452), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9453), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9453), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9454), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9454), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9455), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9455), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9457), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9457), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9458), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9458), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9459), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9459), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9460), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9460), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9461), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9461), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9462), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9462), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9463), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9463), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9464), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9464), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9465), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9465), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9466), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9466), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "apiAccess", "claims", "controllerAction", "deny", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "idPermiso", "modificadoPorId" },
                values: new object[] { false, null, null, false, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9467), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9467), true, 0, null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9268), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9273), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "RolesUsuarios",
                keyColumns: new[] { "idRol", "idUsuario" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 8, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9613), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9613), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9614), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9590) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apiAccess",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "claims",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "controllerAction",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "deny",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "endpoint",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "fechaModificacion",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "hereda",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "idPermiso",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "modificadoPorId",
                table: "Permisos");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 5, 26, 13, 13, 53, 752, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4431), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4436), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "RolesUsuarios",
                keyColumns: new[] { "idRol", "idUsuario" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 8, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4952), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4951), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4953), new DateTime(2026, 5, 26, 18, 13, 53, 749, DateTimeKind.Utc).AddTicks(4932) });
        }
    }
}
