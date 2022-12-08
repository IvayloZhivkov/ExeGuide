using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class DBSETArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_ArticleCategory_CategoryId",
                table: "Article");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_CategoryId",
                table: "Articles",
                newName: "IX_Articles_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategory_CategoryId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategoryId",
                table: "Article",
                newName: "IX_Article_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57dab696-d3cf-46bc-81ad-7b39f2c68002", "AQAAAAEAACcQAAAAEJMfa8emLxxev0siaIWOqd+beAX2MUY+btTAT6iiC3+QCF3Aq1tFeP/tONDQxA/baw==", "87df63e2-0b9e-4cc6-9548-7feedeb3efea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a5af1bd-7a19-401a-8c98-325bcbcc336c", "AQAAAAEAACcQAAAAEDTwFzg2O7+dy2FBidknK/qPuiIzDmlN5txC+i3W8esTHO9q0Yw8uw/9q+O7T8yy2w==", "f04c7f03-6c09-406d-adaa-106d5ef55440" });

            migrationBuilder.AddForeignKey(
                name: "FK_Article_ArticleCategory_CategoryId",
                table: "Article",
                column: "CategoryId",
                principalTable: "ArticleCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
