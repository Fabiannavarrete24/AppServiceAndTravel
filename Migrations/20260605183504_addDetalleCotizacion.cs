using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class addDetalleCotizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 5, 13, 35, 3, 488, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7842), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7846), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7847), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7848), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7850), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7851), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7853), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7854), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7855), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7856), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7859), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7860), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7861), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7862), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7864), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7865), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7867), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7868), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7869), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7870), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7871), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7873), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7874), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7876), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7877), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7878), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7879), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7880), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7882), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7883), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7330), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7336), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(8009), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(8008), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(8010), new DateTime(2026, 6, 5, 18, 35, 3, 484, DateTimeKind.Utc).AddTicks(7989) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
