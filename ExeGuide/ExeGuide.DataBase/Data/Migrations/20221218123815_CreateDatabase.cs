using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5febaf33-d1f8-4197-9e91-a84c0cafe2d9", "AQAAAAEAACcQAAAAEJ2LXuEYcSXOg0kq3cHr4B/jMnfGZh/0zDzdp7X+V7S4Ddic3AffXg/P29Ud+4DVXw==", "2ad41b29-3c79-4817-b5be-c0c758c771a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8dd36d4-39ae-4fd8-982b-710256387db9", "AQAAAAEAACcQAAAAEI9HoZPap8ckjEjh7cvdhAGSlg3kbEty9FO5PqtfSNaa+zQKT4prvoTgbb3DyYqkdw==", "186ff28d-7230-4325-b49c-02d113816373" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c272db81-418e-40b8-97a4-488c21647c13", "AQAAAAEAACcQAAAAEEbEZpzhzdgQDs/X4J8UGmGmlJ1NZU20IDVfcvBVj1vjElDAnHKhfrjbIET/ASoesw==", "cf47f58f-485a-4228-9126-f07f46002291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "108a94d2-945c-4be2-abc6-9642a05fb2a7", "AQAAAAEAACcQAAAAEAOKGO6vnFv4inceU5RTGhWK3F2Ti8p0wOGIDkBu3mNgO2p8HU7TdvQzXtOMLmWkHg==", "04f5b8b7-5f1e-407c-bfab-893aa36a6a26" });
        }
    }
}
