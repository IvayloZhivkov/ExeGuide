using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class Editor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a56347e-2a6a-4585-9272-cf85dfe03069", "AQAAAAEAACcQAAAAEE1LuqNTpUz1neY81FWJU72OSdzN3rzdRBBwGs3twJ+1HmwnKNK/stdLa3T49Xtgpg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29f5928c-5d5b-4c63-95e6-4a9bc520bfc5", "AQAAAAEAACcQAAAAEK5ig+Q/4EGIyeFzJCrFJz+GckTRh4KQiBTakn43sBRWBUcYScPXaMQ47EfVOZG5/Q==" });
        }
    }
}
