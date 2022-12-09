using ExeGuide.Areas.Editor.Models;
using ExeGuide.Areas.Writer.Models;
using ExeGuide.Core.Services.Articles;
using ExeGuide.Core.Services.Articles.Models;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Exercises.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.Areas.Writer.Controllers
{
    public class ArticleController : WriterController
    {
        private readonly IArticleService articleService;
        public ArticleController(IArticleService _articleService)
        {
            articleService = _articleService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {

            return View(new ArticleFormModel
            {
                ArticleCategory = articleService.AllCategories()

            });
        }

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
