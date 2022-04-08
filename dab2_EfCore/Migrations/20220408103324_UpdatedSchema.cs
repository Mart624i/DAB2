using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dab2_EfCore.Migrations
{
    public partial class UpdatedSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Keybool",
                table: "Members",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Keybool",
                table: "Chairmen",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2022, 4, 8, 12, 33, 23, 457, DateTimeKind.Local).AddTicks(597), new DateTime(2022, 4, 8, 12, 33, 23, 457, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2022, 4, 8, 12, 33, 23, 457, DateTimeKind.Local).AddTicks(616), new DateTime(2022, 4, 8, 12, 33, 23, 457, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Zipcode", "AccessKey", "Name" },
                values: new object[] { 9000, 3333, "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Zipcode",
                keyValue: 9000);

            migrationBuilder.DropColumn(
                name: "Keybool",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Keybool",
                table: "Chairmen");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "ClosingTime", "OpeningTime" },
                values: new object[] { new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1448), new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1444) });
        }
    }
}
