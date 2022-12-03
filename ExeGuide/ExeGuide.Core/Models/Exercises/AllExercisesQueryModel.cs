using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using ExeGuide.Core.Services.Exercises.Models;

namespace ExeGuide.Core.Models.Exercises
{
    public class AllExercisesQueryModel
    {
        public const int ExercisesPerPage = 6;
         
        public string MainCategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string EquipmentName { get; set; }

        [Display(Name = "Saerch by text")]
        public string SearchTerm { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalExerciseCount { get; set; } 

        public IEnumerable<string> MainCategory { get; set; }

        public IEnumerable<string> SubCategory { get; set; }

        public IEnumerable<string> Equipment { get; set; }

        public IEnumerable<ExerciseServiceModel> Exercises { get; set; } = new List<ExerciseServiceModel>();
    }
}
