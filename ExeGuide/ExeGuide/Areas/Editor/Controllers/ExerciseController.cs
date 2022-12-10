using ExeGuide.Areas.Editor.Controllers;
using ExeGuide.Core.Models.Exercises;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ExeGuide.Areas.Editor.Models;
using ExeGuide.DataBase.Infrastructure;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;
using ExeGuide.Core.Services.Exercises.Models;
using System.Reflection.Metadata;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;

namespace ExeGuide.Areas.Editor.Controllers
{
    public class ExerciseController : EditorController
    {
        private readonly ExeGuideDbContext context;
        private readonly IExerciseService exerciseService;
        private readonly IUserService users;
        public ExerciseController(IExerciseService exerciseService, IUserService userService, ExeGuideDbContext _context)
        {
            this.exerciseService = exerciseService;
            this.users = userService;
            context = _context;
        }


        /// <summary>
        /// This method returns a view with all exercises in the databse
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllExercisesQueryModel query)
        {
            bool userExist = context.TrainingUsers.Any(t => t.Id == User.Id());
            if (!userExist)
            {
                var newUser = new TrainingUser()
                {
                    Id = User.Id()
                };
                context.TrainingUsers.Add(newUser);
                context.SaveChanges();
            }
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


        /// <summary>
        /// This method returns a view containing more information about the chosen exercise
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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


        /// <summary>
        /// This method returns a view where the editor can add a new exercise to the database
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {

            return View(new ExerciseFormModel
            {
                MainCategories = exerciseService.AllMainCategories(),
                SubCategories = exerciseService.AllSubCategories(),
                Equipments = exerciseService.AllEquipments()
            });
        }


        /// <summary>
        /// Unpon inserting the new infomation and saving it this method saves the new exercise to the databse
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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


        /// <summary>
        /// This method returns a view where the editor can see what exercise he is about to delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!exerciseService.Exists(id))
            {
                return BadRequest();
            }

            var exercise = exerciseService.ExerciseDetailsById(id);

            var model = new ExerciseDetailsServiceModel
            {
                Name = exercise.Name,
                ImageUrl = exercise.ImageUrl
            };

            return View(model);
        }


        /// <summary>
        /// When the editor is shure about his choise, upon clicking the delete button this method activates and deletes the exercise from the database
        /// </summary>
        /// <param name="exercise"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(ExerciseDetailsServiceModel exercise)
        {
            if (!exerciseService.Exists(exercise.Id))
            {
                return BadRequest();
            }
            exerciseService.Delete(exercise.Id);
            return RedirectToAction("Index", "Editor");
        }

        /// <summary>
        /// This method opens a view where the editor will be able to edit the exercise he choses
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!exerciseService.Exists(id))
            {
                return BadRequest();

            }

            var exercise = exerciseService.ExerciseDetailsById(id);

            var mainCategory = exerciseService.MainCategoryId(exercise.Id);
            var subCategory = exerciseService.SubCategoryId(exercise.Id);
            var equipment = exerciseService.EquipmentId(exercise.Id);

            var houseModel = new ExerciseFormModel()
            {
                Name = exercise.Name,
                Description = exercise.Description,
                ImageUrl = exercise.ImageUrl,
                MainCategoryId = mainCategory,
                MainCategories = exerciseService.AllMainCategories(),
                SubCategoryId = subCategory,
                SubCategories = exerciseService.AllSubCategories(),
                EquipmentId = equipment,
                Equipments = exerciseService.AllEquipments()
            };
            return View(houseModel);
        }


        /// <summary>
        /// Uppon chosing and editing the exercise this method activates and saves the changes in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="exercise"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, ExerciseFormModel exercise)
        {
            if (!exerciseService.Exists(id))
            {
                return View();

            }
            if (!exerciseService.MainCategoryExists(exercise.MainCategoryId))
            {
                ModelState.AddModelError(nameof(exercise.MainCategoryId), "Main category does not exist!");
            }
            if (!exerciseService.SubCategoryExists(exercise.SubCategoryId))
            {
                ModelState.AddModelError(nameof(exercise.SubCategoryId), "Subcategory does not exist!");
            }
            if (!exerciseService.EquipmentExists(exercise.EquipmentId))
            {
                ModelState.AddModelError(nameof(exercise.EquipmentId), "Equipment does not exist!");
            }

            if (!ModelState.IsValid)
            {
                exercise.MainCategories = exerciseService.AllMainCategories();
                exercise.SubCategories = exerciseService.AllSubCategories();
                exercise.Equipments = exerciseService.AllEquipments();

                return View(exercise);
            }
            exerciseService.Edit(id, exercise.Name, exercise.Description, exercise.ImageUrl, exercise.MainCategoryId, exercise.SubCategoryId, exercise.EquipmentId);

            return RedirectToAction(nameof(Details), new { id = id });
        }


    }
}
