using System.ComponentModel.DataAnnotations;
using ExeGuide.Core.Services.Models;

namespace ExeGuide.Areas.Editor.Models
{ /// <summary>
/// This is helps us to use the information from the exercises so we can show them in a view or a partial view
/// </summary>
    public class ExerciseFormModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; init; }

        [Required]
        [MaxLength(1000)]
        [MinLength(50)]
        public string Description { get; init; }

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; }

        
        [Display(Name ="Main Category")]
        public int MainCategoryId { get; set;}
        [Display(Name = "Sub Category")]
        public int SubCategoryId { get; set; }

        [Display(Name = "Equipment")]
        public int EquipmentId { get; set; }

        public IEnumerable<ExerciseMainCategoryModel> MainCategories { get; set; } = new List<ExerciseMainCategoryModel>();

        public IEnumerable<ExerciseSubCategoryModel> SubCategories { get; set; } = new List<ExerciseSubCategoryModel>();

        public IEnumerable<ExerciseEquipmentModel> Equipments { get; set; } = new List<ExerciseEquipmentModel>();
    }
}
