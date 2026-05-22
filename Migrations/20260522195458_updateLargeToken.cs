using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class updateLargeToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "token",
                table: "Usuarios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "refreshToken",
                table: "Usuarios",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 5, 22, 14, 54, 57, 145, DateTimeKind.Local).AddTicks(7925));

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
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 8, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1464), new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1463), new DateTime(2026, 5, 22, 19, 54, 57, 143, DateTimeKind.Utc).AddTicks(1465) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "token",
                table: "Usuarios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "refreshToken",
                table: "Usuarios",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 5, 22, 9, 24, 50, 180, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5244), new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5247), new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "RolesUsuarios",
                keyColumns: new[] { "idRol", "idUsuario" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 8, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5553), new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5552), new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5554) });
        }
    }
}
