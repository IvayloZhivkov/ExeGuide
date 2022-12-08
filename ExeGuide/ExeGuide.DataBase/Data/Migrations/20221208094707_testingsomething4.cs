using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class testingsomething4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "254d77c7-c9aa-4a3c-904b-ca4bbc74597b", "editor@traininghelper.com", false, false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEMlto8HKwMfYG33iCV6NOoQxL08Qk8ASSBvgh0JEevl2+feki/f8zztO7SPMWKkXwA==", null, false, "71382be4-30c9-4217-a9ee-e6e695514d72", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "c0db3a05-2ae1-47ea-96fc-854a6cdca728", "writer@exeguide.com", false, false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEG8A5Eqk/82g8Xt6tPsCzoqgaA/IsPtvbwBPyhzWWcZKAwnd0OkRUdMu4r3hN9P5qg==", null, false, "a15dc462-9fee-42f0-bdc2-7679af92ea95", false, "writer@exeguide.com" });
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
                table: "TrainingUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "785e2cf2-a3b4-452c-890a-ca43d8b870f3", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEN+StrvOq/N8qsALlt6ZZCxgiRRc9jULpX6K1LShqMVWiN0m2W3XXKpqtIh/6B77eA==", null, false, "238bb88d-a34b-433b-9ebd-63052e5505fb", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "TrainingUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "5624d137-f3a1-408d-95c1-e5cef2ca9465", "writer@exeguide.com", false, "Great", "Writer", false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEB3kc/ELnwA67Py2PF7h7+TiRzdVKxVFwAAVlsnc+lD48Rnl5QlzQ4MBKe10LbsS4g==", null, false, "d267c81e-fe26-4c71-9e0d-901cee956b4d", false, "writer@exeguide.com" });
        }
    }
}
