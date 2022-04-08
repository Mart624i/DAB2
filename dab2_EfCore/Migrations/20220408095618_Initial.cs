using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dab2_EfCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {/*
            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Zipcode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Zipcode);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Address = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Bathroom = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsBooked = table.Column<bool>(type: "bit", nullable: false),
                    AccessKey = table.Column<int>(type: "int", nullable: false),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    MunicipalityZipcode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Address);
                    table.ForeignKey(
                        name: "FK_Locations_Municipalities_MunicipalityZipcode",
                        column: x => x.MunicipalityZipcode,
                        principalTable: "Municipalities",
                        principalColumn: "Zipcode");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpeningTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddress = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Locations_LocationAddress",
                        column: x => x.LocationAddress,
                        principalTable: "Locations",
                        principalColumn: "Address");
                });

            migrationBuilder.CreateTable(
                name: "Societies",
                columns: table => new
                {
                    Cvr_number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    MunicipalityZipcode = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societies", x => x.Cvr_number);
                    table.ForeignKey(
                        name: "FK_Societies_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Societies_Municipalities_MunicipalityZipcode",
                        column: x => x.MunicipalityZipcode,
                        principalTable: "Municipalities",
                        principalColumn: "Zipcode");
                });

            migrationBuilder.CreateTable(
                name: "Chairmen",
                columns: table => new
                {
                    Member_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpr_number = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cvr_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chairmen", x => x.Member_id);
                    table.ForeignKey(
                        name: "FK_Chairmen_Societies_Cvr_number",
                        column: x => x.Cvr_number,
                        principalTable: "Societies",
                        principalColumn: "Cvr_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Member_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cvr_number = table.Column<int>(type: "int", nullable: false),
                    SocietyCvr_number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Member_id);
                    table.ForeignKey(
                        name: "FK_Members_Societies_SocietyCvr_number",
                        column: x => x.SocietyCvr_number,
                        principalTable: "Societies",
                        principalColumn: "Cvr_number");
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "Address", "ClosingTime", "LocationAddress", "OpeningTime" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1429), null, new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1365) },
                    { 2, "1", new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1448), null, new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1444) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Address", "AccessKey", "Bathroom", "Capacity", "IsBooked", "MunicipalityZipcode", "Zipcode" },
                values: new object[,]
                {
                    { "Denandenvej", 0, 2, 0, false, null, 7700 },
                    { "Denførstevej", 0, 1, 0, false, null, 8000 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Member_id", "Cvr_number", "Name", "SocietyCvr_number" },
                values: new object[,]
                {
                    { 1, 1, "Jesper", null },
                    { 2, 2, "Carsten", null }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Zipcode", "AccessKey", "Name" },
                values: new object[,]
                {
                    { 7700, 2222, "Thisted" },
                    { 8000, 1111, "Aarhus" }
                });

            migrationBuilder.InsertData(
                table: "Societies",
                columns: new[] { "Cvr_number", "Activity", "BookingId", "MunicipalityZipcode", "Zipcode" },
                values: new object[,]
                {
                    { 1, "Fodbold", 0, null, 8000 },
                    { 2, "Håndbold", 0, null, 7700 }
                });

            migrationBuilder.InsertData(
                table: "Chairmen",
                columns: new[] { "Member_id", "Address", "Cpr_number", "Cvr_number", "Name" },
                values: new object[] { 1, "Chairmanvejnummeret", 1111, 1, "Martin" });

            migrationBuilder.InsertData(
                table: "Chairmen",
                columns: new[] { "Member_id", "Address", "Cpr_number", "Cvr_number", "Name" },
                values: new object[] { 2, "Chairmanvejnummerto", 2222, 2, "Jens" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_LocationAddress",
                table: "Bookings",
                column: "LocationAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Chairmen_Cvr_number",
                table: "Chairmen",
                column: "Cvr_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MunicipalityZipcode",
                table: "Locations",
                column: "MunicipalityZipcode");

            migrationBuilder.CreateIndex(
                name: "IX_Members_SocietyCvr_number",
                table: "Members",
                column: "SocietyCvr_number");

            migrationBuilder.CreateIndex(
                name: "IX_Societies_BookingId",
                table: "Societies",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Societies_MunicipalityZipcode",
                table: "Societies",
                column: "MunicipalityZipcode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chairmen");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Societies");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Municipalities");*/
        }
    }
}
