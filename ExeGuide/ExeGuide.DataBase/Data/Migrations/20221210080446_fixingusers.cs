using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class fixingusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c6eba45-0760-4e03-893e-99aae0ac9eaa", "AQAAAAEAACcQAAAAELNsSN/qvjYc7X6PwM0Y//lr4rxxYpSYeJes3LeLE4TmZE1eqPCunEv2i36kRT5cYw==", "bdc96f85-e7e2-48bb-8e4b-bdb3f68dbaf9" });

            migrationBuilder.UpdateData(
                table: "TrainingUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d17759-31c3-406c-a7a2-c192f74b1e5d", "AQAAAAEAACcQAAAAEG9VDirvHj+1goi9VwymYC0ild25LBK4evv2cCW/os5FPbvdGzhBMvTReTHRZ6mPiw==", "c638694f-bb27-4812-a336-0043a4870258" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069dac49-ce53-47fe-b3c9-8962a29e8e6e", "AQAAAAEAACcQAAAAEP4AB488/d6ZOgRP6mQZOAUGRUOmQvnk7a5dXxXDLE2z5MFNEuNf9NXMl7mPLqF41g==", "ae199eb3-0b81-4999-80f1-b876a7080766" });

            migrationBuilder.UpdateData(
                table: "TrainingUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffce8b4b-9050-4c95-9215-e613ba19c2c8", "AQAAAAEAACcQAAAAEMoLp+JFmRJIVbiEz48R8Ayo6QJCCpq8FgEgpj3IdamEyTJDsK9tuMnIE/u1Udm4Pg==", "86d2c1ce-17a0-4f38-9c2c-4b73ff75cb42" });
        }
    }
}
