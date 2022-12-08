using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class userChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c841e12-3c62-4a76-a2f8-c4c72e4d7650", "AQAAAAEAACcQAAAAEJsERcm7oYIzxVUHLolF76icHofopemza9sVUJKqVTVo2RChd0wItuWhFPKbVidiUw==", "ca7efd34-dc9a-4750-950d-1fa47f280875" });

            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b577c7a3-7a07-42b1-8cda-3e209f1d24bb", "AQAAAAEAACcQAAAAEFc032f6Z050c193/3GcIE1A6W+MjcVSXv/IY0Uzmm4rMr0sPfkln//RXWFGr1DI1w==", "3596b84d-62da-4f34-9ff3-0fdfdf016268" });
        }
    }
}
