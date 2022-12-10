using ExeGuide.Areas.Writer.Models;
using ExeGuide.Core.Services.Articles;
using ExeGuide.Core.Services.Articles.Models;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using ExeGuide.DataBase.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.Areas.Writer.Controllers
{
    public class ArticleController : WriterController
    {
        private readonly ExeGuideDbContext context;
        private readonly IArticleService articleService;
        public ArticleController(IArticleService _articleService,ExeGuideDbContext _context)
        {
            articleService = _articleService;
            context = _context;
        }


        /// <summary>
        /// This returns a view where the writer can add a new article 
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            bool userExist = context.TrainingUsers.Any(t => t.Id == User.Id());
            if (!userExist)
            {
                var newUser = new TrainingUser()
                {
                    Id = User.Id()
                };
                context.TrainingUsers.Add(newUser);
                context.SaveChangesAsync();
            }

            return View(new ArticleFormModel
            {
                ArticleCategory = articleService.AllCategories()

            });
        }


        /// <summary>
        /// This post method adds the newly created article to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(ArticleFormModel model)
        {

            if (!this.articleService.CategoryExists(model.CategoryId))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (!ModelState.IsValid)
            {

                model.ArticleCategory = this.articleService.AllCategories();

                return View(model);
            }
            var newArticle = this.articleService.Create(model.Title, model.ArticleText, model.ImageUrl, model.CategoryId);

            return RedirectToAction("Index","Writer");
        }

        /// <summary>
        /// The method returns a view where the writeer to see if this is the article that he actually wants to delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!articleService.Exists(id))
            {
                return BadRequest();
            }

            var article = articleService.ArticleById(id);

            var model = new ArticleServiceModel
            {
                Title = article.Title,
                ImageUrl = article.ImageUrl
            };

            return View(model);
        }

        /// <summary>
        /// The method deletes the chosen article by the writer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(ArticleServiceModel exercise)
        {
            if (!articleService.Exists(exercise.Id))
            {
                return BadRequest();
            }
            articleService.Delete(exercise.Id);
            return RedirectToAction("Index", "Writer");
        }


        /// <summary>
        /// With this class the writer will open a view where he can edit the things he want
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!articleService.Exists(id))
            {
                return BadRequest();

            }

            var article = articleService.ArticleById(id);

           
            var category = articleService.CategoryId(article.Id);

            var articleModel = new ArticleFormModel()
            {
                Title = article.Title,
                ImageUrl = article.ImageUrl,
                ArticleText = article.ArticleText,
                ArticleCategory = articleService.AllCategories()
                
            };
            return View(articleModel);
        }




        /// <summary>
        /// This method inserts the changes in the article in the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="article"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, ArticleFormModel article)
        {
            if (!articleService.Exists(id))
            {
                return View();

            }
            if (!this.articleService.CategoryExists(article.CategoryId))
            {
                this.ModelState.AddModelError(nameof(article.CategoryId), "Category does not exist");
            }

            if (!ModelState.IsValid)
            {

                article.ArticleCategory = articleService.AllCategories();

                return View(article);
            }
            articleService.Edit(id, article.Title, article.ArticleText, article.ImageUrl, article.CategoryId);

            return RedirectToAction("Index","Writer");
        }

    }
}
