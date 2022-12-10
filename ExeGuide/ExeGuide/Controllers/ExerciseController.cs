using ExeGuide.Core.Models.Exercises;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using ExeGuide.DataBase.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;

namespace ExeGuide.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly ExeGuideDbContext context; 
        private readonly IExerciseService exerciseService;
        private readonly IUserService users;
        public ExerciseController(IExerciseService exerciseService, IUserService userService, ExeGuideDbContext context)
        {
            this.exerciseService = exerciseService;
            this.users = userService;
            this.context = context;
        }

        /// <summary>
        /// This task return the All Exercises page. In it we throw a query with the information we need to show to the user.
        /// </summary>
        /// <param name="query"> Query for the database to show the info we need</param>
        /// <returns>Returns a view page where we can see all the exercises</returns>
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


        /// <summary>
        /// Shows details for an exercise
        /// </summary>
        /// <param name="id">The chosen Exercise id</param>
        /// <returns>Returns a view page for details</returns>
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
        /// This is for redirecting only. If non authorized person tries to "Add" an exercise. And if is authorised, he will be redirected to the correct page.
        /// </summary>
        /// <returns>Returns error page or refirects to correct page</returns>

        [Authorize]
        public IActionResult Add()
        {
            if (User.IsInRole(EditorRolleName))
            {
                return RedirectToAction("Add", "Exercise", new { area = AreaName });
            }
            return View();
        }



        /// <summary>
        /// This post gives the registered user to "save" the exercises he likes.
        /// </summary>
        /// <param name="id">Exercise id</param>
        /// <returns>Connects the exercise to the user</returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Favourites(int id)
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
            string currUserString = User.Id();

            var user = users.GetUserById(currUserString);


            if (!exerciseService.Exists(id))
            {
                return BadRequest();
            }

            exerciseService.AddToFav(user.Id, id);
            return RedirectToAction(nameof(All));
        }


        /// <summary>
        /// Where user can see his favourite exercises
        /// </summary>
        /// <returns>Returns a view with favourite exercises</returns>
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            bool userExist = context.TrainingUsers.Any(t => t.Id == User.Id());
            if (!userExist)
            {
                var newUser = new TrainingUser()
                {
                    Id = User.Id()
                };
                context.TrainingUsers.Add(newUser);
                await context.SaveChangesAsync();
            }
            IEnumerable<ExerciseServiceModel> myExercises = null;


            var userId = User.Id();
            if (users.ExistById(userId))
            {
                var user = users.GetUserById(userId);

                myExercises = exerciseService.AllExercisesById(user.Id);
            }
            return View(myExercises);
        }

        /// <summary>
        /// Removes an exercise from favourite
        /// </summary>
        /// <param name="id">exercise id</param>
        /// <returns>Removes the exercise from the composite key in the database</returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RemoveFromFavourites(int id)
        {
            if (!exerciseService.Exists(id))
            {
                return BadRequest();
            }
            var user = User.Id();
            exerciseService.RemoveFromFavourite(id, user);
            return RedirectToAction(nameof(Mine));



        }



    }
}
