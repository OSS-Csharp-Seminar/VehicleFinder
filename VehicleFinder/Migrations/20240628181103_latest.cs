using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "502e55d9-8a3f-4e3b-a5c6-883ed501b4c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3135e4-491f-40ea-a29b-cb981053b03c");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageConsumption",
                table: "Vehicles",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "BodyId",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GearCount",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShifterType",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Body",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DoorCount = table.Column<int>(type: "integer", nullable: false),
                    SeatCount = table.Column<int>(type: "integer", nullable: false),
                    ACType = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    BodyShape = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Body", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FuelType = table.Column<int>(type: "integer", nullable: false),
                    Horsepower = table.Column<int>(type: "integer", nullable: false),
                    DrivetrainType = table.Column<int>(type: "integer", nullable: false),
                    EngineCapacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c6fee9a-1e61-4c5a-9f41-ac9db6dd0907", null, "ADMIN", "ADMIN" },
                    { "8778fa3e-2274-42dc-99f2-4332230f0c32", null, "USER", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyId",
                table: "Vehicles",
                column: "BodyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EngineId",
                table: "Vehicles",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Body_BodyId",
                table: "Vehicles",
                column: "BodyId",
                principalTable: "Body",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Engine_EngineId",
                table: "Vehicles",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Body_BodyId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Engine_EngineId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Body");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BodyId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_EngineId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c6fee9a-1e61-4c5a-9f41-ac9db6dd0907");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8778fa3e-2274-42dc-99f2-4332230f0c32");

            migrationBuilder.DropColumn(
                name: "AverageConsumption",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BodyId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "GearCount",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ShifterType",
                table: "Vehicles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "502e55d9-8a3f-4e3b-a5c6-883ed501b4c4", null, "ADMIN", "ADMIN" },
                    { "bc3135e4-491f-40ea-a29b-cb981053b03c", null, "USER", "USER" }
                });
        }
    }
}
