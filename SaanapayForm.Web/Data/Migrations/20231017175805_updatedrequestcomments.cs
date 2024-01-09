using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaanapayForm.Web.Data.Migrations
{
    public partial class updatedrequestcomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
