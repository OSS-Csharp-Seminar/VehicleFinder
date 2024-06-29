using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest11enuminengine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "FuelType",
                table: "Engines",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e874e42-22d2-44e1-b0ee-e81e83d4b13d", null, "ADMIN", "ADMIN" },
                    { "6b75dde9-5835-4147-9af6-fab9ba5ef0f9", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "783bea08-bdfb-421d-9864-9798ce716a5c", 0, "c555195c-2349-4685-8cd4-b9e83c050b61", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAECPPdp/GXRc9cbkepxzkB2J+IREWNqYgPnMzJjSeX2EC8ayb2DwhTS8bBtOLbDLSJQ==", "1234567890", true, "6187e9dd-757d-46a4-ac15-bbf1c7f1ad27", false, "admin@eadmin" },
                    { "c698f478-a0b8-4afb-8aac-c609fa5d6098", 0, "fb7c5fe1-1bb6-49ca-a565-c2b346480162", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEJyTgZ1inMHiNQpX0eiA1gq2sz8JqLOjIljoLFw5JcSdnqpMATjqBWVIfRIAiBnu5Q==", "1234567890", true, "c572f66b-3afc-4584-99e2-d22af2d66e6a", false, "user@user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4e874e42-22d2-44e1-b0ee-e81e83d4b13d", "783bea08-bdfb-421d-9864-9798ce716a5c" },
                    { "6b75dde9-5835-4147-9af6-fab9ba5ef0f9", "c698f478-a0b8-4afb-8aac-c609fa5d6098" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e874e42-22d2-44e1-b0ee-e81e83d4b13d", "783bea08-bdfb-421d-9864-9798ce716a5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6b75dde9-5835-4147-9af6-fab9ba5ef0f9", "c698f478-a0b8-4afb-8aac-c609fa5d6098" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e874e42-22d2-44e1-b0ee-e81e83d4b13d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b75dde9-5835-4147-9af6-fab9ba5ef0f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "783bea08-bdfb-421d-9864-9798ce716a5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c698f478-a0b8-4afb-8aac-c609fa5d6098");

            migrationBuilder.AlterColumn<int>(
                name: "FuelType",
                table: "Engines",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
        }
    }
}
