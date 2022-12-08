using ExeGuide.Core.Models.Articles;
using ExeGuide.Core.Models.Exercises;
using ExeGuide.Core.Services.Articles;
using ExeGuide.Core.Services.Exercises;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ExeGuide.Areas.Writer.Constants.WriterConstants;

namespace ExeGuide.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        public ArticleController(IArticleService _articleService)
        {
            articleService = _articleService;
        }
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllArticlesQueryModel query)
        {

            var queryResults = this.articleService.All(
                query.SearchTerm,
                query.CategoryName,
                query.CurrentPage,
                AllArticlesQueryModel.ArticlesPerPage);

            query.TotalArticlesCount = queryResults.TotalArticlesCount;
            query.Articles = queryResults.Articles;

            var categoryName = articleService.AllCategoriesNames();
            
            query.Category = categoryName;

            return View(query);
        }
        [Authorize]
        public IActionResult Add()
        {
            if (User.IsInRole(WriterRolleName))
            {
                return RedirectToAction("Add", "Article", new { area = AreaName });
            }
            return View();
        }

    }
}
