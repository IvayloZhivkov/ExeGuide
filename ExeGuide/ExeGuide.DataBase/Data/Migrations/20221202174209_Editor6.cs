using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class Editor6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "edf289a7-4207-4510-bcfb-ddaf1a6bdab7", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEMJbVX6WXtX3jmLHoIRmOGkYCm4hwnZr8Xn45oXdTRFRYhhCExt2l/j0E2K340r5lA==", null, false, null, false, "editor@traininghelper.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");
        }
    }
}
