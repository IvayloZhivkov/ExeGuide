using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeGuide.DataBase.Data.Entities;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace ExeGuide.UnitTests.Tests
{
    [TestFixture]
    public class ExerciseServiceTests
    {
        private ExeGuideDbContext context;
        private ExerciseService service;
        private IUserService userService;

        [SetUp]
        public void SetUp()
        {
            var contextOptions = new DbContextOptionsBuilder<ExeGuideDbContext>()
                            .UseInMemoryDatabase("HouseDB")
                            .Options;
            context = new ExeGuideDbContext(contextOptions);


            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        [Test]
        public async Task AllExercisesByIdTest()
        {


            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            var newUser = new TrainingUser()
            {
                Id = "bcbssss-ecca-43c9-dss-c060c6f364e4",
                Email = "daadad.dd",
                NormalizedEmail = "daadad.dd",
                UserName = "daadad.dd",
                NormalizedUserName = "daadad.dd",
                SecurityStamp = "agAAAAdsdsHRTRSD123ID9VE0dfskgfjek9nfp24EKSuid",
                ConcurrencyStamp = ""
            };

            var exercise = context.Exercises.FirstOrDefault(e => e.Id == 1);

            var userExercise = new TrainingUsersExercise()
            {
                ExerciseId = exercise.Id,
                UserId = newUser.Id
            };
            context.TrainingUsersExercises.Add(userExercise);
            context.SaveChangesAsync();
            var result = service.AllExercisesById(newUser.Id);
            Assert.That(result.Count() == 1);
        }

        [Test]
        public async Task AddToFavTest()
        {

            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            var newUser = new TrainingUser()
            {
                Id = "bcbssss-ecca-43c9-dss-c060c6f364e4",
                Email = "daadad.dd",
                NormalizedEmail = "daadad.dd",
                UserName = "daadad.dd",
                NormalizedUserName = "daadad.dd",
                SecurityStamp = "agAAAAdsdsHRTRSD123ID9VE0dfskgfjek9nfp24EKSuid",
                ConcurrencyStamp = ""
            };

            var exercise = context.Exercises.FirstOrDefault(e => e.Id == 1);

            service.AddToFav(newUser.Id, exercise.Id);
            context.SaveChangesAsync();
            var userExercise = context.TrainingUsersExercises.FirstOrDefault(e => e.UserId == newUser.Id);

            var contains = userExercise.ExerciseId == exercise.Id;

            Assert.That(contains);
        }

        [Test]
        public async Task AddToFavTest2()
        {

            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            var newUser = new TrainingUser()
            {
                Id = "bcbssss-ecca-43c9-dss-c060c6f364e4",
                Email = "daadad.dd",
                NormalizedEmail = "daadad.dd",
                UserName = "daadad.dd",
                NormalizedUserName = "daadad.dd",
                SecurityStamp = "agAAAAdsdsHRTRSD123ID9VE0dfskgfjek9nfp24EKSuid",
                ConcurrencyStamp = ""
            };

            var exercise = context.Exercises.FirstOrDefault(e => e.Id == 1);

            service.AddToFav(newUser.Id, exercise.Id);
            context.SaveChangesAsync();
            service.AddToFav(newUser.Id, exercise.Id);
            context.SaveChangesAsync();

            var userEX = context.TrainingUsersExercises.Where(e => e.ExerciseId == exercise.Id)
                .Where(a => a.UserId == newUser.Id);


            Assert.That(userEX.Count() == 1);
        }

        [Test]
        public async Task RemoveToFavTest()
        {

            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            var newUser = new TrainingUser()
            {
                Id = "bcbssss-ecca-43c9-dss-c060c6f364e4",
                Email = "daadad.dd",
                NormalizedEmail = "daadad.dd",
                UserName = "daadad.dd",
                NormalizedUserName = "daadad.dd",
                SecurityStamp = "agAAAAdsdsHRTRSD123ID9VE0dfskgfjek9nfp24EKSuid",
                ConcurrencyStamp = ""
            };

            var exercise = context.Exercises.FirstOrDefault(e => e.Id == 1);

            service.AddToFav(newUser.Id, exercise.Id);
            await context.SaveChangesAsync();
            service.RemoveFromFavourite(exercise.Id, newUser.Id);
            await context.SaveChangesAsync();
            var check = new TrainingUsersExercise()
            {
                ExerciseId = exercise.Id,
                UserId = newUser.Id
            };
            var contains = context.TrainingUsersExercises.Contains(check);

            Assert.That(contains is false);
        }



        [Test]
        public async Task MainCategoryExistsTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            context.AddAsync(new MainCategory { Id = 1, MainCategoryName = "Muscle1" });
            context.AddAsync(new MainCategory { Id = 2, MainCategoryName = "Muscle2" });
            context.SaveChangesAsync();

            bool exists = service.MainCategoryExists(1);
            Assert.That(exists);
        }

        [Test]
        public async Task SubCategoryExistsTest()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            context.AddAsync(new SubCategory { Id = 1, SubCategoryName = "Muscle1" });
            context.AddAsync(new SubCategory { Id = 2, SubCategoryName = "Muscle2" });
            context.SaveChangesAsync();

            bool exists = service.SubCategoryExists(2);
            Assert.That(exists);
        }


        [Test]
        public async Task EquipmentExistsTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            context.AddAsync(new Equipment { Id = 1, Name = "Eq1" });
            context.AddAsync(new Equipment { Id = 2, Name = "Eq2" });
            context.SaveChangesAsync();

            bool exists = service.EquipmentExists(1);
            Assert.That(exists);
        }

        [Test]
        public async Task EquipmentIdTest()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            context.AddAsync(new Equipment { Id = 1, Name = "Eq1" });
            context.AddAsync(new Equipment { Id = 2, Name = "Eq2" });
            context.SaveChangesAsync();

            int id = service.EquipmentId(1);
            Assert.That(id == 1);
        }
        [Test]
        public async Task SubCategoryIdTest()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            context.AddAsync(new SubCategory() { Id = 1, SubCategoryName = "Muscle1" });
            context.AddAsync(new SubCategory() { Id = 2, SubCategoryName = "Muscle2" });
            context.SaveChangesAsync();

            int id = service.SubCategoryId(2);
            Assert.That(id == 2);
        }
        [Test]
        public async Task MainCategoryIdTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            context.AddAsync(new MainCategory() { Id = 1, MainCategoryName = "Muscle1" });
            context.AddAsync(new MainCategory() { Id = 2, MainCategoryName = "Muscle2" });
            context.SaveChangesAsync();

            int id = service.MainCategoryId(1);
            Assert.That(id == 1);
        }


        [Test]
        public async Task DeleteExerciseTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            await context.AddAsync(new Exercise() { Id = 99, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            await context.SaveChangesAsync();
            service.Delete(99);
            await context.SaveChangesAsync();
            var exercise = service.Exists(99);
            Assert.That(exercise == false);
        }


        [Test]
        public async Task CreateExerciseTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            service.Create(
                "newEx",
                "ss",
                "ss",
                 1,
                 2,
                3
            );
            await context.SaveChangesAsync();
            var exist = context.Exercises.Any(x => x.Name == "newEx");
            Assert.That(exist);
        }

        [Test]
        public async Task EditExerciseTest()
        {

           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            var newExercise = new Exercise()
            {
                Id = 99,
                Name = "oldEx",
                Description = "  ddd",
                ImageUrl = "",
                MainCategoryId = 1,
                SubCategoryId = 1,
                EquipmentId = 1,
            };

            context.AddAsync(newExercise);
            context.SaveChangesAsync();

            service.Edit(99, "newEx", "dddd", "dwsd", 1, 1, 1);
            await context.SaveChangesAsync();
            Exercise get = context.Exercises.FirstOrDefault(e => e.Name == "newEx");

            Assert.That(context.Exercises.Contains(get));
        }


        [Test]
        public async Task AllExercisesTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            await context.AddAsync(new Exercise() { Id = 99, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            await context.AddAsync(new Exercise() { Id = 98, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            context.SaveChangesAsync();
            var result = service.All();

            // The actual result is 6,because when started in the database are inserted 4 exercises outside of the test scenario(ExeGuide.Database.Data.Configurations.ExerciseConfiguration)
            Assert.That(result.TotalExercisesCount == 6);

        }

        [Test]
        public async Task AllExercisesIfStatement1Test()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            await context.AddAsync(new Exercise() { Id = 99, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            await context.AddAsync(new Exercise() { Id = 98, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            context.SaveChangesAsync();
            var result = service.All("Chest Press");


            Assert.That(result.TotalExercisesCount == 3);

        }
        [Test]
        public async Task AllExercisesIfStatement2Test()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            await context.AddAsync(new Exercise() { Id = 99, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            await context.AddAsync(new Exercise() { Id = 98, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            context.SaveChangesAsync();
            var result = service.All("", "Chest");


            Assert.That(result.TotalExercisesCount == 1);

        }
        [Test]
        public async Task AllExercisesIfStatement3Test()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            await context.AddAsync(new Exercise() { Id = 99, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            await context.AddAsync(new Exercise() { Id = 98, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            context.SaveChangesAsync();
            var result = service.All("", "", "Upper Chest");


            Assert.That(result.TotalExercisesCount == 0);

        }


        [Test]
        public async Task AllExercisesIfStatement4Test()
        {
          
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            await context.AddAsync(new Exercise() { Id = 99, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            await context.AddAsync(new Exercise() { Id = 98, Name = "Chest Press", Description = "", EquipmentId = 1, MainCategoryId = 2, SubCategoryId = 3, ImageUrl = "" });
            context.SaveChangesAsync();
            var result = service.All("", "", "", "Barbell");


            Assert.That(result.TotalExercisesCount == 1);

        }


        [Test]
        public async Task AllEquipmentNamesTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var names = service.AllEquipmentNames();
            //7 because we initialize equipments to the database(ExeGuide.Database.Data.Configurations.EquipmentConfiguration)
            Assert.That(names.Count, Is.EqualTo(7));

        }
        [Test]
        public async Task AllMainCategoryNamesTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var names = service.AllMainCategoriesNames();
            //8+6 because we initialize MainCategories to the database(ExeGuide.Database.Data.Configurations.MainCategoryConfiguration)
            Assert.That(names.Count, Is.EqualTo(6));
        }

        [Test]
        public async Task AllSubCategoryNamesTest()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            var names = service.AllSubCategoriesNames();
            //31 because we initialize  SubCategories to the database(ExeGuide.Database.Data.Configurations.SubCategoryConfiguration)
            Assert.That(names.Count, Is.EqualTo(31));
        }


        [Test]
        public async Task ExerciseDetailsById()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);

            service.Create(
                "newEx",
                "ss",
                "ss",
                1,
                2,
                3
            );
            await context.SaveChangesAsync();

            int id = context.Exercises.FirstOrDefault(e => e.Name == "newEx").Id;
            var result = service.ExerciseDetailsById(id);

            Assert.That(result.Id == id);


        }


        [Test]
        public async Task AllMainCategoriesTest()
        {
            
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var result = service.AllMainCategories();
            Assert.That(result.Count() == 6);
        }

        [Test]
        public async Task AllSubCategoriesTest()
        {
          
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var result = service.AllSubCategories();
            Assert.That(result.Count() == 32);
        }

        [Test]
        public async Task AllEqipmentTest()
        {
           
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var result = service.AllEquipments();
            Assert.That(result.Count() == 7);
        }


        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

    }
}
