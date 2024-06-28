using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Body_BodyId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Engine_EngineId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BodyId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engine",
                table: "Engine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Body",
                table: "Body");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c6fee9a-1e61-4c5a-9f41-ac9db6dd0907");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8778fa3e-2274-42dc-99f2-4332230f0c32");

            migrationBuilder.RenameTable(
                name: "Engine",
                newName: "Engines");

            migrationBuilder.RenameTable(
                name: "Body",
                newName: "Bodies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engines",
                table: "Engines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bodies",
                table: "Bodies",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "991bdcdf-b272-4d3a-83a7-83c2d10b9211", null, "USER", "USER" },
                    { "ab807dda-8bca-494c-b5e9-759a1aef0e88", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyId",
                table: "Vehicles",
                column: "BodyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Bodies_BodyId",
                table: "Vehicles",
                column: "BodyId",
                principalTable: "Bodies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Engines_EngineId",
                table: "Vehicles",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Bodies_BodyId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Engines_EngineId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BodyId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engines",
                table: "Engines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bodies",
                table: "Bodies");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991bdcdf-b272-4d3a-83a7-83c2d10b9211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab807dda-8bca-494c-b5e9-759a1aef0e88");

            migrationBuilder.RenameTable(
                name: "Engines",
                newName: "Engine");

            migrationBuilder.RenameTable(
                name: "Bodies",
                newName: "Body");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engine",
                table: "Engine",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Body",
                table: "Body",
                column: "Id");

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
    }
}
