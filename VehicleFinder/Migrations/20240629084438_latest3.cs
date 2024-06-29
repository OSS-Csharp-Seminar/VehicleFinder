using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991bdcdf-b272-4d3a-83a7-83c2d10b9211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab807dda-8bca-494c-b5e9-759a1aef0e88");

            migrationBuilder.RenameColumn(
                name: "LasttName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01b0a53a-4845-4d5a-9403-f9b759a580b0", null, "USER", "USER" },
                    { "c9ff91fa-f4da-4a53-af40-1b3f802b9abd", null, "ADMIN", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01b0a53a-4845-4d5a-9403-f9b759a580b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9ff91fa-f4da-4a53-af40-1b3f802b9abd");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LasttName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "991bdcdf-b272-4d3a-83a7-83c2d10b9211", null, "USER", "USER" },
                    { "ab807dda-8bca-494c-b5e9-759a1aef0e88", null, "ADMIN", "ADMIN" }
                });
        }
    }
}
