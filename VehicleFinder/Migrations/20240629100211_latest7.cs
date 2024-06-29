using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class latest7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
