using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KonicaTracking.Migrations
{
    /// <inheritdoc />
    public partial class addseedsv11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationsHistory_Vehicle_VehicleId",
                table: "LocationsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Vehicle_AssignedVehicleId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_CurrentLocations_CurrentLocationId",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_CurrentLocationId",
                table: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicles",
                newName: "VehicleId");

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "Vehicles",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentLocationId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 20);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.InsertData(
                table: "CurrentLocations",
                columns: new[] { "CurrentLocationId", "Date", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5795), 40.4189m, -3.6919m },
                    { 2, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5861), 40.4193m, -3.6905m },
                    { 3, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5864), 40.4176m, -3.6890m },
                    { 4, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5866), 40.4172m, -3.6883m },
                    { 5, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5869), 40.4163m, -3.6871m },
                    { 6, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5871), 40.4158m, -3.6862m },
                    { 7, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5873), 40.4151m, -3.6854m },
                    { 8, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5876), 40.4146m, -3.6847m },
                    { 9, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5878), 40.4139m, -3.6838m },
                    { 10, new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5881), 40.4133m, -3.6827m }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "CurrentLocationId", "Plate" },
                values: new object[,]
                {
                    { 1, 1, "AB123CD" },
                    { 2, 2, "XY456ZW" },
                    { 3, 3, "FG789HI" },
                    { 4, 4, "JK012LM" },
                    { 5, 5, "NO345PQ" },
                    { 6, 6, "RS678TU" },
                    { 7, 7, "VW901YZ" },
                    { 8, 8, "BC234EF" },
                    { 9, 9, "GH567IJ" },
                    { 10, 10, "KL890MN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CurrentLocationId",
                table: "Vehicles",
                column: "CurrentLocationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationsHistory_Vehicles_VehicleId",
                table: "LocationsHistory",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Vehicles_AssignedVehicleId",
                table: "Orders",
                column: "AssignedVehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_CurrentLocations_CurrentLocationId",
                table: "Vehicles",
                column: "CurrentLocationId",
                principalTable: "CurrentLocations",
                principalColumn: "CurrentLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationsHistory_Vehicles_VehicleId",
                table: "LocationsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Vehicles_AssignedVehicleId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_CurrentLocations_CurrentLocationId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CurrentLocationId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Vehicle",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentLocationId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 20);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Vehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CurrentLocationId",
                table: "Vehicle",
                column: "CurrentLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationsHistory_Vehicle_VehicleId",
                table: "LocationsHistory",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Vehicle_AssignedVehicleId",
                table: "Orders",
                column: "AssignedVehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_CurrentLocations_CurrentLocationId",
                table: "Vehicle",
                column: "CurrentLocationId",
                principalTable: "CurrentLocations",
                principalColumn: "CurrentLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
