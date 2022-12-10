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


        /// <summary>
        /// This method returns all articles to the page
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="ctegoryName"></param>
        /// <param name="currPage"></param>
        /// <param name="articlesPerPage"></param>
        /// <returns></returns>
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



        /// <summary>
        /// This method returns all categories 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ArticleCategoryModel> AllCategories() =>
            this.data
            .ArticleCategories
            .Select(c => new ArticleCategoryModel
            {
                Id = c.Id,
                Name = c.ArticleCategoryName
            })
            .ToList();




        /// <summary>
        /// This method returns all categories names
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> AllCategoriesNames() => this.data.ArticleCategories.Select(c => c.ArticleCategoryName).Distinct().ToList();



        /// <summary>
        /// Returns a article by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ArticleServiceModel ArticleById(int id) => data.Articles
                .Where(e => e.Id == id)
                .Select(e => new ArticleServiceModel
                {
                    Id = e.Id,
                    Title = e.Title,
                    ArticleText = e.ArticleText,
                    ImageUrl = e.ImageUrl
                }).FirstOrDefault();



        /// <summary>
        /// This method ensures that the category exists in the database
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool CategoryExists(int categoryId) => this.data.ArticleCategories.Any(c => c.Id == categoryId);



        /// <summary>
        /// This method finds the category's id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public int CategoryId(int categoryId) => data.Articles.Find(categoryId).CategoryId;



        /// <summary>
        /// This method helps creating the article
        /// </summary>
        /// <param name="title"></param>
        /// <param name="articleText"></param>
        /// <param name="imgageUrl"></param>
        /// <param name="category"></param>
        /// <returns></returns>
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


        /// <summary>
        /// This method deletes the selected article
        /// </summary>
        /// <param name="articleId"></param>
        public void Delete(int articleId)
        {

            var article = data.Articles.Find(articleId);

            data.Remove(article);
            data.SaveChanges();
        }


        /// <summary>
        /// This method edits the selected article
        /// </summary>
        /// <param name="articleId"></param>
        public void Edit(int articleId, string title, string articleText, string imgageUrl, int category)
        {
            var article = data.Articles.Find(articleId);

            article.Title = title;
            article.ArticleText = articleText;
            article.ImageUrl = imgageUrl;
            article.CategoryId = category;

            this.data.SaveChanges();
        }


        /// <summary>
        /// This method find that the database contains an article with the same Id or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exists(int id) => data.Articles.Any(a => a.Id == id);
    }
}
