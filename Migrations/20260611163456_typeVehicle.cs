using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class typeVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "TiposVehiculos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "idCategoriaVehiculo",
                table: "TiposVehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriasVehiculos",
                columns: table => new
                {
                    idCategoriaVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasVehiculos", x => x.idCategoriaVehiculo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CategoriasVehiculos",
                columns: new[] { "idCategoriaVehiculo", "descripcion" },
                values: new object[,]
                {
                    { 1, "Transporte Particular" },
                    { 2, "Transporte Público Pasajeros" },
                    { 3, "Transporte de Carga" },
                    { 4, "Motocicletas" },
                    { 5, "Remolques y Semirremolques" },
                    { 6, "Vehículos Especiales" }
                });

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 11, 11, 34, 55, 989, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1543), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1547), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1548), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1549), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1550), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1552), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1553), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1554), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1555), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1556), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1558), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1559), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1560), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1561), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1562), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1563), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1564), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1566), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1567), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1568), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1569), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1570), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1571), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1572), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1573), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1574), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1575), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1576), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1578), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1579), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1580), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1325), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1337), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.InsertData(
                table: "TiposServicios",
                columns: new[] { "idTipoServicio", "descripcion", "fechaCreacion", "idUsuarioModifica" },
                values: new object[,]
                {
                    { 1, "Particular", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1927), 1 },
                    { 2, "Público", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1928), 1 },
                    { 3, "Oficial", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1986), 1 },
                    { 4, "Diplomático", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1987), 1 },
                    { 5, "Especial", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1989), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1721), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1720), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1722), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.InsertData(
                table: "TiposVehiculos",
                columns: new[] { "idTipoVehiculo", "descripcion", "fechaCreacion", "idCategoriaVehiculo", "idUsuarioModifica" },
                values: new object[,]
                {
                    { 1, "Automóvil", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2070), 1, 1 },
                    { 2, "Campero", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2072), 1, 1 },
                    { 3, "Camioneta", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2072), 1, 1 },
                    { 4, "Motocicleta", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2073), 4, 1 },
                    { 5, "Motocarro", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2074), 4, 1 },
                    { 6, "Cuatrimoto", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2075), 4, 1 },
                    { 7, "Microbús", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2076), 2, 1 },
                    { 8, "Buseta", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2077), 2, 1 },
                    { 9, "Bus", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2078), 2, 1 },
                    { 10, "Furgón", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2079), 3, 1 },
                    { 11, "Volqueta", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2080), 3, 1 },
                    { 12, "Tractocamión", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2081), 3, 1 },
                    { 13, "Vehículo Rígido", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2082), 3, 1 },
                    { 14, "Vehículo Articulado", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2083), 3, 1 },
                    { 15, "Remolque", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2084), 5, 1 },
                    { 16, "Semirremolque", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2085), 5, 1 },
                    { 17, "Ambulancia", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2086), 6, 1 },
                    { 18, "Vehículo de Bomberos", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2087), 6, 1 },
                    { 19, "Vehículo Blindado", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2087), 6, 1 },
                    { 20, "Grúa", new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2088), 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TiposVehiculos_idCategoriaVehiculo",
                table: "TiposVehiculos",
                column: "idCategoriaVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposVehiculos_CategoriasVehiculos_idCategoriaVehiculo",
                table: "TiposVehiculos",
                column: "idCategoriaVehiculo",
                principalTable: "CategoriasVehiculos",
                principalColumn: "idCategoriaVehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TiposVehiculos_CategoriasVehiculos_idCategoriaVehiculo",
                table: "TiposVehiculos");

            migrationBuilder.DropTable(
                name: "CategoriasVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_TiposVehiculos_idCategoriaVehiculo",
                table: "TiposVehiculos");

            migrationBuilder.DeleteData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "idCategoriaVehiculo",
                table: "TiposVehiculos");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "TiposVehiculos",
                type: "longtext",
                nullable: false,
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
        }
    }
}
