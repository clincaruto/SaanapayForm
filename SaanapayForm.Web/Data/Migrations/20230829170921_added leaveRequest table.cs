using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class addedleaveRequesttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ebb8e1-0747-407cS-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "9af6ec4a-f421-4206-abf7-9c65a732075f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21edd8e1-0747-407b-2150-017a5457c337",
                column: "ConcurrencyStamp",
                value: "6f222dd2-2a9e-44f4-96f2-5dc9fe446565");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afaec13d-c08a-4895-b4ca-39befcd09e93", "AQAAAAEAACcQAAAAEG3y8WV2gnlCNSADyCMKK1wKUKa/nafDTdeUHE4xaUUrhJmAQMADLwB+RGlEp9prxg==", "a79bec06-7ebb-4cce-ad4e-7d65f16dcf37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4938438d-1e19-4e1d-ac42-3e0b6022714f", "AQAAAAEAACcQAAAAEDnf9t62UMVZFx3ZuApMyENJP4Gynvu/RSSQRGCj/1hBOnoZie2MArKxXUZvTvxkmA==", "5fc5161d-ff35-484f-aaed-1e9eff0d852b" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
