using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3791baf-0c93-4eba-8730-cf70e007a5c0", "AQAAAAEAACcQAAAAEC2oWtC1ebX3cST1lY9GYJ7pPf4wx9FyU1ybLPT6CX33cwPcJkIMHPmXteJHGZ8Mlw==", "4c04a7a4-e0f7-44ea-a50a-19a8386c50b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainingUser",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b578b2e-a5ee-4cce-903a-9ba919fe2bb6", "AQAAAAEAACcQAAAAEOqkiyxizA8J61PYh7KoxczNnRxYaw1S5aAWmDvznSKp/VxcC83nN5vPwdDeHXfwuw==", "1c4b6c75-4140-4a21-ab39-e9b66eff25d3" });
        }
    }
}
