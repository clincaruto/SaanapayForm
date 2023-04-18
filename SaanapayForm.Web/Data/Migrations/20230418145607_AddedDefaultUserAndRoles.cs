using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "strUserRole",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21ebb8e1-0747-407cS-2150-017a5457c337", "5be1e4a2-9cad-4a98-bbe7-61a423444baa", "User", "USER" },
                    { "21edd8e1-0747-407b-2150-017a5457c337", "7faa024a-babc-4358-b065-ec8dc499856f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4e9b4d5d-4196-4a1c-9324-0b487b213ce9", 0, "30705e18-d00f-4bd7-aadb-8f4af8eab6d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEN/iT2R9Hl6CFf6RAaovdXZznDn5ths4UgPGZb9F+TwOFJz1xb2UjpccUoRn7bi66w==", null, false, "ae0b605b-cb9d-495f-8ead-29b7dcb8365a", null, false, null },
                    { "a565265f-3bc4-495d-95c7-0d8bfe2564d3", 0, "c24dd739-48ca-4d1b-b42f-906bc35845bb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin3@test.com", false, "System", "Admin", false, null, "ADMIN3@TEST.COM", null, "AQAAAAEAACcQAAAAEI7lNIIMw6uMUTb4E2JKsjhr780nh5GulZxVaay+/MESKMwVX964GUTT7d5e91cl3w==", null, false, "5474dcaf-9b93-4242-878b-227b55f21d02", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "21ebb8e1-0747-407cS-2150-017a5457c337", "4e9b4d5d-4196-4a1c-9324-0b487b213ce9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "21edd8e1-0747-407b-2150-017a5457c337", "a565265f-3bc4-495d-95c7-0d8bfe2564d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21ebb8e1-0747-407cS-2150-017a5457c337", "4e9b4d5d-4196-4a1c-9324-0b487b213ce9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21edd8e1-0747-407b-2150-017a5457c337", "a565265f-3bc4-495d-95c7-0d8bfe2564d3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3");

            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "strUserRole",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
