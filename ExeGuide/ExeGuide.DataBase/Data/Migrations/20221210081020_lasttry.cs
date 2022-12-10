using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class lasttry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "TrainingUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "94ebcaf7-5caf-4e20-8adf-418e3ee1be96", "editor@traininghelper.com", false, false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEHU4vynprXn7KRt4JDlHQkzs6+v0aWbsBxhoPZyGg0x6z/3b5gWAH0duIwzW7pKkfw==", null, false, "1960afce-8671-4d48-92c0-8e43c528af09", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "feea5e4f-0b46-414c-9338-1f9e1b7db13c", "writer@exeguide.com", false, false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAED7mPOTOUMwCJZYF3sYJrG563a8QyLtCZWTePwls/7zau07nzIqiTO1L6UWgGckduA==", null, false, "917425cb-45f6-471e-9ea9-0ab81857840e", false, "writer@exeguide.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a");

            migrationBuilder.InsertData(
                table: "TrainingUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "3c6eba45-0760-4e03-893e-99aae0ac9eaa", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAELNsSN/qvjYc7X6PwM0Y//lr4rxxYpSYeJes3LeLE4TmZE1eqPCunEv2i36kRT5cYw==", null, false, "bdc96f85-e7e2-48bb-8e4b-bdb3f68dbaf9", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "TrainingUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "56d17759-31c3-406c-a7a2-c192f74b1e5d", "writer@exeguide.com", false, "Great", "Writer", false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEG9VDirvHj+1goi9VwymYC0ild25LBK4evv2cCW/os5FPbvdGzhBMvTReTHRZ6mPiw==", null, false, "c638694f-bb27-4812-a336-0043a4870258", false, "writer@exeguide.com" });
        }
    }
}
