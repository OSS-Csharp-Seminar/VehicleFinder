using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "612161a4-2281-4708-9344-ccde0fb784fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbf0f793-a70e-42c6-81f9-35737bf76f81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3914d22c-c0fa-4432-be16-f875930faec9", null, "ADMIN", "ADMIN" },
                    { "e3a10132-77d8-457e-92c7-cf763b0c0488", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "678c2b9c-5148-499b-9155-3a41061e2058", 0, "812c3983-7c35-4ffe-9474-654951444a5d", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEBM13ZScixh+Wu5DMxAbx2QBZvQWrCqFyhajWAa1Isjm5A4sXOUCF6gR+4tQyMQ+YA==", "1234567890", true, "9623dfb1-1703-4c55-a3e1-28b56d1ddacc", false, "admin@eadmin" },
                    { "cb6bcc23-5c1a-46e2-a554-8d5df2407f78", 0, "b5a7a906-e2ac-49c4-a0b6-353e0ce44fca", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEOHA5KHuRFbVIwNcmiwM4q567Zsj/EGr2yzccSAx/Es/U6befHj76Z6dZxyVZcYChA==", "1234567890", true, "5d28430c-e2b9-4382-b941-0de4a88660fd", false, "user@user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3914d22c-c0fa-4432-be16-f875930faec9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3a10132-77d8-457e-92c7-cf763b0c0488");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "678c2b9c-5148-499b-9155-3a41061e2058");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb6bcc23-5c1a-46e2-a554-8d5df2407f78");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "612161a4-2281-4708-9344-ccde0fb784fc", null, "USER", "USER" },
                    { "fbf0f793-a70e-42c6-81f9-35737bf76f81", null, "ADMIN", "ADMIN" }
                });
        }
    }
}
