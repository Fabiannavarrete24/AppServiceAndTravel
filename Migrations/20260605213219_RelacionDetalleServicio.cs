using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class RelacionDetalleServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Realizado",
                table: "DetalleCotizacion",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "DetalleCotizacion",
                type: "int",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Realizado",
                table: "DetalleCotizacion");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "DetalleCotizacion");

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
    }
}
