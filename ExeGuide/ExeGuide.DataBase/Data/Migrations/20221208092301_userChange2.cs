using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class userChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4e56f03-0ed5-4b78-9f50-f56f2970d023", "AQAAAAEAACcQAAAAEAtxFUMANanZj840J8lkOn1FULsfk2L0FWe7TRS3FCW6Pn2ObP7Sn/OQiNcBwXOdbQ==", "3321a870-cd90-47be-8cad-f2d7b6a48d34" });

            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35b526d7-e6a2-46d8-8f01-1d11545778f7", "AQAAAAEAACcQAAAAEIAHmZg9y09kHGgSOFFoHxgZfJviwGc0rx0oyhnG2gumhNg+isrmpkmJgaWnG71Hkg==", "fb9ef1bc-6fb1-4f25-aeba-15dfb1aa2fed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53932e6f-825b-4538-a227-3e6e5c88fc97", "AQAAAAEAACcQAAAAEH9DmeUiFsvKiqqScwwKqKI8+iey/d2J7PWCQYXY85OeZA/sk28FP+eNntHVB30kPQ==", "87cd7717-deec-4e6c-8db1-594bf58b9526" });

            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15b2e2d9-84ce-49ae-ad83-75cb47d90e6a", "AQAAAAEAACcQAAAAEME00JwEG88dB2EoaM1t++ypg27D5NiuXv9SqE1FiRNhGlth2e58JQpp3e83ycsc3w==", "3c243b4f-b474-405d-b98b-c812aa115314" });
        }
    }
}
