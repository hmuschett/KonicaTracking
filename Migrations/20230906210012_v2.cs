using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonicaTracking.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 9, 6, 23, 0, 12, 703, DateTimeKind.Local).AddTicks(5812));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
