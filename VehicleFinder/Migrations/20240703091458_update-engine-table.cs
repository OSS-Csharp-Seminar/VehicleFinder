using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class updateenginetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcb84bb6-e5a0-4e9b-a15b-339edaf1a259", "7a2743e1-aeb4-458c-80d3-8ec5dce864d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d4a58fd-e971-4bf3-b248-fe257de8212f", "c44455d4-cf51-4cbf-b40b-1287e3ef1dce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d4a58fd-e971-4bf3-b248-fe257de8212f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcb84bb6-e5a0-4e9b-a15b-339edaf1a259");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a2743e1-aeb4-458c-80d3-8ec5dce864d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c44455d4-cf51-4cbf-b40b-1287e3ef1dce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "832d6a60-f164-4d8d-ab52-3b642d9de5a8", null, "USER", "USER" },
                    { "bb08b173-3606-4f28-91a5-2abba448cd61", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2caf4f25-0046-4f59-b9d0-bc56e8fb67b2", 0, "532f0c84-2815-478d-9092-bf535175b9b4", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEEXDvbIO7TRDb6wnpaJB1ef7lHPSOjqcPaVyGcMyEHhXN0AwCPFi5XbR5jCTlzP5aw==", "1234567890", true, "0946d00d-1f19-4446-aed4-dd5bb4930ed1", false, "admin@eadmin" },
                    { "45756045-f6a8-4d99-af37-9d06c2dd345d", 0, "2eb022e3-6fb0-4f4d-a673-f7e6b6cc7c1a", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEOFDZk3hrLr2hVn7FsIoNCV/ZoVdx110WS4VoGLYJl+Uuh9u8QJAkwJM9zylpzZmOw==", "1234567890", true, "820335f7-018d-446d-b07d-0234c75fc692", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb08b173-3606-4f28-91a5-2abba448cd61", "2caf4f25-0046-4f59-b9d0-bc56e8fb67b2" },
                    { "832d6a60-f164-4d8d-ab52-3b642d9de5a8", "45756045-f6a8-4d99-af37-9d06c2dd345d" }
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
                keyValues: new object[] { "bb08b173-3606-4f28-91a5-2abba448cd61", "2caf4f25-0046-4f59-b9d0-bc56e8fb67b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "832d6a60-f164-4d8d-ab52-3b642d9de5a8", "45756045-f6a8-4d99-af37-9d06c2dd345d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "832d6a60-f164-4d8d-ab52-3b642d9de5a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb08b173-3606-4f28-91a5-2abba448cd61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2caf4f25-0046-4f59-b9d0-bc56e8fb67b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45756045-f6a8-4d99-af37-9d06c2dd345d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d4a58fd-e971-4bf3-b248-fe257de8212f", null, "USER", "USER" },
                    { "dcb84bb6-e5a0-4e9b-a15b-339edaf1a259", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7a2743e1-aeb4-458c-80d3-8ec5dce864d4", 0, "a32af43e-a38b-4260-9b06-176e9088f641", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAENmpfrKOfdjgm1SH+9wG1y3+GTxR8HN8teI0o7qXVqIX+pFneSA1yPihYxMT0kcvTg==", "1234567890", true, "e30ab696-3d69-4a01-9482-2d8d00a2c5b7", false, "admin@eadmin" },
                    { "c44455d4-cf51-4cbf-b40b-1287e3ef1dce", 0, "3f491782-ee1a-4fe4-b749-0e2eb9ebffda", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEHmqwgKMI7SpAUC+tDcV+fpH1RYCNYa77HSM33/8gDN8L3V0+CIOe9DdrarqfRSh5g==", "1234567890", true, "c802ac62-6585-4fbe-8e4d-5deaf2980f5e", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dcb84bb6-e5a0-4e9b-a15b-339edaf1a259", "7a2743e1-aeb4-458c-80d3-8ec5dce864d4" },
                    { "1d4a58fd-e971-4bf3-b248-fe257de8212f", "c44455d4-cf51-4cbf-b40b-1287e3ef1dce" }
                });
        }
    }
}
