using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ExeGuide.DataBase.Data.Entities;

namespace ExeGuide.DataBase.Data.Configurations
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(Categories());
        }
        private List<SubCategory> Categories()
        {
            List<SubCategory> categories = new List<SubCategory>()
            {
               new SubCategory() { Id = 1, SubCategoryName = "Upper Chest" },
               new SubCategory() { Id = 2, SubCategoryName = "Middle Chest" },
               new SubCategory() { Id = 3, SubCategoryName = "Lower Chest" },
               new SubCategory() { Id = 4, SubCategoryName = "Front Deltoid (Shoulder)"},
               new SubCategory() { Id = 5, SubCategoryName = "Middle Deltoid (Shoulder)"},
               new SubCategory() { Id = 6, SubCategoryName = "Rear  Deltoid (Shoulder)"},
               new SubCategory() { Id = 7, SubCategoryName = "Long Head (Biceps)"},
               new SubCategory() { Id = 8, SubCategoryName = "Short Head"},  
               new SubCategory() { Id = 9, SubCategoryName = "Brachialis"},
               new SubCategory() { Id = 10, SubCategoryName = "Long Head (Triceps)"},
               new SubCategory() { Id = 11, SubCategoryName = "Medial Head"},
               new SubCategory() { Id = 12, SubCategoryName = "Lateral Head"},
               new SubCategory() { Id = 13, SubCategoryName = "Medial Head"},
               new SubCategory() { Id = 14, SubCategoryName = "Upper Abdominal"},
               new SubCategory() { Id = 15, SubCategoryName = "Lower Abdominal"},
               new SubCategory() { Id = 16, SubCategoryName = "Obliques"},
               new SubCategory() { Id = 17, SubCategoryName = "Traps"},
               new SubCategory() { Id = 18, SubCategoryName = "Infraspinatus"},
               new SubCategory() { Id = 19, SubCategoryName = "Lats"},
               new SubCategory() { Id = 20, SubCategoryName = "Lower Back"},
               new SubCategory() { Id = 21, SubCategoryName = "Glutes"},
               new SubCategory() { Id = 22, SubCategoryName = "Vastus Lateralis (Outer Quad)"},
               new SubCategory() { Id = 23, SubCategoryName = "Rectus Femoris (Middle Quad)"},
               new SubCategory() { Id = 24, SubCategoryName = "Vastus Medialis (Inner Quad)"},
               new SubCategory() { Id = 25, SubCategoryName = "Semitendinosus (Inner Hamstring)"},
               new SubCategory() { Id = 26, SubCategoryName = "Biceps Femoris (Middle Hamstring)"},
               new SubCategory() { Id = 27, SubCategoryName = "Semimembranosus (Outer Hamstring)"},
               new SubCategory() { Id = 28, SubCategoryName = "Soleus (Upper Calf)"},
               new SubCategory() { Id = 29, SubCategoryName = "Gastrocnemius (Lower Calf)"},
               new SubCategory() { Id = 30, SubCategoryName = "Brachiordinalis (Forearm)"},
               new SubCategory() { Id = 31, SubCategoryName = "Flexors (Forearm)"},
               new SubCategory() { Id = 32, SubCategoryName = "Extensors (Forearm)"},
            };
            return categories;
        }
    }
}
