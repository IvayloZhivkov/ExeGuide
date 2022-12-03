using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExeGuide.DataBase.Data.Entities
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;


        [Required]
        [ForeignKey(nameof(MainCategory))]
        public int MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; } = null!;



        [Required]
        [ForeignKey(nameof(SubCategory))]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = null!;


        [Required]
        [ForeignKey(nameof(Equipment))]
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; } = null!;


        public ICollection<TrainingUsersExercise> TrainingUsersExercises { get; set; } = new List<TrainingUsersExercise>();
    }
}
