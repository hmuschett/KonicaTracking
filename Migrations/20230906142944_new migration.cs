using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonicaTracking.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 9, 6, 16, 29, 44, 615, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Plate",
                table: "Vehicles",
                column: "Plate",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicles_Plate",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5881));
        }
    }
}
