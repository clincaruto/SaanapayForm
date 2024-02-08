using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class latestmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "6478628c-8883-4fa7-889f-6a01ea0c4da1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "da761f46-5409-4a9c-8cd4-a2b2321357a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5236287-7481-4e11-a54e-1ed4d3cdf19f", "AQAAAAEAACcQAAAAELgUag4QoAFbfCNgvYfcnp7OY752N2W5t7UdKcqEQ8KprwqAip+/VvgFnqB8h8/Gng==", "918cd0d4-f092-4fcf-bbf6-40c62e0d0629" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9fc20be-1b63-46d3-84df-b48559ec3483", "AQAAAAEAACcQAAAAECZ70mE3qV8jfJf9p8EMBXnxe9w380oftrfN4qMGVWY86b8YHDP2TIEPe4J1On5Mgg==", "ba0c213e-2c87-4a0c-82be-0f5264100445" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "7fff9edf-54ea-47df-a1dc-a7a8ca457ba5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "cdd8c098-87a8-40e1-9ca7-e88a7360c015");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a86ed30-24f4-490a-bc10-7eb8ee96613d", "AQAAAAEAACcQAAAAEB2STGWvH1KxbKZRFRn3TWwI8GbOYNWku3AIMXqY2mXf0NKXhtWjGK8UOw2f8CLKcw==", "44034a9f-8532-48b0-863c-760b3a08e803" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a771cba-d743-4aec-8a08-096e9e2ccb70", "AQAAAAEAACcQAAAAEL66ddSxN4xvBQaFDyxTbHob12oT39uFdvRMeAkv0j8a18+KhDE2RTeZRRg7zchvmQ==", "62e1966a-b692-4359-af7b-7218fdce2ce9" });
        }
    }
}
