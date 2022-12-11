using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class DbInitializingTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleText", "CategoryId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Noel Deyzel also known as Daddy Noel was born in South Africa on the 30th of September 1984. The record revealed he was born in an abusive home, and his mother’s name is Mariola Colleen; there are no details about who his father is apart from the report that he was sent to jail. Noel Deyzel has a sister who is two years older than him, but there are no details of who she is; he is a South African by birth and celebrated his 37th birthday in September 2021. Education Noel Deyzel had a tough time going to school; after his high school education, he proceeded to the University of South Africa (UNISA), where he bagged a degree in a business course.", 2, "https://1.bp.blogspot.com/-DiPHDuY0xco/Xcrthk45PJI/AAAAAAAAkxs/ra_XJY3SipgALznBeH7z23-H_7y4aSDtQCLcBGAsYHQ/s1600/37818048_2273166799633959_6480624407168417792_nok.jpg", "Daddy Noel" },
                    { 2, "Chris Bumstead is from Ottawa, Canada. As a kid, he looked up to the legendary Tom Platz because of his iconic leg development. He also cited Barry Demay (80s bodybuilder) as one his inspirations, and, of course, the great Arnold Schwarzenegger. Bumstead built the base of his physique training for sports that he was involved with in high school such as football, basketball and ran track and field. He was introduced to bodybuilding through his sister’s boyfriend (now husband) Iain Valliere, who is also an IFBB Professional bodybuilder. Valliere saw potential in Bumstead and helped him to prepare for his competition in 2014, when he was just 19 years old. He has acknowledged Valliere as being someone he’s inspired by and who he still looks up to. Bumstead really found his home in the Classic Physique division and it seems he wouldn’t want to be anywhere else. Bumstead first competed in 2014 at age 19, and then at just 21 years old, earned his Pro Card after winning the 2016 IFBB North American Bodybuilding Championships. Bumstead is the current Classic Physique Olympia champion, a title he won in 2019, 2020 and 2021. He was the runner-up at the same competition in 2017 and 2018 to Breon Ansley which was definitely frustrating for him. However, he brought an amazing package in 2019, which earned him the first place trophy at the biggest competition in the world. His 2019 Olympia win was impressive considering he had hernia surgery months out from the show. His victory also resulted in drama as Ansley’s coach Chris Cormier (former IFBB Pro) wasn’t happy with the result of the show. But he and Ansley also had their fair share of back and it continued all the way up to the 2020 Olympia Press Conference where they continued to fire shots at each other. But Bumstead prevailed once again in 2021 to win the Olympia title, tying him and Ansley with two apiece, and this time, he did it more convincingly. Meanwhile, Ansley came in third place and it’s possible that this could be the end of an active rivalry but we’ll have to wait and see. As of right now, there’s no telling what the future of the Classic Physique division will look like, but Bumstead is likely not looking to give up his crown anytime soon.", 2, "https://wallpapercave.com/wp/wp4656532.jpg", "CBUM" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c272db81-418e-40b8-97a4-488c21647c13", "AQAAAAEAACcQAAAAEEbEZpzhzdgQDs/X4J8UGmGmlJ1NZU20IDVfcvBVj1vjElDAnHKhfrjbIET/ASoesw==", "cf47f58f-485a-4228-9126-f07f46002291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "108a94d2-945c-4be2-abc6-9642a05fb2a7", "AQAAAAEAACcQAAAAEAOKGO6vnFv4inceU5RTGhWK3F2Ti8p0wOGIDkBu3mNgO2p8HU7TdvQzXtOMLmWkHg==", "04f5b8b7-5f1e-407c-bfab-893aa36a6a26" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ebcaf7-5caf-4e20-8adf-418e3ee1be96", "AQAAAAEAACcQAAAAEHU4vynprXn7KRt4JDlHQkzs6+v0aWbsBxhoPZyGg0x6z/3b5gWAH0duIwzW7pKkfw==", "1960afce-8671-4d48-92c0-8e43c528af09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4885526-b62d-4ba4-9b84-1ae80535863a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feea5e4f-0b46-414c-9338-1f9e1b7db13c", "AQAAAAEAACcQAAAAED7mPOTOUMwCJZYF3sYJrG563a8QyLtCZWTePwls/7zau07nzIqiTO1L6UWgGckduA==", "917425cb-45f6-471e-9ea9-0ab81857840e" });
        }
    }
}
