using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class migration0_addengines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff33c9aa-d4b6-433f-8320-078da3e86ee5", "8dff4125-94bf-46cd-8415-e0bf6e360eb2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3008fcd-3f85-4e10-ba2a-46c3621e5c19", "b15d269e-e091-4baa-b63c-139b0a1bbc61" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3008fcd-3f85-4e10-ba2a-46c3621e5c19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff33c9aa-d4b6-433f-8320-078da3e86ee5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dff4125-94bf-46cd-8415-e0bf6e360eb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b15d269e-e091-4baa-b63c-139b0a1bbc61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c9f5206-f220-49a6-9808-dee5b71052f4", null, "ADMIN", "ADMIN" },
                    { "87aeed15-300f-466c-a359-64c40a469fb9", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3b44b7da-da1a-4361-a675-bd91f7074063", 0, "11eec63a-ae48-47ca-9873-9a313d2ccffe", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEB7BokfzObhfUm+vTxAv2TMPKJ+bOrWwK+rfoptNYuaBR5rBoXZFnrDk2Jf/WmFmbA==", "1234567890", true, "2efddc18-21be-435d-8182-847e68e2a312", false, "admin@eadmin" },
                    { "caa566d2-950d-4d44-bd7a-4653784e947d", 0, "f19a491f-09f3-4baf-a133-f888e827abf9", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEFapMcS41rAwJF8PIlSkpRRI5oIxLvcXPYhizIedtdHfh/TnNQ4AN4VXyO1/j5GziQ==", "1234567890", true, "8e61b3b3-3017-40a7-ac0a-bccf9ab875e1", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3c9f5206-f220-49a6-9808-dee5b71052f4", "3b44b7da-da1a-4361-a675-bd91f7074063" },
                    { "87aeed15-300f-466c-a359-64c40a469fb9", "caa566d2-950d-4d44-bd7a-4653784e947d" }
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
                keyValues: new object[] { "3c9f5206-f220-49a6-9808-dee5b71052f4", "3b44b7da-da1a-4361-a675-bd91f7074063" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87aeed15-300f-466c-a359-64c40a469fb9", "caa566d2-950d-4d44-bd7a-4653784e947d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c9f5206-f220-49a6-9808-dee5b71052f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87aeed15-300f-466c-a359-64c40a469fb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b44b7da-da1a-4361-a675-bd91f7074063");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caa566d2-950d-4d44-bd7a-4653784e947d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d3008fcd-3f85-4e10-ba2a-46c3621e5c19", null, "USER", "USER" },
                    { "ff33c9aa-d4b6-433f-8320-078da3e86ee5", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8dff4125-94bf-46cd-8415-e0bf6e360eb2", 0, "139ba13c-7ba5-439c-ab21-8f12748de033", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEINYmEy54Jfn9zJ4sp8R5RdRwAhq8epbIQ/cyxJ5p4r6y9VtP33TaUTWv3oQO0mbrw==", "1234567890", true, "faef92fd-6179-4bf2-be8e-854da4144188", false, "admin@eadmin" },
                    { "b15d269e-e091-4baa-b63c-139b0a1bbc61", 0, "16a76f50-2700-472c-8ee9-fa6de443da97", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEMtP4UgnAZ7VunlsxAFk1K16Ya7CZwj8HplQsqNs+DkvzKGCTocjPfjgaKqK3Hc7Dw==", "1234567890", true, "eeabca89-09d0-4fc3-ac86-8ff989699ea3", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ff33c9aa-d4b6-433f-8320-078da3e86ee5", "8dff4125-94bf-46cd-8415-e0bf6e360eb2" },
                    { "d3008fcd-3f85-4e10-ba2a-46c3621e5c19", "b15d269e-e091-4baa-b63c-139b0a1bbc61" }
                });
        }
    }
}
