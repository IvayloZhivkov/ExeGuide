using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ExeGuide.DataBase.Data.Entities;

namespace ExeGuide.DataBase.Data.Configurations
{
    public class MainCategoryConfiguration : IEntityTypeConfiguration<MainCategory>
    {
        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            builder.HasData(Categories());
        }
        private List<MainCategory> Categories()
        {
            List<MainCategory> categories = new List<MainCategory>()
            {
               new MainCategory() { Id = 1, MainCategoryName = "Chest" },
               new MainCategory() { Id = 2, MainCategoryName = "Shoulders" },
               new MainCategory() { Id = 3, MainCategoryName = "Arms" },
               new MainCategory() { Id = 4, MainCategoryName = "Abdominal"},
               new MainCategory() { Id = 5, MainCategoryName = "Back"},
               new MainCategory() { Id = 6, MainCategoryName = "Legs"}
            };
            return categories;
        }
    }
}
