using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class updateTypeForConsumption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "AverageConsumption",
                table: "Vehicles",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a4add19-5ba6-4ac6-95ee-70f089ca21df", null, "USER", "USER" },
                    { "bcc15362-1dde-40b7-b46d-6e2d9b232f3a", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b6d4a4c-7490-494b-a517-747ed482986e", 0, "4880f5a7-be46-4838-911e-15f75fdf6686", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEHzuXHKy0Nq78hL6zUd9SldlVXZghCdsqAZsJ5Tq/FRuXldQ0PXLLtPM0qLQi99KGQ==", "1234567890", true, "85dc869f-804a-48db-a9e6-223999d73e18", false, "user@user" },
                    { "5374d10c-4cd5-4c91-b44a-910b3efaaa50", 0, "a55edeee-690c-4aec-aebe-be2f0a14d058", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEFtzUZlmbQUE75HqJKkz6Qak4UOACzK3b440d5NGuWG3NcLVC44blZM2cldTNfRNqg==", "1234567890", true, "a20632ab-8f65-4416-bd89-7f017cf69472", false, "admin@eadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6a4add19-5ba6-4ac6-95ee-70f089ca21df", "0b6d4a4c-7490-494b-a517-747ed482986e" },
                    { "bcc15362-1dde-40b7-b46d-6e2d9b232f3a", "5374d10c-4cd5-4c91-b44a-910b3efaaa50" }
                });

            ExecuteSqlScript(migrationBuilder);
        }

        private void ExecuteSqlScript(MigrationBuilder migrationBuilder)
        {
            // Get the directory of the current file
            var currentDirectory = Directory.GetCurrentDirectory();

            // Construct the full path to your SQL script relative to the current directory
            var relativePath = Path.Combine("Migrations", "SeedData", "SeedEngines.sql");
            var sqlScriptPath = Path.Combine(currentDirectory, relativePath);

            // Check if the file exists before attempting to read it
            if (File.Exists(sqlScriptPath))
            {
                // Read the SQL script content
                var sqlScript = File.ReadAllText(sqlScriptPath);

                // Execute the SQL script using migrationBuilder
                migrationBuilder.Sql(sqlScript);
            }
            else
            {
                // Handle the case where the SQL script file does not exist
                throw new FileNotFoundException($"SQL script file not found at path: {sqlScriptPath}");
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a4add19-5ba6-4ac6-95ee-70f089ca21df", "0b6d4a4c-7490-494b-a517-747ed482986e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcc15362-1dde-40b7-b46d-6e2d9b232f3a", "5374d10c-4cd5-4c91-b44a-910b3efaaa50" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a4add19-5ba6-4ac6-95ee-70f089ca21df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcc15362-1dde-40b7-b46d-6e2d9b232f3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b6d4a4c-7490-494b-a517-747ed482986e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5374d10c-4cd5-4c91-b44a-910b3efaaa50");

            migrationBuilder.AlterColumn<decimal>(
                name: "AverageConsumption",
                table: "Vehicles",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
    }
}
