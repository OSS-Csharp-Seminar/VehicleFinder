using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class vehicleupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25aba159-6efc-4d7f-b438-8baf1914462e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e824e09-e853-47c9-bcd1-240faa4cafd1");

            migrationBuilder.AddColumn<int>(
                name: "Kilometers",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturingYear",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPreviousOwners",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "RegistrationUntil",
                table: "Vehicles",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "502e55d9-8a3f-4e3b-a5c6-883ed501b4c4", null, "ADMIN", "ADMIN" },
                    { "bc3135e4-491f-40ea-a29b-cb981053b03c", null, "USER", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "502e55d9-8a3f-4e3b-a5c6-883ed501b4c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3135e4-491f-40ea-a29b-cb981053b03c");

            migrationBuilder.DropColumn(
                name: "Kilometers",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ManufacturingYear",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "NumberOfPreviousOwners",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "RegistrationUntil",
                table: "Vehicles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25aba159-6efc-4d7f-b438-8baf1914462e", null, "ADMIN", "ADMIN" },
                    { "7e824e09-e853-47c9-bcd1-240faa4cafd1", null, "USER", "USER" }
                });
        }
    }
}
