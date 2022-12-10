using Microsoft.AspNetCore.Mvc;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Models;


namespace ExeGuide.Core.Services.Exercises
{
    public interface IExerciseService
    {
       

        ExercisesQueryModel All(
            string searchTerm = null,
            string mianCtegoryName = null,
            string subCtegoryName = null,
            string EquipmentName = null,
            int currPage = 1,
            int exercisesPerPage = 1
            );

        public IEnumerable<ExerciseMainCategoryModel> AllMainCategories();
        public IEnumerable<ExerciseSubCategoryModel> AllSubCategories();
        public IEnumerable<ExerciseEquipmentModel> AllEquipments();

        IEnumerable<string> AllMainCategoriesNames();
        IEnumerable<string> AllSubCategoriesNames();
        IEnumerable<string> AllEquipmentNames();

        void AddToFav(string userId, int exerciseId);

        IEnumerable<ExerciseServiceModel> AllExercisesById(string userId);

        ExerciseDetailsServiceModel ExerciseDetailsById(int id);
        public bool Exists(int id);
        bool MainCategoryExists(int categoryId);
        bool SubCategoryExists(int categoryId);
        bool EquipmentExists(int categoryId);

        int Create(string title, string description, string imgageUrl, int mainCategoryId, int subCategoryId, int equipmentId);
        void Edit(int exerciseId,string title, string description, string imgageUrl, int mainCategoryId, int subCategoryId, int equipmentId);
        void Delete(int exerciseId);
        int MainCategoryId(int categoryId);
        int SubCategoryId(int categoryId);
        int EquipmentId(int categoryId);

    }
}
