using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ExeGuide.DataBase.Data.Entities;

namespace ExeGuide.DataBase.Data.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasData(Categories());
        }
        private List<Equipment> Categories()
        {
            List<Equipment> categories = new List<Equipment>()
            {
               new Equipment() { Id = 1, Name = "Machine" },
               new Equipment() { Id = 2, Name = "Dumbbells" },
               new Equipment() { Id = 3, Name = "Barbell" },
               new Equipment() { Id = 4, Name = "Kettlebell"},
               new Equipment() { Id = 5, Name = "Cables"},
               new Equipment() { Id = 6, Name = "Band"},
               new Equipment() { Id = 7, Name = "Bodyweight"}
            };
            return categories;
        }
    }
}
