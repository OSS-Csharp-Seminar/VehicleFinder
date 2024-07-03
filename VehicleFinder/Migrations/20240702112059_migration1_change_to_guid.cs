using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleFinder.Migrations
{
    /// <inheritdoc />
    public partial class migration1_change_to_guid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "EngineId",
                table: "Vehicles",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "BodyId",
                table: "Vehicles",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Vehicles",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "VehicleId",
                table: "Listings",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Listings",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Engines",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Bodies",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "067aa828-bb09-4e2f-8c3c-bf70775a0f89", null, "ADMIN", "ADMIN" },
                    { "5d7a5de9-f1b8-4121-b977-a51ad3eb871b", null, "USER", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06863604-9db7-4e5c-8559-2cbc4161e931", 0, "da9d1708-9bbe-48c9-a95f-d99811aed2f3", "user@user", false, "user", "user", false, null, "USER@USER", "USER@USER", "AQAAAAIAAYagAAAAEMF1Ab3M8+OjbtbYHMfbjkucRQm1uyl34NObZCfTRKZ/fc5jsIC4w5xJCsM6SYb+qA==", "1234567890", true, "c44af5ae-3941-4b95-a0cb-17224bfb2327", false, "user@user" },
                    { "3c7586c5-1e68-4ced-b5da-d2aca7917d44", 0, "7fc5e921-70ad-488a-9426-3bd3ad1f878b", "admin@eadmin", false, "admin", "admin", false, null, "ADMIN@ADMIN", "ADMIN@ADMIN", "AQAAAAIAAYagAAAAEA7KnBYpzU3RPAxRDEB/LVxxmcSiq8x0M5JAuLlxrWr5R3TyHGRn6OnG/cC9HJID5g==", "1234567890", true, "6d81454f-508f-477f-89d2-9df4d6dcd914", false, "admin@eadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5d7a5de9-f1b8-4121-b977-a51ad3eb871b", "06863604-9db7-4e5c-8559-2cbc4161e931" },
                    { "067aa828-bb09-4e2f-8c3c-bf70775a0f89", "3c7586c5-1e68-4ced-b5da-d2aca7917d44" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d7a5de9-f1b8-4121-b977-a51ad3eb871b", "06863604-9db7-4e5c-8559-2cbc4161e931" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "067aa828-bb09-4e2f-8c3c-bf70775a0f89", "3c7586c5-1e68-4ced-b5da-d2aca7917d44" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "067aa828-bb09-4e2f-8c3c-bf70775a0f89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d7a5de9-f1b8-4121-b977-a51ad3eb871b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06863604-9db7-4e5c-8559-2cbc4161e931");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7586c5-1e68-4ced-b5da-d2aca7917d44");

            migrationBuilder.AlterColumn<int>(
                name: "EngineId",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "BodyId",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Listings",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Listings",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Engines",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Bodies",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

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
        }
    }
}
