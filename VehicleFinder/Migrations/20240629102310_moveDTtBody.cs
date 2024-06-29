using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class moveDTtBody : Migration
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

            migrationBuilder.DropColumn(
                name: "DrivetrainType",
                table: "Engines");

            migrationBuilder.AddColumn<int>(
                name: "DrivetrainType",
                table: "Bodies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4104e9d9-f112-4e55-ba60-110cd863fe96", null, "ADMIN", "ADMIN" },
                    { "e775a59b-4dfb-403a-b005-df0a3effa055", null, "USER", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4104e9d9-f112-4e55-ba60-110cd863fe96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e775a59b-4dfb-403a-b005-df0a3effa055");

            migrationBuilder.DropColumn(
                name: "DrivetrainType",
                table: "Bodies");

            migrationBuilder.AddColumn<int>(
                name: "DrivetrainType",
                table: "Engines",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
