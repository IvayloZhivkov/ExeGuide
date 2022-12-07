using ExeGuide.Controllers;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Data.Entities;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.UnitTests
{
    public class ExerciseControllerTests
    {
        private readonly Exercise exercises;
        private readonly IExerciseService _exerciseService;
        private readonly IUserService _users;
         

        [Fact]
        public void ExerciseController_Details_ReturnSuccess()
        {
            var controller = new ExerciseController(_exerciseService, _users);

            var result =controller.Details(1) as ViewResult;
            Assert.Equal("Details", result?.ViewName);
        }
    }
}