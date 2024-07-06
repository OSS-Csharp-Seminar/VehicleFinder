using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class addedContactNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Listings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d0c7ad12-029c-43e0-8d7c-0fab9edeffa4", null, "USER", "USER" },
                    { "eaa44fa7-852a-42bf-bdd5-e258035fa95c", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65d92157-8621-4fad-b4ae-d0b4d58463cb", 0, "f6b2f6f0-fbfc-4e87-981d-b0792720f17c", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEBYJsDRhDRnF990NN0SnhoI8kwfyaVclhl3DwvNGJDuKoxT53xh/iHQCLShVbk/nDQ==", "1234567890", true, "3cf2dfb0-5f13-4bce-9f2a-0392b6dca68e", false, "admin@eadmin" },
                    { "989d8a5d-5c8a-4336-b11f-cf3ed6a38a6b", 0, "88393da7-cd80-45c3-981a-ab79fb9e65f5", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEAcRJ0q55BrIY22UjQkp/PaGKvWgKlBqADn4VJdkiBSpdpMW8ckieyj6Ndf8Yfal/g==", "1234567890", true, "f7457572-7764-44b1-ae02-d9c4252f7c3b", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "eaa44fa7-852a-42bf-bdd5-e258035fa95c", "65d92157-8621-4fad-b4ae-d0b4d58463cb" },
                    { "d0c7ad12-029c-43e0-8d7c-0fab9edeffa4", "989d8a5d-5c8a-4336-b11f-cf3ed6a38a6b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eaa44fa7-852a-42bf-bdd5-e258035fa95c", "65d92157-8621-4fad-b4ae-d0b4d58463cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0c7ad12-029c-43e0-8d7c-0fab9edeffa4", "989d8a5d-5c8a-4336-b11f-cf3ed6a38a6b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c7ad12-029c-43e0-8d7c-0fab9edeffa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaa44fa7-852a-42bf-bdd5-e258035fa95c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65d92157-8621-4fad-b4ae-d0b4d58463cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "989d8a5d-5c8a-4336-b11f-cf3ed6a38a6b");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Listings");

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
    }
}
