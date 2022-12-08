using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class ChangingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "254d77c7-c9aa-4a3c-904b-ca4bbc74597b", "AQAAAAEAACcQAAAAEMlto8HKwMfYG33iCV6NOoQxL08Qk8ASSBvgh0JEevl2+feki/f8zztO7SPMWKkXwA==", "71382be4-30c9-4217-a9ee-e6e695514d72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0db3a05-2ae1-47ea-96fc-854a6cdca728", "AQAAAAEAACcQAAAAEG8A5Eqk/82g8Xt6tPsCzoqgaA/IsPtvbwBPyhzWWcZKAwnd0OkRUdMu4r3hN9P5qg==", "a15dc462-9fee-42f0-bdc2-7679af92ea95" });
        }
    }
}
