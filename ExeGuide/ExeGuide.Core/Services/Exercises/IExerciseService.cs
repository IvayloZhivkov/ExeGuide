using Microsoft.AspNetCore.Mvc;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Models;

namespace ExeGuide.Core.Services.Exercises
{
    public interface IExerciseService
    {
        IEnumerable<ExerciseIndexServiceModel> AllShowingSlide();

        ExercisesQueryModel All(
            string searchTerm = null,
            string mianCtegoryName = null,
            string subCtegoryName = null,
            string EquipmentName = null,
            int currPage = 1,
            int exercisesPerPage = 1
            );

        IEnumerable<string> AllMainCategoriesNames();
        IEnumerable<string> AllSubCategoriesNames();
        IEnumerable<string> AllEquipmentNames();

        void AddToFav(string userId, int exerciseId);

       IEnumerable<ExerciseServiceModel> AllExercisesById(string userId);

        ExerciseDetailsServiceModel ExerciseDetailsById(int id);
        public bool Exists(int id);

    }
}
