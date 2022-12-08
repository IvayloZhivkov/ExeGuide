using ExeGuide.Areas.Writer.Controllers;
using ExeGuide.Core.Models.Exercises;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ExeGuide.Areas.Editor.Models;
using ExeGuide.DataBase.Infrastructure;
using ExeGuide.Core.Services.Exercises.Models;


namespace ExeGuide.Areas.Writer.Controllers
{
    public class ExerciseController : WriterController
    {
        private readonly IExerciseService exerciseService;
        private readonly IUserService users;
        public ExerciseController(IExerciseService exerciseService, IUserService userService)
        {
            this.exerciseService = exerciseService;
            this.users = userService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllExercisesQueryModel query)
        {

            var queryResults = this.exerciseService.All(
                query.SearchTerm,
                query.MainCategoryName,
                query.SubCategoryName,
                query.EquipmentName,
                query.CurrentPage,
                AllExercisesQueryModel.ExercisesPerPage);

            query.TotalExerciseCount = queryResults.TotalExercisesCount;

            query.Exercises = queryResults.Exercises;

            var mainCategoryName = exerciseService.AllMainCategoriesNames();
            var subCategoryName = exerciseService.AllSubCategoriesNames();
            var equipmentName = exerciseService.AllEquipmentNames();
            query.MainCategory = mainCategoryName;
            query.SubCategory = subCategoryName;
            query.Equipment = equipmentName;

            return View(query);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (!this.exerciseService.Exists(id))
            {
                return BadRequest();
            }
            var exerciseModel = exerciseService.ExerciseDetailsById(id);
            return View(exerciseModel);
        }

      

    }
}
