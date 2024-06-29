using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ec1bda5-19e9-4e1c-8e31-bdc93371099c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f19649d9-88a2-4c70-b61e-c60cce7b6166");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "612161a4-2281-4708-9344-ccde0fb784fc", null, "USER", "USER" },
                    { "fbf0f793-a70e-42c6-81f9-35737bf76f81", null, "ADMIN", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "612161a4-2281-4708-9344-ccde0fb784fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbf0f793-a70e-42c6-81f9-35737bf76f81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ec1bda5-19e9-4e1c-8e31-bdc93371099c", null, "ADMIN", "ADMIN" },
                    { "f19649d9-88a2-4c70-b61e-c60cce7b6166", null, "USER", "USER" }
                });
        }
    }
}
