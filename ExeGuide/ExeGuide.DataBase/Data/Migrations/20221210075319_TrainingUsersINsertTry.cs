using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class TrainingUsersINsertTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingUsersExercises_TrainingUser_UserId",
                table: "TrainingUsersExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingUser",
                table: "TrainingUser");

            migrationBuilder.RenameTable(
                name: "TrainingUser",
                newName: "TrainingUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingUsers",
                table: "TrainingUsers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a54794e-98f2-4567-a1cd-5f6cf6b7b58d", "AQAAAAEAACcQAAAAEA0qRGz8YPWBIaYRyFdc7WyRqmD+JPyP0RriLjLuJJ+FLI1gZipdcAJIPhmylob1gw==", "28ec92f0-566a-48fb-90c1-333b04dc0ba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c046f5-9c7a-4b04-a64b-a2ef1ff2c4ed", "AQAAAAEAACcQAAAAEM4J9uP6QbuPCBT21gJg4owzvDcbx+KT8AUB/Q9HKhwZGOfgr4yDfZgDzu+s+nxJng==", "68940ef4-7917-496f-93c1-e56cca4895b9" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingUsersExercises_TrainingUsers_UserId",
                table: "TrainingUsersExercises",
                column: "UserId",
                principalTable: "TrainingUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingUsersExercises_TrainingUsers_UserId",
                table: "TrainingUsersExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingUsers",
                table: "TrainingUsers");

            migrationBuilder.RenameTable(
                name: "TrainingUsers",
                newName: "TrainingUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingUser",
                table: "TrainingUser",
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
                name: "FK_TrainingUsersExercises_TrainingUser_UserId",
                table: "TrainingUsersExercises",
                column: "UserId",
                principalTable: "TrainingUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
