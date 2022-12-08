using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class DBSETArticleCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategory_CategoryId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleCategory",
                table: "ArticleCategory");

            migrationBuilder.RenameTable(
                name: "ArticleCategory",
                newName: "ArticleCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleCategories",
                table: "ArticleCategories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f686f65d-2310-4d74-9600-b80f9d8d34d6", "AQAAAAEAACcQAAAAEM7aLVTHAvPKIWJCRZtNr3FrLRjdADsH3VOYTwTTIffGZJWLVVRl05f4evw70u/dEg==", "24f484cc-185b-43a0-8d74-996dc7a507c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b52cf60-194b-4101-a167-28b429997282", "AQAAAAEAACcQAAAAEEmcyH7yRocRGm3xXKAkiQwjg97/GHvy8mcf/ur9oBv1nvKc9koqPJDAGRA2YitXHA==", "2332399f-745a-45a2-b599-9b970a46a534" });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleCategories",
                table: "ArticleCategories");

            migrationBuilder.RenameTable(
                name: "ArticleCategories",
                newName: "ArticleCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleCategory",
                table: "ArticleCategory",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21434ecb-2c15-4423-bfef-90974268750a", "AQAAAAEAACcQAAAAEN6KhFT3VR5Rym3AFgFh40i2+ylQQF/3RhjwdUDkTfykYyKYqHK3M93OPitRJkeEyw==", "af276ceb-a84d-4c29-9b8d-f2a0a3b27434" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f37c208e-897b-4657-bb80-58638706133f", "AQAAAAEAACcQAAAAEOKreUmb7M71ETV6AraBxe51lVmqTX8crPk3FzSrkI+KSL/462woPfyj6WOvzfH0gw==", "6a82c602-56aa-4f06-bfd7-c488572878e5" });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategory_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "ArticleCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
