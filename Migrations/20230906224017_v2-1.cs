using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonicaTracking.Migrations
{
    /// <inheritdoc />
    public partial class v21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User);
                });

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "CurrentLocations",
                keyColumn: "CurrentLocationId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 9, 7, 0, 40, 17, 259, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User", "Name", "Password", "Token" },
                values: new object[] { 1, "Administrator", "AdministratorPass", null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Name",
                table: "Users",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
