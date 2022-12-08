using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class changingTheUserParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c841e12-3c62-4a76-a2f8-c4c72e4d7650", null, null, "AQAAAAEAACcQAAAAEJsERcm7oYIzxVUHLolF76icHofopemza9sVUJKqVTVo2RChd0wItuWhFPKbVidiUw==", "ca7efd34-dc9a-4750-950d-1fa47f280875" });

            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b577c7a3-7a07-42b1-8cda-3e209f1d24bb", null, null, "AQAAAAEAACcQAAAAEFc032f6Z050c193/3GcIE1A6W+MjcVSXv/IY0Uzmm4rMr0sPfkln//RXWFGr1DI1w==", "3596b84d-62da-4f34-9ff3-0fdfdf016268" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d7874c-c7b7-428d-8b05-78e9e6f3d71a", "Great", "Editor", "AQAAAAEAACcQAAAAEKivv3J37M+09Y7A6Eci3bNwee3tXcIOyUxEg7TuvG+9pPEwoA0r/+9y2zWOlmlQIQ==", "51aad342-4128-4068-b759-b4ef11ee2f16" });

            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9e1d89f-ff2c-4dd6-81c6-18378cdd473a", "Great", "Writer", "AQAAAAEAACcQAAAAEGwxuJ/L6q6m48LlPhEINjPkgUOd5qkJDmbdDvUQfATfrO+vbIdRAdlCQFUhfqlhgQ==", "b7591b80-0381-486d-b571-b95ae84fdf75" });
        }
    }
}
