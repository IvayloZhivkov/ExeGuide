using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ExeGuide.Data.Entities;

namespace ExeGuide.Data.Configurations
{
    public class ExercisesConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(Categories());
        }
        private List<Exercise> Categories()
        {
            List<Exercise> categories = new List<Exercise>()
            {
               new Exercise()
               {
                   Id = 1,
                   Name = "Chest Press (Machine)",
                   Description = "Grasp the handles with a full grip, your thumb circled around the handle. Maintain a neutral wrist position with your wrists in line with your forearms. Exhale and push outward until your arms are fully extended (don't lock the elbows). Keep your head steady against the back support during this movement and your neck still. You should feel resistance against the horizontal push. Pause briefly at full extension. Bend your elbows and return to the starting position, breathing in during this recovery.",
                   ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.k8Rg6S8G76qWwlN3b5AtDAHaD7%26pid%3DApi&f=1&ipt=4035c303d0f607c9b4a2ea90074597fdf9e7ceff0e3d2979217ac4a47f9bb275&ipo=images",
                   MainCategoryId = 1,
                   SubCategoryId = 2,
                   EquipmentId = 1
               },
               new Exercise()
               {
                   Id = 2,
                   Name = "Shoulder Press (Machine)",
                   Description = "Adjust the machine seat to a comfortable height. Set the handles, so they are roughly at shoulder height. Sit upright in the chair. Ensure that you are erect but comfortable with your back against the back pad. Keep your feet flat on the floor and shoulder-width apart. Your knees should be bent at a 90-degree angle. Grab and hold the handles with a solid pronated or neutral grip. Your elbows should be bent and pointing towards the floor. Inhale and press the handle overhead straight to the ceiling. Hold this position at the top without locking out your elbows. Exhale and slowly bring your arms down without letting it go to the starting position. This is one rep. Complete as many repetitions as you can fit in a set.",
                   ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.0e2UWyilV3gMvK-i13y3DAAAAA%26pid%3DApi&f=1&ipt=607becc9e2f63842d62296fe5ddf0e51b9841ae33b8126af904581b8995b60d8&ipo=images",
                   MainCategoryId = 2,
                   SubCategoryId = 4,
                   EquipmentId = 1
               },
               new Exercise()
               {
                   Id = 3,
                   Name = "Biceps Curl Narrow Grip (Barbell)",
                   Description = "Load some weight onto a barbell. For more convenience, use a fixed bar. Grab the bar with a narrow underhand grip so that your elbows are in front of your body rather than by your sides. Curl the weight toward your chest by moving your forearms toward your biceps. Keep lifting until the undersides of your forearms press right up against your biceps. Hold the contraction for a moment and then lower the bar under control until your elbows are extended.",
                   ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.jsjvVwiOzjntzwG0SzY-2AHaEN%26pid%3DApi&f=1&ipt=a5d54b43b5b0ef0915eca5fff586af37cd0c6cd0ae2f54a715dcc7a0bb20a3d9&ipo=images",
                   MainCategoryId= 3,
                   SubCategoryId = 7,
                   EquipmentId = 3
               },
               new Exercise()
               {
                   Id = 4,
                   Name = "Abdominal Crunch (Machine)",
                   Description = "Make sure that the seat’s height is correctly adjusted to your body so that your shoulders rest back comfortably on the padding. Select the weight load that you want to use and insert the pin into the corresponding hole. (If you haven’t used this type of machine before, we recommend starting at a low weight so that you can test your comfort zone a bit.) Flex your core, push against the padded lever, and bend forward at the waist. Your hips should stay in the seat at all times. Try to move in a slow, controlled manner. You won’t gain anything from violently trying to yank up a heavier weight using improper form. Breathe in as you come back to the starting position and finish the movement. The repetition is complete when your body returns to an upright position. From there, repeat as many reps as your training plan allows.",
                   ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.WWl864s7p73ahJeqJ4HpqwHaEO%26pid%3DApi&f=1&ipt=485310cf72e25630942cbf1878f9b107e6bd6df615ebab717a56d6f44bcda200&ipo=images",
                   MainCategoryId = 4,
                   SubCategoryId =  14,
                   EquipmentId = 1
               }

            };
            return categories;
        }
    }
}
