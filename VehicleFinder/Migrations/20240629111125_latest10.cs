using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FuelTypeString",
                table: "Engines",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "307bb627-e0cb-4b5d-93fe-663c537ce6d9", null, "USER", "USER" },
                    { "f7a43b03-c5ea-4798-9db8-6708139bb83b", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dccf688-3288-411b-b7ec-80482c75b388", 0, "ca155eef-bc3b-4362-b82b-e140a4e552d3", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEMxELlIu99OZKFjP0+mOzosBnrPkTjDxM0OMJayEXvCWHDDVS7moxnF7nM0bXbpdpQ==", "1234567890", true, "7ab977cb-b3b1-4286-b5be-1cdcdcd6281a", false, "user@user" },
                    { "e5ef9e99-a7d5-4648-9bbd-9089fabf91ed", 0, "f229d5e9-0c68-4fc0-b610-064da42fa495", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEAxr6BvogHm5r6Es6QSW3auCSdQ5BQV4/3ZX9XHCbrZ6LmlYbopyo/e2mdxRPiAu5A==", "1234567890", true, "aa91944d-874f-4d7d-8cdc-0fc8aefcfa40", false, "admin@eadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "307bb627-e0cb-4b5d-93fe-663c537ce6d9", "2dccf688-3288-411b-b7ec-80482c75b388" },
                    { "f7a43b03-c5ea-4798-9db8-6708139bb83b", "e5ef9e99-a7d5-4648-9bbd-9089fabf91ed" }
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
                keyValues: new object[] { "307bb627-e0cb-4b5d-93fe-663c537ce6d9", "2dccf688-3288-411b-b7ec-80482c75b388" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7a43b03-c5ea-4798-9db8-6708139bb83b", "e5ef9e99-a7d5-4648-9bbd-9089fabf91ed" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "307bb627-e0cb-4b5d-93fe-663c537ce6d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7a43b03-c5ea-4798-9db8-6708139bb83b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dccf688-3288-411b-b7ec-80482c75b388");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5ef9e99-a7d5-4648-9bbd-9089fabf91ed");

            migrationBuilder.DropColumn(
                name: "FuelTypeString",
                table: "Engines");

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
    }
}
