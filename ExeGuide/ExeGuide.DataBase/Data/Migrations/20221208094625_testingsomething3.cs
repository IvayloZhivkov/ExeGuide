using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class testingsomething3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingUsersExercises_AspNetUsers_UserId",
                table: "TrainingUsersExercises");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "TrainingUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TrainingUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "785e2cf2-a3b4-452c-890a-ca43d8b870f3", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEN+StrvOq/N8qsALlt6ZZCxgiRRc9jULpX6K1LShqMVWiN0m2W3XXKpqtIh/6B77eA==", null, false, "238bb88d-a34b-433b-9ebd-63052e5505fb", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "TrainingUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "5624d137-f3a1-408d-95c1-e5cef2ca9465", "writer@exeguide.com", false, "Great", "Writer", false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEB3kc/ELnwA67Py2PF7h7+TiRzdVKxVFwAAVlsnc+lD48Rnl5QlzQ4MBKe10LbsS4g==", null, false, "d267c81e-fe26-4c71-9e0d-901cee956b4d", false, "writer@exeguide.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingUsersExercises_TrainingUser_UserId",
                table: "TrainingUsersExercises",
                column: "UserId",
                principalTable: "TrainingUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingUsersExercises_TrainingUser_UserId",
                table: "TrainingUsersExercises");

            migrationBuilder.DropTable(
                name: "TrainingUser");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "217fe24d-bf29-4645-ae2a-a41e60be8493", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEMGATryY6wdgePXDLwrGcsXe05FZ7Q9o1v4vbSOXmqYHcHtZXQiuaM1tDqHV9aMHCQ==", null, false, "5d5c6985-baec-4b0d-a5fa-b3441411dc70", false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4885526-b62d-4ba4-9b84-1ae80535863a", 0, "60e52c06-7820-49de-8be4-8f002f3bdbe7", "writer@exeguide.com", false, "Great", "Writer", false, null, "writer@exeguide.com", "writer@exeguide.com", "AQAAAAEAACcQAAAAEJb7vRvBQ6B7jWsDKyHsfQYiUfQ5YjbXm6UrrNJvLhyZiqJqw06zr5puGc/y/49B9Q==", null, false, "14df0f1a-55eb-40a1-a327-6ba606683229", false, "writer@exeguide.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingUsersExercises_AspNetUsers_UserId",
                table: "TrainingUsersExercises",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
