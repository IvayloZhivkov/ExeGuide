using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class fixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "069dac49-ce53-47fe-b3c9-8962a29e8e6e", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEP4AB488/d6ZOgRP6mQZOAUGRUOmQvnk7a5dXxXDLE2z5MFNEuNf9NXMl7mPLqF41g==", null, false, "ae199eb3-0b81-4999-80f1-b876a7080766", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "TrainingUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "ffce8b4b-9050-4c95-9215-e613ba19c2c8", "writer@exeguide.com", false, "Great", "Writer", false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEMoLp+JFmRJIVbiEz48R8Ayo6QJCCpq8FgEgpj3IdamEyTJDsK9tuMnIE/u1Udm4Pg==", null, false, "86d2c1ce-17a0-4f38-9c2c-4b73ff75cb42", false, "writer@exeguide.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "1a54794e-98f2-4567-a1cd-5f6cf6b7b58d", "editor@traininghelper.com", false, false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEA0qRGz8YPWBIaYRyFdc7WyRqmD+JPyP0RriLjLuJJ+FLI1gZipdcAJIPhmylob1gw==", null, false, "28ec92f0-566a-48fb-90c1-333b04dc0ba0", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "78c046f5-9c7a-4b04-a64b-a2ef1ff2c4ed", "writer@exeguide.com", false, false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEM4J9uP6QbuPCBT21gJg4owzvDcbx+KT8AUB/Q9HKhwZGOfgr4yDfZgDzu+s+nxJng==", null, false, "68940ef4-7917-496f-93c1-e56cca4895b9", false, "writer@exeguide.com" });
        }
    }
}
