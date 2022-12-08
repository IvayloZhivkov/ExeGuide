using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class insertingWriter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d7874c-c7b7-428d-8b05-78e9e6f3d71a", "AQAAAAEAACcQAAAAEKivv3J37M+09Y7A6Eci3bNwee3tXcIOyUxEg7TuvG+9pPEwoA0r/+9y2zWOlmlQIQ==", "51aad342-4128-4068-b759-b4ef11ee2f16" });

            migrationBuilder.InsertData(
                table: "TrainingUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "c9e1d89f-ff2c-4dd6-81c6-18378cdd473a", "writer@exeguide.com", false, "Great", "Writer", false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEGwxuJ/L6q6m48LlPhEINjPkgUOd5qkJDmbdDvUQfATfrO+vbIdRAdlCQFUhfqlhgQ==", null, false, "b7591b80-0381-486d-b571-b95ae84fdf75", false, "writer@exeguide.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a");

            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1617f982-f8cc-4b00-aa77-60ddced257cc", "AQAAAAEAACcQAAAAEANT7cQcTW1OUnItFyGJ7Cj/8/W1TFHxevawHC+b8jBdHhac5QKHIn8/VRDdWGv6dQ==", "ae613fe7-387a-466b-ba4a-1ea811f003f7" });
        }
    }
}
