using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class updateengine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d1bf0ee-415a-439d-88df-e8277a274b33", "2faded21-8809-49d7-a499-34010df36d08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4c3d22c-f298-42ec-92f6-f0f56b24937c", "ed9197d5-f21a-4801-96bc-348889ef3e01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1bf0ee-415a-439d-88df-e8277a274b33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4c3d22c-f298-42ec-92f6-f0f56b24937c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2faded21-8809-49d7-a499-34010df36d08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed9197d5-f21a-4801-96bc-348889ef3e01");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a667f1f-8d45-48ca-b9c5-c97aeecfdf8f", null, "USER", "USER" },
                    { "bb9d7fb3-39cf-4e0b-aee7-07a4c9dfc806", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8fa245bf-2259-4607-811a-394cd66a100c", 0, "d27de785-8ee6-453b-9ed4-22b078d0637f", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAED15w5eCT7IsCDt+ciSIzLR3KCMjufnSRusyso+d260axVaXQPad++FIDAkvMfZGyw==", "1234567890", true, "29ba8c23-18ee-468c-a79e-f803cdfbc179", false, "user@user" },
                    { "9b2f410e-b8b6-4357-a220-f4bc52339178", 0, "908fa6b8-d1f7-4d17-a214-2fa53459b5f7", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEKq+LrmH4sH/NiDwluFzjxYNyg+iXLh5r1Mie/D7yWxxJHZaLjQ4WzvDOVSqQtgY2A==", "1234567890", true, "2ae46e5b-6ddb-48c9-9e1a-2abff0d8572d", false, "admin@eadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a667f1f-8d45-48ca-b9c5-c97aeecfdf8f", "8fa245bf-2259-4607-811a-394cd66a100c" },
                    { "bb9d7fb3-39cf-4e0b-aee7-07a4c9dfc806", "9b2f410e-b8b6-4357-a220-f4bc52339178" }
                });
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a667f1f-8d45-48ca-b9c5-c97aeecfdf8f", "8fa245bf-2259-4607-811a-394cd66a100c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb9d7fb3-39cf-4e0b-aee7-07a4c9dfc806", "9b2f410e-b8b6-4357-a220-f4bc52339178" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a667f1f-8d45-48ca-b9c5-c97aeecfdf8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb9d7fb3-39cf-4e0b-aee7-07a4c9dfc806");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fa245bf-2259-4607-811a-394cd66a100c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b2f410e-b8b6-4357-a220-f4bc52339178");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d1bf0ee-415a-439d-88df-e8277a274b33", null, "ADMIN", "ADMIN" },
                    { "a4c3d22c-f298-42ec-92f6-f0f56b24937c", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2faded21-8809-49d7-a499-34010df36d08", 0, "7cee75d8-ed54-4c28-a7b0-b05b7e8cb683", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEAGqIoO6/iDmknCDd1Wd+N3YXJVxMufbJdq5N8aYlzTgV+ZDgIee0x3AmnkF5RumOg==", "1234567890", true, "0d6abe44-470f-4e95-9f0b-cc0f0081eb0c", false, "admin@eadmin" },
                    { "ed9197d5-f21a-4801-96bc-348889ef3e01", 0, "7815ee89-a62d-426b-a95c-18fb4581e618", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAECWsBCKP+OzzMLM39YOP0CmYJSzeNZlWKATEzD3UThUaRH30F3JpujRoBi1dyY4epA==", "1234567890", true, "9230fe0f-fe6b-45a0-948c-66d57f4a194c", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5d1bf0ee-415a-439d-88df-e8277a274b33", "2faded21-8809-49d7-a499-34010df36d08" },
                    { "a4c3d22c-f298-42ec-92f6-f0f56b24937c", "ed9197d5-f21a-4801-96bc-348889ef3e01" }
                });
        }
    }
}
