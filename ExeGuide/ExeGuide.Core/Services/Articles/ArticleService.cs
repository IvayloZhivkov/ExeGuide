using ExeGuide.Core.Services.Articles.Models;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Models;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.Core.Services.Articles
{
    public class ArticleService : IArticleService
    {
        public readonly ExeGuideDbContext data;
        public ArticleService(ExeGuideDbContext data)
        {
            this.data = data;
        }

        public ArticleQueryModel All(string searchTerm = null, string ctegoryName = null, int currPage = 1, int articlesPerPage = 1)
        {
            var articleQuerry = this.data.Articles.AsQueryable();

            if (!string.IsNullOrWhiteSpace(ctegoryName))
            {
                articleQuerry = data.Articles
                    .Where(h => h.ArticleCategory.ArticleCategoryName == ctegoryName);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                articleQuerry = articleQuerry.Where(h =>
                h.ArticleText.ToLower().Contains(searchTerm.ToLower()) ||
                h.Title.ToLower().Contains(searchTerm.ToLower()));
            }
            var articles = articleQuerry.Skip((currPage - 1) * articlesPerPage).Take(articlesPerPage).Select(h => new ArticleServiceModel
            {
                Id = h.Id,
                Title = h.Title,
                ArticleText = h.ArticleText,
                ImageUrl = h.ImageUrl
            }).ToList();

            var totalArticles = articleQuerry.Count();

            return new ArticleQueryModel()
            {
                TotalArticlesCount = totalArticles,
                Articles = articles
            };
        }

        public IEnumerable<ArticleCategoryModel> AllCategories() =>
            this.data
            .ArticleCategories
            .Select(c => new ArticleCategoryModel
            {
                Id = c.Id,
                Name = c.ArticleCategoryName
            })
            .ToList();

        public IEnumerable<string> AllCategoriesNames()=> this.data.ArticleCategories.Select(c => c.ArticleCategoryName).Distinct().ToList();

        public ArticleServiceModel ArticleById(int id) =>data.Articles
                .Where(e => e.Id == id)
                .Select(e => new ArticleServiceModel
                {
                    Id = e.Id,
                    Title = e.Title,
                    ArticleText = e.ArticleText,
                    ImageUrl = e.ImageUrl
                }).FirstOrDefault();

    public bool CategoryExists(int categoryId) => this.data.ArticleCategories.Any(c => c.Id == categoryId);

        public int Create(string title, string articleText, string imgageUrl, int category)
        {
            var article = new Article
            {
                Title = title,
                ArticleText = articleText,
                ImageUrl = imgageUrl,
                CategoryId = category
            };

            this.data.Articles.Add(article);
            this.data.SaveChanges();

            return article.Id;
        }

        public void Delete(int articleId)
        {

            var article = data.Articles.Find(articleId);

            data.Remove(article);
            data.SaveChanges();
        }

        public void Edit(int articleId, string title, string articleText, string imgageUrl, int category)
        {
            var article = data.Articles.Find(articleId);

            article.Title = title;
            article.ArticleText = articleText;
            article.ImageUrl = imgageUrl;
            article.CategoryId = category;

            this.data.SaveChanges();
        }

        public bool Exists(int id) => data.Articles.Any(a => a.Id == id);
    }
}
