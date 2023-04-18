using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "567d8462-a8e1-4f21-83db-926aafdf76cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "74b552e5-9ef8-416b-b824-380d1825e644");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a4e85460-0e08-4aff-b96c-8bdc474df9e4", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAECVe/iZ64cF151fVZW/0n+Uk5Julfvcmnss8rDE8s/GCil14GGAb+2CSKhPeAnfyyg==", "a6dec8d5-e954-490f-af36-2b706c602437", "user@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "48ec0f58-3b72-4783-8b26-23c3e118700f", true, "ADMIN3@TEST.COM", "AQAAAAEAACcQAAAAEGmGNXFx5GGPRn6Z+Yzd/M5JBt/8FiYo8SsHm8mt/PUJO+5feYHa9Y8jaDG339zNMg==", "db6073e0-fe9c-4276-a356-aa33772b8675", "admin3@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "5be1e4a2-9cad-4a98-bbe7-61a423444baa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "7faa024a-babc-4358-b065-ec8dc499856f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "30705e18-d00f-4bd7-aadb-8f4af8eab6d3", false, null, "AQAAAAEAACcQAAAAEN/iT2R9Hl6CFf6RAaovdXZznDn5ths4UgPGZb9F+TwOFJz1xb2UjpccUoRn7bi66w==", "ae0b605b-cb9d-495f-8ead-29b7dcb8365a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c24dd739-48ca-4d1b-b42f-906bc35845bb", false, null, "AQAAAAEAACcQAAAAEI7lNIIMw6uMUTb4E2JKsjhr780nh5GulZxVaay+/MESKMwVX964GUTT7d5e91cl3w==", "5474dcaf-9b93-4242-878b-227b55f21d02", null });
        }
    }
}
