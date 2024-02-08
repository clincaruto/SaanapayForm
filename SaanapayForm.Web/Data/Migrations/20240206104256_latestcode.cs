using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class latestcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "514e9e38-9bbd-45f0-ba2f-29908b59f08e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "eddb98fc-94c3-454e-bf8e-f1d67f823eea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "808ae726-6d48-4181-a0fe-24ce3b01f067", "AQAAAAEAACcQAAAAEPxi0vxjIJWVriVBSZ2RCAkN8nswsf3hRJzX6AgERAB8UN6rlON2M0CQDlAi/rFreg==", "3f89afd1-b0bb-4d76-9c03-35be124a2fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6adeb1da-bd69-4eaa-a7b7-38a9cfaf4a63", "AQAAAAEAACcQAAAAEJPR+My5ap0nXcpKXYk1jOMNsmpZK7eTrnzRASTkmgasOcf0uIvABZ7s3+pKO5GY8A==", "9cd6de60-6b0e-4fe1-939b-6847678bc9d7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
