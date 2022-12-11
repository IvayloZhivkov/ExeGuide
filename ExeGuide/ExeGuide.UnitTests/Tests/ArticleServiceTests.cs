using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeGuide.Core.Infrastructure;
using ExeGuide.Core.Services.Articles;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace ExeGuide.UnitTests.Tests
{
    [TestFixture]
    public class ArticleServiceTests
    {
        private IRepository repo;
        private ExeGuideDbContext context;
        private ArticleService service;

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
        public async Task AllArticlesTest()
        {   
            var repo = new Repository(context);
            service = new ArticleService(context);

            await repo.AddAsync(new Article() { Id = 99, Title = "", ArticleText = "", CategoryId = 1, ImageUrl = "" });
            await  context.SaveChangesAsync();
            var result = service.All();

            Assert.That(result.TotalArticlesCount == 1);
        }

        [Test]
        public async Task AllCategoriesTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);

            var result = service.AllCategories();

            Assert.That(result.Count() == 5);
        }

        [Test]
        public async Task AllCategoriesNamesTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);

            var result = service.AllCategoriesNames();

            Assert.That(result.Count() == 5);
        }

        [Test]
        public async Task ArticleByIdTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);

            await repo.AddAsync(new Article() { Id = 99, Title = "", ArticleText = "", CategoryId = 1, ImageUrl = "" });
            await context.SaveChangesAsync();

            var article = service.ArticleById(99);

            Assert.That(article.Id == 99);

        }


        [Test]
        public async Task CategoryExistsTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);

            await repo.AddAsync(new ArticleCategory() { Id = 50,ArticleCategoryName = "Me"});
            await context.SaveChangesAsync();
            var article = service.CategoryExists(50);

            Assert.That(article);

        }


        [Test]
        public async Task CategoryIdTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);

            await repo.AddAsync(new Article() { Id = 99, Title = "", ArticleText = "", CategoryId = 1, ImageUrl = "" });
            await context.SaveChangesAsync();
            var article = service.ArticleById(99);
            var articleCategoryId = service.CategoryId(article.Id);
            

            Assert.That(articleCategoryId == 1);

        }


        [Test]
        public async Task CreateArticleTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);

            service.Create( "Me",   "Text", "URL", 2);
            await context.SaveChangesAsync();
            var article = context.Articles.FirstOrDefault(a => a.Title == "Me");
            Assert.That(article.Title=="Me");
        }

        [Test]
        public async Task DeleteArticleTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);
            await repo.AddAsync(new Article() { Id = 99, Title = "", ArticleText = "", CategoryId = 1, ImageUrl = "" });
            await context.SaveChangesAsync();
             
            service.Delete(99);
            bool exist = service.Exists(99);

            Assert.That(exist is false);
        }

        [Test]
        public async Task EditArticleTest()
        {
            var repo = new Repository(context);
            service = new ArticleService(context);
            await repo.AddAsync(new Article() { Id = 99, Title = "", ArticleText = "", CategoryId = 1, ImageUrl = "" });
            await context.SaveChangesAsync();

            service.Edit(99,"me","","",1);
            context.SaveChangesAsync();
            var article = service.ArticleById(99);

            Assert.That(article.Title =="me");

        }

        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }
    }
}
