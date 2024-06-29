using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;
using System.Reflection;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "878a45dd-4b2e-460a-90a1-791f96f4552d", null, "USER", "USER" },
                    { "d559c9ac-6d6a-4c14-abd4-8df7144e57b5", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5c55b159-bbaf-4b27-ba4a-174467c41620", 0, "428ab6c4-4a44-4645-b8aa-4f08ccd3432f", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEPRq591WZneer1kgNBBgxEffVZ8J0UQNgVHkJwrIaPAhK4cpA64kW/w0WHeVHwGIQg==", "1234567890", true, "8974234e-c01c-4b99-95fb-2f7e36791e86", false, "admin@eadmin" },
                    { "84d009a6-a468-4186-8ea5-1ff697edcf47", 0, "e388cac1-b5eb-449e-9ba4-1f55d5094ea9", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEDsosWI+Yw0GnsUUmD5+lkHJmhaiphgcitUtf/E+mG8bb0Cz28plpMIxTEhq+u3gdQ==", "1234567890", true, "20925271-31ef-49c9-a3d9-bca2ef49a62c", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d559c9ac-6d6a-4c14-abd4-8df7144e57b5", "5c55b159-bbaf-4b27-ba4a-174467c41620" },
                    { "878a45dd-4b2e-460a-90a1-791f96f4552d", "84d009a6-a468-4186-8ea5-1ff697edcf47" }
                });


        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d559c9ac-6d6a-4c14-abd4-8df7144e57b5", "5c55b159-bbaf-4b27-ba4a-174467c41620" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "878a45dd-4b2e-460a-90a1-791f96f4552d", "84d009a6-a468-4186-8ea5-1ff697edcf47" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "878a45dd-4b2e-460a-90a1-791f96f4552d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d559c9ac-6d6a-4c14-abd4-8df7144e57b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c55b159-bbaf-4b27-ba4a-174467c41620");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84d009a6-a468-4186-8ea5-1ff697edcf47");

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


            migrationBuilder.Sql("DELETE FROM Engines WHERE ...");
        }
    }
}
