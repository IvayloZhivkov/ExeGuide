using System.ComponentModel.DataAnnotations;

namespace ExeGuide.Data.Entities
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SubCategoryName { get; set; } = null!;

        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
