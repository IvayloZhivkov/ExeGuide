using System.ComponentModel.DataAnnotations;

namespace ExeGuide.DataBase.Data.Entities
{
    public class MainCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MainCategoryName { get; set; } = null!;

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
