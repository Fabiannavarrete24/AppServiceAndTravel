using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class addOrdenPermmisions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "userName",
                keyValue: null,
                column: "userName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "userName",
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

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "password",
                keyValue: null,
                column: "password",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "password",
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

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "idProceso", "idRol", "apiAccess", "claims", "controllerAction", "crea", "deny", "edita", "elimina", "endpoint", "fechaCreacion", "fechaModificacion", "hereda", "lectura", "modificadoPorId" },
                values: new object[,]
                {
                    { 25, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5003), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5004), true, true, null },
                    { 26, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5004), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5005), true, true, null },
                    { 27, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5006), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5006), true, true, null },
                    { 28, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5007), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5007), true, true, null },
                    { 29, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5008), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5008), true, true, null },
                    { 30, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5009), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5009), true, true, null },
                    { 31, 1, false, null, null, false, false, true, true, null, new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5010), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5011), true, true, null }
                });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4522), 1 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4524), 1 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4526), 1 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4527), 1 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4585), 6 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4587), 6 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4590), 9 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4592), 9 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4594), 9 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4595), 9 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4599), 14 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4601), 14 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4602), 14 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4604), 14 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4607), 19 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4609), 19 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4612), 22 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4614), 22 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4617), 25 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4618), 25 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4620), 25 });

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
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4623), 29 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(4624), 29 });

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
                columns: new[] { "avatar", "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { "", new DateTime(2026, 9, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5129), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5128), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5130), new DateTime(2026, 6, 1, 21, 23, 36, 750, DateTimeKind.Utc).AddTicks(5109) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.AlterColumn<string>(
                name: "userName",
                table: "Usuarios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Usuarios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
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
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7255), 2 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7257), 2 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7259), 2 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7260), 2 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7263), 7 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7265), 7 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7268), 10 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7270), 10 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7271), 10 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7273), 10 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7277), 13 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7278), 13 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7280), 13 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7281), 13 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7284), 16 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7286), 16 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7328), 19 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7330), 19 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7333), 22 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7334), 22 });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7336), null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7339), null });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                columns: new[] { "fechaCreacion", "idProcesoPadre" },
                values: new object[] { new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7340), null });

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
                columns: new[] { "avatar", "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { null, new DateTime(2026, 9, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7803), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7803), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7804), new DateTime(2026, 6, 1, 17, 42, 37, 504, DateTimeKind.Utc).AddTicks(7785) });
        }
    }
}
