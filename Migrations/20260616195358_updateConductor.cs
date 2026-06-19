using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServiceAndTravel.Migrations
{
    /// <inheritdoc />
    public partial class updateConductor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaLicenciaAnterior",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "NitExterno",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "NumeroInscripcion",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "ObservacionesExterno",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "OrganismoTransitoCancelaLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "RazonSocialExterna",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "RetencionLicencia",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "TarifaExterna",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "TieneRetencionLicencia",
                table: "Conductores");

            migrationBuilder.RenameColumn(
                name: "OrganismoTransitoExpideLicencia",
                table: "Conductores",
                newName: "OrganismoExpide");

            migrationBuilder.RenameColumn(
                name: "EstadoPersona",
                table: "Conductores",
                newName: "Vigencia");

            migrationBuilder.AlterColumn<int>(
                name: "CapacidadPasajeros",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "CapacidadCarga",
                table: "Vehiculos",
                type: "decimal(10,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "TipoProveedor",
                table: "Conductores",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaLicencia",
                table: "Conductores",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TipoDocumento",
                table: "Conductores",
                type: "int",
                maxLength: 25,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ConfiguracionGeneral",
                keyColumn: "idConfiguracionGeneral",
                keyValue: 1,
                column: "UltimaModificacion",
                value: new DateTime(2026, 6, 16, 14, 53, 57, 160, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9848), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9850), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9851), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9852), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9853), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9854), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9855), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9856), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9857), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9858), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9859), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 12, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9860), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 13, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9861), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 14, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9862), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 15, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9863), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 16, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9865), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 17, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9866), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 18, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9867), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9868), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9868), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9869), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9870), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 23, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9871), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 24, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9872), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 25, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9873), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9874), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 27, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9875), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 28, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9876), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 29, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9877), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 30, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9878), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumns: new[] { "idProceso", "idRol" },
                keyValues: new object[] { 31, 1 },
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9878), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 21,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 22,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 23,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 24,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 25,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 26,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 27,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 28,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 29,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 30,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Procesos",
                keyColumn: "idProceso",
                keyValue: 31,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 1,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9775), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "idRol",
                keyValue: 2,
                columns: new[] { "fechaCreacion", "fechaModificacion" },
                values: new object[] { new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9777), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(5), new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(5), new DateTime(2026, 6, 16, 19, 53, 57, 158, DateTimeKind.Utc).AddTicks(6), new DateTime(2026, 6, 16, 19, 53, 57, 157, DateTimeKind.Utc).AddTicks(9988) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "Conductores");

            migrationBuilder.RenameColumn(
                name: "Vigencia",
                table: "Conductores",
                newName: "EstadoPersona");

            migrationBuilder.RenameColumn(
                name: "OrganismoExpide",
                table: "Conductores",
                newName: "OrganismoTransitoExpideLicencia");

            migrationBuilder.AlterColumn<int>(
                name: "CapacidadPasajeros",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CapacidadCarga",
                table: "Vehiculos",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoProveedor",
                table: "Conductores",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaLicencia",
                table: "Conductores",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CategoriaLicenciaAnterior",
                table: "Conductores",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Conductores",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NitExterno",
                table: "Conductores",
                type: "varchar(25)",
                maxLength: 25,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NumeroInscripcion",
                table: "Conductores",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ObservacionesExterno",
                table: "Conductores",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "OrganismoTransitoCancelaLicencia",
                table: "Conductores",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RazonSocialExterna",
                table: "Conductores",
                type: "varchar(150)",
                maxLength: 150,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RetencionLicencia",
                table: "Conductores",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "TarifaExterna",
                table: "Conductores",
                type: "decimal(12,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TieneRetencionLicencia",
                table: "Conductores",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "TiposServicios",
                keyColumn: "idTipoServicio",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 1,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 2,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 3,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 4,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 5,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 6,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 7,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 8,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 9,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 10,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 11,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 12,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 13,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 14,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 15,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 16,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 17,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 18,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 19,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "TiposVehiculos",
                keyColumn: "idTipoVehiculo",
                keyValue: 20,
                column: "fechaCreacion",
                value: new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "idUsuario",
                keyValue: 1,
                columns: new[] { "fechaCambioClave", "fechaCreacion", "fechaModificacion", "ultimoAcceso" },
                values: new object[] { new DateTime(2026, 9, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1721), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1720), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1722), new DateTime(2026, 6, 11, 16, 34, 55, 986, DateTimeKind.Utc).AddTicks(1699) });
        }
    }
}
