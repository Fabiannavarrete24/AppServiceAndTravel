using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class seedpermisos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 5, 22, 9, 24, 50, 180, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "idProceso", "idRol", "crea", "edita", "elimina", "fechaCreacion", "lectura" },
                values: new object[,]
                {
                    { 1, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5399), true },
                    { 2, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5404), true },
                    { 3, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5405), true },
                    { 4, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5406), true },
                    { 5, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5408), true },
                    { 6, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5409), true },
                    { 7, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5410), true },
                    { 8, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5411), true },
                    { 9, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5412), true },
                    { 10, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5413), true },
                    { 11, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5414), true },
                    { 12, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5415), true },
                    { 13, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5416), true },
                    { 14, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5417), true },
                    { 15, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5418), true },
                    { 16, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5419), true },
                    { 17, 1, false, true, true, new DateTime(2026, 5, 22, 14, 24, 50, 178, DateTimeKind.Utc).AddTicks(5420), true }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 5, 22, 9, 22, 58, 330, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4968), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4973), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "RolesUsuarios",
                keyColumns: new[] { "idRol", "idUsuario" },
                keyValues: new object[] { 1, 1 },
                column: "fechaCreacion",
                value: new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 8, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5151), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5150), new DateTime(2026, 5, 22, 14, 22, 58, 328, DateTimeKind.Utc).AddTicks(5152) });
        }
    }
}
