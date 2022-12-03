using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class Editor7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce32d03e-3305-4230-bc82-3359764621d4", "AQAAAAEAACcQAAAAEOna8YEI7JKjmjIE53sMXbkzIyx43cSdg9VXTf8ZzYhHbPxPKukOaP1N6ulhbGDETw==", "46804bdc-f5f4-4bfe-aea3-61565b9456ea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edf289a7-4207-4510-bcfb-ddaf1a6bdab7", "AQAAAAEAACcQAAAAEMJbVX6WXtX3jmLHoIRmOGkYCm4hwnZr8Xn45oXdTRFRYhhCExt2l/j0E2K340r5lA==", null });
        }
    }
}
