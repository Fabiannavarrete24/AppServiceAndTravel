using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class updateusersRols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolesUsuarios");

            migrationBuilder.DropColumn(
                name: "idPermiso",
                table: "Permisos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "token",
                keyValue: null,
                column: "token",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "token",
                table: "Usuarios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "telefono",
                keyValue: null,
                column: "telefono",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Usuarios",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "refreshToken",
                keyValue: null,
                column: "refreshToken",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "refreshToken",
                table: "Usuarios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "correo",
                keyValue: null,
                column: "correo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Usuarios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "cargo",
                keyValue: null,
                column: "cargo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "cargo",
                table: "Usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "RolesidRol",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idRol",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "orden",
                table: "Procesos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Evento",
                table: "LogsSistema",
                type: "int",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Tabla",
                table: "LogsSistema",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "valorAnterior",
                table: "LogsSistema",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "valorNuevo",
                table: "LogsSistema",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 1, 12, 42, 37, 507, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7672), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7676), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7677), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7678), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7680), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7681), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7682), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7683), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7685), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7686), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7687), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7688), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7689), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7691), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7692), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7693), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7694), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7695), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7696), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7699), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7700), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7701), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7702), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "orden" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7247), 7 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Admin", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7255), null, 2, 7, "Configuracion General", "ConfiguracionGeneral" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7257), 7, "Usuarios", "Usuarios" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7259), 7, "Roles", "Roles" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7260), 7, "Permisos", "Permisos" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7262), "fa-users-rectangle", null, 6, "Proveedores", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Admin", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7263), null, 7, 6, "Listado de Proveedores", "Proveedores" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7265), 6, "Nuevo Proveedor", "CrearProveedor" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7267), "fa-address-card", null, 4, "Conductores", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Operaciones", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7268), null, 10, 4, "Listado de Conductores", "Conductores" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7270), 4, "Nuevo Conductor", "CrearConductor" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7271), 4, "Listado de Conductores Aliados", "ConductoresAliados" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Operaciones", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7273), null, 10, 4, "Nuevo Conductor Aliado", "CrearConductorAliado" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7275), "fa-car", null, 5, "Vehiculos", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                columns: new[] { "fechaCreacion", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7277), 5, "Listado de Vehiculos", "Vehiculos" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Operaciones", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7278), null, 13, 5, "Nuevo Vehiculo", "CrearVehiculo" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Operaciones", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7280), 13, 5, "Listado de Vehiculos Aliados", "VehiculosAliados" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Operaciones", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7281), 13, 5, "Nuevo Vehiculo Aliado", "CrearVehiculoAliado" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                columns: new[] { "fechaCreacion", "orden", "proceso" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7283), 1, "Cotizaciones" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                columns: new[] { "fechaCreacion", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7284), 16, 1, "Historial", "Cotizaciones" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                columns: new[] { "fechaCreacion", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7286), 16, 1, "Nueva Cotización", "CrearCotizacion" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                columns: new[] { "fechaCreacion", "icono", "orden", "proceso" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7327), "fa-handshake", 2, "Clientes" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Comercial", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7328), 19, 2, "Listado de Clientes", "Clientes" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[] { "Comercial", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7330), 19, 2, "Nuevo Cliente", "CrearCliente" });

            migrationBuilder.InsertData(
                table: "Procesos",
                columns: new[] { "idProceso", "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "orden", "proceso", "url" },
                values: new object[,]
                {
                    { 25, null, null, new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7331), "fa-car-side", null, 3, "Servicios", null },
                    { 26, "Operaciones", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7333), null, 22, 3, "Historial", "Servicios" },
                    { 27, "Operaciones", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7334), null, 22, 3, "Nuevo Servicio", "CrearServicio" },
                    { 28, "Operaciones", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7336), null, null, 3, "Tipo Servicios", "TipoServicios" },
                    { 29, null, null, new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7337), "fa-gear", null, 8, "Configuracion", null },
                    { 30, "Admin", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7339), null, null, 8, "Formatos Correos", "FormatosCorreos" },
                    { 31, "Admin", "App", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7340), null, null, 8, "Tipo Cotizaciónes", "TipoCotizaciones" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7505), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7508), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "RolesidRol", "fechaCambioClave", "fechaCreacion", "fechaModificacion", "idRol", "refreshToken", "telefono", "token", "ultimoAcceso" },
                values: new object[] { null, new DateTime(2026, 9, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7803), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7803), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7804), 2, "", "", "", new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_idRol",
                table: "Usuarios",
                column: "idRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolesidRol",
                table: "Usuarios",
                column: "RolesidRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolesidRol",
                table: "Usuarios",
                column: "RolesidRol",
                principalTable: "Roles",
                principalColumn: "idRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_idRol",
                table: "Usuarios",
                column: "idRol",
                principalTable: "Roles",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolesidRol",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_idRol",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_idRol",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolesidRol",
                table: "Usuarios");

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31);

            migrationBuilder.DropColumn(
                name: "RolesidRol",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "idRol",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "orden",
                table: "Procesos");

            migrationBuilder.DropColumn(
                name: "Tabla",
                table: "LogsSistema");

            migrationBuilder.DropColumn(
                name: "valorAnterior",
                table: "LogsSistema");

            migrationBuilder.DropColumn(
                name: "valorNuevo",
                table: "LogsSistema");

            migrationBuilder.AlterColumn<string>(
                name: "token",
                table: "Usuarios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Usuarios",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "refreshToken",
                table: "Usuarios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Usuarios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cargo",
                table: "Usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "idPermiso",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Evento",
                table: "LogsSistema",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200)
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
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9440), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9440), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9444), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9444), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9445), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9445), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9446), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9446), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9447), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9448), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9448), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9449), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9450), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9450), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9451), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9451), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9451), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9452), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9452), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9453), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9453), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9454), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9454), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9455), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9455), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9457), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9457), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9458), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9458), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9459), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9459), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9460), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9460), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9461), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9461), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9462), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9462), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9463), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9463), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9464), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9464), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9465), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9465), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9466), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9466), 0 });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion", "idPermiso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9467), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9467), 0 });

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
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8692), "fa-gear", 1, "Configuracion", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8694), "Configuracion General", "ConfiguracionGeneral" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8695), "Usuarios", "Usuarios" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8697), "Roles", "Roles" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Admin", "App", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8698), null, 2, "Permisos", "Permisos" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8699), "fa-users-rectangle", null, "Proveedores", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8755), "Listado de Proveedores", "Proveedores" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Admin", "App", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8757), null, 7, "Nuevo Proveedor", "CrearProveedor" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8759), "fa-address-card", null, "Conductores", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8760), "Listado de Conductores", "Conductores" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8761), "Nuevo Conductor", "CrearConductor" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8762), "fa-car", null, "Vehiculos", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Operaciones", "App", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8764), null, 13, "Listado de Vehiculos", "Vehiculos" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                columns: new[] { "fechaCreacion", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8765), "Nuevo Vehiculo", "CrearVehiculo" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                columns: new[] { "area", "controlador", "fechaCreacion", "icono", "idProcesoPadre", "proceso", "url" },
                values: new object[] { null, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8766), "fa-handshake", null, "Cotizaciones", null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Comercial", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8767), 16, "Historial", "Cotizaciones" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Comercial", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8769), 16, "Nueva Cotización", "CrearCotizacion" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                columns: new[] { "fechaCreacion", "proceso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8770), "Clientes" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                columns: new[] { "fechaCreacion", "idProcesoPadre", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8771), 19, "Listado de Clientes", "Clientes" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                columns: new[] { "fechaCreacion", "idProcesoPadre", "proceso", "url" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8772), 19, "Nuevo Cliente", "CrearCliente" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                columns: new[] { "fechaCreacion", "icono", "proceso" },
                values: new object[] { new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8774), "fa-car-side", "Servicios" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Operaciones", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8775), 22, "Historial", "Servicios" });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                columns: new[] { "area", "fechaCreacion", "idProcesoPadre", "proceso", "url" },
                values: new object[] { "Operaciones", new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(8776), 22, "Nuevo Servicio", "CrearServicio" });

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

            migrationBuilder.InsertData(
                table: "RolesUsuarios",
                columns: new[] { "idRol", "idUsuario", "fechaCreacion", "idUser" },
                values: new object[] { 1, 1, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9360), null });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "refreshToken", "telefono", "token", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 8, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9613), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9613), new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9614), null, null, null, new DateTime(2026, 5, 27, 20, 40, 38, 975, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsuarios_idRol",
                table: "RolesUsuarios",
                column: "idRol");
        }
    }
}
