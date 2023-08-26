using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class AddingPeridoToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "35719c61-0632-448a-beee-a0402999e114");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "d79932c8-9b6f-47c2-8b04-5e5edca1619b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca8017a-efad-417f-8d23-6d9e24bd70de", "AQAAAAEAACcQAAAAEBX6tjfpqoBAgpuG8K63M1v3jE6oWLCvhVVdW1TQs5yAr+bPUxFDtmKaAjKSoQ09oQ==", "987e6fbb-254d-4768-b5fb-3edd0f4ccddc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc17b310-3951-4f4d-9b2f-beb8c3f4b6af", "AQAAAAEAACcQAAAAEIycgwAtsqfiO8ynSf9JUv87nUF7YugR9yssCn9j8skUVeedOXMargJaifMaXHOOTA==", "55c9f9f7-e5db-4bc7-a613-89c8eeb85dee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4e85460-0e08-4aff-b96c-8bdc474df9e4", "AQAAAAEAACcQAAAAECVe/iZ64cF151fVZW/0n+Uk5Julfvcmnss8rDE8s/GCil14GGAb+2CSKhPeAnfyyg==", "a6dec8d5-e954-490f-af36-2b706c602437" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48ec0f58-3b72-4783-8b26-23c3e118700f", "AQAAAAEAACcQAAAAEGmGNXFx5GGPRn6Z+Yzd/M5JBt/8FiYo8SsHm8mt/PUJO+5feYHa9Y8jaDG339zNMg==", "db6073e0-fe9c-4276-a356-aa33772b8675" });
        }
    }
}
