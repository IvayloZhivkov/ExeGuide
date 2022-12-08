using ExeGuide.Areas.Editor.Models;
using ExeGuide.Areas.Writer.Models;
using ExeGuide.Core.Services.Articles;
using ExeGuide.Core.Services.Exercises;
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

            return RedirectToAction("Index","Home");
        }
    }
}
