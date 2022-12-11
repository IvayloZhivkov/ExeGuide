using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using ExeGuide.Core.Infrastructure;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace ExeGuide.UnitTests.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private IRepository repo;
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
        public async Task UserExistByIdTest()
        {
            var repo = new Repository(context);
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var user = userService.ExistById("bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            Assert.That(user);
        }

        [Test]
        public async Task GetUserByIdTest()
        {
            var repo = new Repository(context);
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var user = userService.GetUserById("bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            Assert.That(user.Id== "bcb4f072-ecca-43c9-ab26-c060c6f364e4");
        }

        [Test]
        public async Task GetUserIdTest()
        {
            var repo = new Repository(context);
            userService = new UserService(context);
            service = new ExerciseService(context, userService);


            var user = userService.GetUserId("bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            Assert.That(user == "bcb4f072-ecca-43c9-ab26-c060c6f364e4");
        }


        [Test]
        public async Task AddNewUserTest()
        {
            var repo = new Repository(context);
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
             userService.AddNewUser(newUser);
             context.SaveChangesAsync();

             Assert.That(context.TrainingUsers.Contains(newUser));

        }


        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }

    }
}
