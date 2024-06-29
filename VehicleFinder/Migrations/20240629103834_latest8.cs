using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c91d8f39-bfe4-4052-b59b-c0af168294d9", "23b88651-cdae-45a1-8ea9-bca9d86a7d0f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2967d04f-1a83-4482-94f9-1cbbfc49e7c2", "f81acd5a-16a4-4b25-9c69-5cbe7a32893c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2967d04f-1a83-4482-94f9-1cbbfc49e7c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c91d8f39-bfe4-4052-b59b-c0af168294d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23b88651-cdae-45a1-8ea9-bca9d86a7d0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f81acd5a-16a4-4b25-9c69-5cbe7a32893c");

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
                    { "4b39d665-dffd-4fe7-aae4-c9ebdac0f2a6", null, "ADMIN", "ADMIN" },
                    { "7b144ad7-941d-43ea-8b97-2c0f9519a29d", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "68eff8a9-9adb-4f82-b7b2-7d134ae5417d", 0, "dd897a3d-47a7-41cf-a790-7cd7144efb7d", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEO4mqvp2iMARnY6+N/Zqosz4zg6Jvqa3O8msXehMVvn5RwcnCqB/aJOZaorgNn1i1w==", "1234567890", true, "c2af0a25-747a-4b5e-9c0e-b472cd6d4348", false, "admin@eadmin" },
                    { "e400a1ac-f0ed-4b71-922a-3bd9c7cb58d8", 0, "c136702c-4ed3-44a0-bd55-a37408fbdfd8", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEB64e/CTCZluDWTiJxhHH2WW+Xdvb9Ih7cCm4yBg/puNBCba0mx9ywatWaxF91LA4g==", "1234567890", true, "d3820d03-0c9e-4501-bfef-f27c047c2098", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4b39d665-dffd-4fe7-aae4-c9ebdac0f2a6", "68eff8a9-9adb-4f82-b7b2-7d134ae5417d" },
                    { "7b144ad7-941d-43ea-8b97-2c0f9519a29d", "e400a1ac-f0ed-4b71-922a-3bd9c7cb58d8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b39d665-dffd-4fe7-aae4-c9ebdac0f2a6", "68eff8a9-9adb-4f82-b7b2-7d134ae5417d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7b144ad7-941d-43ea-8b97-2c0f9519a29d", "e400a1ac-f0ed-4b71-922a-3bd9c7cb58d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b39d665-dffd-4fe7-aae4-c9ebdac0f2a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b144ad7-941d-43ea-8b97-2c0f9519a29d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68eff8a9-9adb-4f82-b7b2-7d134ae5417d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e400a1ac-f0ed-4b71-922a-3bd9c7cb58d8");

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
                    { "2967d04f-1a83-4482-94f9-1cbbfc49e7c2", null, "USER", "USER" },
                    { "c91d8f39-bfe4-4052-b59b-c0af168294d9", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23b88651-cdae-45a1-8ea9-bca9d86a7d0f", 0, "46f9c2b2-f2fc-404a-a8b8-579500297bcf", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEEA86KRQbB+I4M3mvhRKdJzgSns3kwolUwrNtegsdAu9ojDJRrLW+LRccMH6z4vSLg==", "1234567890", true, "d139620d-d079-420a-9aee-9408d7a0285d", false, "admin@eadmin" },
                    { "f81acd5a-16a4-4b25-9c69-5cbe7a32893c", 0, "efdfbf9a-fc6c-4f9e-aed0-71d0d2ad9b69", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEEAvcmDfDjPuLT4GmVG8g0+MhhxzPzIHSrs1q8DBceiTnyhYKK8VAW1LdkK2bwzOkg==", "1234567890", true, "f798c986-6872-4238-a099-85c20e61924e", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c91d8f39-bfe4-4052-b59b-c0af168294d9", "23b88651-cdae-45a1-8ea9-bca9d86a7d0f" },
                    { "2967d04f-1a83-4482-94f9-1cbbfc49e7c2", "f81acd5a-16a4-4b25-9c69-5cbe7a32893c" }
                });
        }
    }
}
