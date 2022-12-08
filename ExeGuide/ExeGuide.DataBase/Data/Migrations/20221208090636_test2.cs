using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1617f982-f8cc-4b00-aa77-60ddced257cc", "AQAAAAEAACcQAAAAEANT7cQcTW1OUnItFyGJ7Cj/8/W1TFHxevawHC+b8jBdHhac5QKHIn8/VRDdWGv6dQ==", "ae613fe7-387a-466b-ba4a-1ea811f003f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3791baf-0c93-4eba-8730-cf70e007a5c0", "AQAAAAEAACcQAAAAEC2oWtC1ebX3cST1lY9GYJ7pPf4wx9FyU1ybLPT6CX33cwPcJkIMHPmXteJHGZ8Mlw==", "4c04a7a4-e0f7-44ea-a50a-19a8386c50b0" });
        }
    }
}
