using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class Editor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "3a56347e-2a6a-4585-9272-cf85dfe03069", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEE1LuqNTpUz1neY81FWJU72OSdzN3rzdRBBwGs3twJ+1HmwnKNK/stdLa3T49Xtgpg==", null, false, null, false, "editor@traininghelper.com" });
        }
    }
}
