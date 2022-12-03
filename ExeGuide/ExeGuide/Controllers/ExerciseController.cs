using ExeGuide.Core.Models.Exercises;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;

namespace ExeGuide.Controllers
{
    public class ExerciseController : Controller
    {

        private readonly IExerciseService exerciseService;
        private readonly IUserService users;
        public ExerciseController(IExerciseService exerciseService, IUserService userService)
        {
            this.exerciseService = exerciseService;
            this.users = userService;
        }

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


        public IActionResult Details(int id)
        {
            if (User.IsInRole(EditorRolleName))
            {
                return RedirectToAction("Details", "Editor", new { area = AreaName });
            }
            if (!this.exerciseService.Exists(id))
            {
                return BadRequest();
            }
            var exerciseModel = exerciseService.ExerciseDetailsById(id);
            return View(exerciseModel);
        }

        public IActionResult Add()
        {
            if (User.IsInRole(EditorRolleName))
            {
                return RedirectToAction("Add", "Exercise", new { area = AreaName });
            }
            return RedirectToAction("Index", "Home");
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Favourites(int id)
        {
            string currUserString = User.Id();
            
            var user = users.GetUserById(currUserString);
            
            
            if (!exerciseService.Exists(id))
            {
                return BadRequest();
            }
           
            exerciseService.AddToFav(user.Id, id);
            return RedirectToAction(nameof(All));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            IEnumerable<ExerciseServiceModel> myExercises = null;

            
            var userId = User.Id();
            if (users.ExistById(userId))
            {
                var user = users.GetUserById(userId);
                
                myExercises = exerciseService.AllExercisesById(user.Id);
            }
                return View(myExercises);
           
        }
       


    }
}
