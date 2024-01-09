using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class latest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "20fbb931-2194-4c39-bf9e-846017c5ae2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "10145d54-2a93-4674-823b-c4823d22ecef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27777cbc-73a6-4859-9393-97620b7cfe01", "AQAAAAEAACcQAAAAEI0YLBa9te9tSAqFxagRJlWBnVpL605U57FHeKFB1BgTTwc/rD19YzHnkMmZFwHfhw==", "759af10b-7005-44cd-8ca9-28d526073aa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebbde433-9ee9-4edc-9cc5-b9827162c2b1", "AQAAAAEAACcQAAAAENU+R4oJqfKvtL0JEvlLvqOhsQRtfb475XG0NUJJwaHrEkzTbSKQTsHtQIKBX+n2Zg==", "73683378-4085-427d-8cfd-7b3133e9557d" });
        }
    }
}
