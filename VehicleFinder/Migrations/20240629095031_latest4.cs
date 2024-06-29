using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01b0a53a-4845-4d5a-9403-f9b759a580b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9ff91fa-f4da-4a53-af40-1b3f802b9abd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ec1bda5-19e9-4e1c-8e31-bdc93371099c", null, "ADMIN", "ADMIN" },
                    { "f19649d9-88a2-4c70-b61e-c60cce7b6166", null, "USER", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "01b0a53a-4845-4d5a-9403-f9b759a580b0", null, "USER", "USER" },
                    { "c9ff91fa-f4da-4a53-af40-1b3f802b9abd", null, "ADMIN", "ADMIN" }
                });
        }
    }
}
