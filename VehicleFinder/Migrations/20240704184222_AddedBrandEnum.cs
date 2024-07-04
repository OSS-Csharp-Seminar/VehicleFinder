using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddedBrandEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0f4b9901-0da4-473f-a63b-bf9acb77386e", null, "ADMIN", "ADMIN" },
                    { "ebb42edf-342e-406c-b67a-144da7f9ca1c", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65ab0927-b8b5-4a17-a8ad-ec78692dc0e3", 0, "6979ef1f-6795-486c-bcb2-9a3e2285f513", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEEafSgNVHS/3TvV/SSWb7kXZltd3jBQttkMKvno6niJOpXLfjkfuuN+5UCiGyQ4VvA==", "1234567890", true, "73edd44b-f4ed-4134-b5a8-39ab4d7fc9e8", false, "user@user" },
                    { "9da06bc1-cacb-4ee6-b5b7-fbed0d81fcfb", 0, "05d77407-0ba5-43a1-9950-66218365f872", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEHkTjJT7WRjA35J6Hxa7XdC6tiAih5qzx21w+jyFoEguTLe8NvLaKv8yPjiI51DtYw==", "1234567890", true, "1a5a62ff-8916-4dd2-bc96-ebdda7519eaf", false, "admin@eadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ebb42edf-342e-406c-b67a-144da7f9ca1c", "65ab0927-b8b5-4a17-a8ad-ec78692dc0e3" },
                    { "0f4b9901-0da4-473f-a63b-bf9acb77386e", "9da06bc1-cacb-4ee6-b5b7-fbed0d81fcfb" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebb42edf-342e-406c-b67a-144da7f9ca1c", "65ab0927-b8b5-4a17-a8ad-ec78692dc0e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f4b9901-0da4-473f-a63b-bf9acb77386e", "9da06bc1-cacb-4ee6-b5b7-fbed0d81fcfb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4b9901-0da4-473f-a63b-bf9acb77386e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebb42edf-342e-406c-b67a-144da7f9ca1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65ab0927-b8b5-4a17-a8ad-ec78692dc0e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9da06bc1-cacb-4ee6-b5b7-fbed0d81fcfb");

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
    }
}
