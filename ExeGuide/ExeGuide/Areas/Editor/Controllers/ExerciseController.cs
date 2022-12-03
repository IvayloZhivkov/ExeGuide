using ExeGuide.Areas.Editor.Controllers;
using ExeGuide.Core.Models.Exercises;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ExeGuide.Areas.Editor.Models;
using ExeGuide.DataBase.Infrastructure;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;

namespace TrainingHelper.Areas.Editor.Controllers
{
    public class ExerciseController : EditorController
    {
        private readonly IExerciseService exerciseService;
        private readonly IUserService users;
        public ExerciseController(IExerciseService exerciseService, IUserService userService)
        {
            this.exerciseService = exerciseService;
            this.users = userService;
        }


        //public async Task<IActionResult> All([FromQuery] AllExercisesQueryModel query)
        //{

        //    var queryResults = this.exerciseService.All(
        //        query.SearchTerm,
        //        query.MainCategoryName,
        //        query.SubCategoryName,
        //        query.EquipmentName,
        //        query.CurrentPage,
        //        AllExercisesQueryModel.ExercisesPerPage);

        //    query.TotalExerciseCount = queryResults.TotalExercisesCount;

        //    query.Exercises = queryResults.Exercises;

        //    var mainCategoryName = exerciseService.AllMainCategoriesNames();
        //    var subCategoryName = exerciseService.AllSubCategoriesNames();
        //    var equipmentName = exerciseService.AllEquipmentNames();
        //    query.MainCategory = mainCategoryName;
        //    query.SubCategory = subCategoryName;
        //    query.Equipment = equipmentName;

        //    return View(query);
        //}


        public IActionResult Details(int id)
        {
            if (!this.exerciseService.Exists(id))
            {
                return BadRequest();
            }
            var exerciseModel = exerciseService.ExerciseDetailsById(id);
            return View(exerciseModel);
        }

        [Authorize]
        public IActionResult Add()
        {
           

            return View(new ExerciseFormModel
            {
                MainCategories = exerciseService.AllMainCategories(),
                SubCategories = exerciseService.AllSubCategories(),
                Equipments = exerciseService.AllEquipments()
            });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(ExerciseFormModel model)
        {

            if (!this.exerciseService.MainCategoryExists(model.MainCategoryId))
            {
                this.ModelState.AddModelError(nameof(model.MainCategoryId), "Main category does not exist");
            }
            if (!this.exerciseService.SubCategoryExists(model.SubCategoryId))
            {
                this.ModelState.AddModelError(nameof(model.SubCategoryId), "Subcategory does not exist");
            }
            if (!this.exerciseService.EquipmentExists(model.EquipmentId))
            {
                this.ModelState.AddModelError(nameof(model.EquipmentId), "Equipment does not exist");
            }
            if (!ModelState.IsValid)
            {
                model.MainCategories = this.exerciseService.AllMainCategories();
                model.SubCategories = this.exerciseService.AllSubCategories();
                model.Equipments = this.exerciseService.AllEquipments();

                return View(model);
            }

            

            var newExercise = this.exerciseService.Create(model.Name, model.Description, model.ImageUrl, model.MainCategoryId, model.SubCategoryId, model.EquipmentId);

            return RedirectToAction(nameof(Details), new { id = newExercise });
        }



    }
}
