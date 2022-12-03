using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    public partial class InsertingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "29f5928c-5d5b-4c63-95e6-4a9bc520bfc5", "editor@traininghelper.com", false, "Great", "Editor", false, null, "editor@traininghelper.com", "editor@traininghelper.com", "AQAAAAEAACcQAAAAEK5ig+Q/4EGIyeFzJCrFJz+GckTRh4KQiBTakn43sBRWBUcYScPXaMQ47EfVOZG5/Q==", null, false, null, false, "editor@traininghelper.com" });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Machine" },
                    { 2, "Dumbbells" },
                    { 3, "Barbell" },
                    { 4, "Kettlebell" },
                    { 5, "Cables" },
                    { 6, "Band" },
                    { 7, "Bodyweight" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "MainCategoryName" },
                values: new object[,]
                {
                    { 1, "Chest" },
                    { 2, "Shoulders" },
                    { 3, "Arms" },
                    { 4, "Abdominal" },
                    { 5, "Back" },
                    { 6, "Legs" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, "Upper Chest" },
                    { 2, "Middle Chest" },
                    { 3, "Lower Chest" },
                    { 4, "Front Deltoid (Shoulder)" },
                    { 5, "Middle Deltoid (Shoulder)" },
                    { 6, "Rear  Deltoid (Shoulder)" },
                    { 7, "Long Head (Biceps)" },
                    { 8, "Short Head" },
                    { 9, "Brachialis" },
                    { 10, "Long Head (Triceps)" },
                    { 11, "Medial Head" },
                    { 12, "Lateral Head" },
                    { 13, "Medial Head" },
                    { 14, "Upper Abdominal" },
                    { 15, "Lower Abdominal" },
                    { 16, "Obliques" },
                    { 17, "Traps" },
                    { 18, "Infraspinatus" },
                    { 19, "Lats" },
                    { 20, "Lower Back" },
                    { 21, "Glutes" },
                    { 22, "Vastus Lateralis (Outer Quad)" },
                    { 23, "Rectus Femoris (Middle Quad)" },
                    { 24, "Vastus Medialis (Inner Quad)" },
                    { 25, "Semitendinosus (Inner Hamstring)" },
                    { 26, "Biceps Femoris (Middle Hamstring)" },
                    { 27, "Semimembranosus (Outer Hamstring)" },
                    { 28, "Soleus (Upper Calf)" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "SubCategoryName" },
                values: new object[,]
                {
                    { 29, "Gastrocnemius (Lower Calf)" },
                    { 30, "Brachiordinalis (Forearm)" },
                    { 31, "Flexors (Forearm)" },
                    { 32, "Extensors (Forearm)" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "EquipmentId", "ImageUrl", "MainCategoryId", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "Grasp the handles with a full grip, your thumb circled around the handle. Maintain a neutral wrist position with your wrists in line with your forearms. Exhale and push outward until your arms are fully extended (don't lock the elbows). Keep your head steady against the back support during this movement and your neck still. You should feel resistance against the horizontal push. Pause briefly at full extension. Bend your elbows and return to the starting position, breathing in during this recovery.", 1, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.k8Rg6S8G76qWwlN3b5AtDAHaD7%26pid%3DApi&f=1&ipt=4035c303d0f607c9b4a2ea90074597fdf9e7ceff0e3d2979217ac4a47f9bb275&ipo=images", 1, "Chest Press (Machine)", 2 },
                    { 2, "Adjust the machine seat to a comfortable height. Set the handles, so they are roughly at shoulder height. Sit upright in the chair. Ensure that you are erect but comfortable with your back against the back pad. Keep your feet flat on the floor and shoulder-width apart. Your knees should be bent at a 90-degree angle. Grab and hold the handles with a solid pronated or neutral grip. Your elbows should be bent and pointing towards the floor. Inhale and press the handle overhead straight to the ceiling. Hold this position at the top without locking out your elbows. Exhale and slowly bring your arms down without letting it go to the starting position. This is one rep. Complete as many repetitions as you can fit in a set.", 1, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.0e2UWyilV3gMvK-i13y3DAAAAA%26pid%3DApi&f=1&ipt=607becc9e2f63842d62296fe5ddf0e51b9841ae33b8126af904581b8995b60d8&ipo=images", 2, "Shoulder Press (Machine)", 4 },
                    { 3, "Load some weight onto a barbell. For more convenience, use a fixed bar. Grab the bar with a narrow underhand grip so that your elbows are in front of your body rather than by your sides. Curl the weight toward your chest by moving your forearms toward your biceps. Keep lifting until the undersides of your forearms press right up against your biceps. Hold the contraction for a moment and then lower the bar under control until your elbows are extended.", 3, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.jsjvVwiOzjntzwG0SzY-2AHaEN%26pid%3DApi&f=1&ipt=a5d54b43b5b0ef0915eca5fff586af37cd0c6cd0ae2f54a715dcc7a0bb20a3d9&ipo=images", 3, "Biceps Curl Narrow Grip (Barbell)", 7 },
                    { 4, "Make sure that the seat’s height is correctly adjusted to your body so that your shoulders rest back comfortably on the padding. Select the weight load that you want to use and insert the pin into the corresponding hole. (If you haven’t used this type of machine before, we recommend starting at a low weight so that you can test your comfort zone a bit.) Flex your core, push against the padded lever, and bend forward at the waist. Your hips should stay in the seat at all times. Try to move in a slow, controlled manner. You won’t gain anything from violently trying to yank up a heavier weight using improper form. Breathe in as you come back to the starting position and finish the movement. The repetition is complete when your body returns to an upright position. From there, repeat as many reps as your training plan allows.", 1, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.WWl864s7p73ahJeqJ4HpqwHaEO%26pid%3DApi&f=1&ipt=485310cf72e25630942cbf1878f9b107e6bd6df615ebab717a56d6f44bcda200&ipo=images", 4, "Abdominal Crunch (Machine)", 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
