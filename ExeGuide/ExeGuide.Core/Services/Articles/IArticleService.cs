using ExeGuide.Core.Services.Articles.Models;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Models;
using ExeGuide.DataBase.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.Core.Services.Articles
{
    public interface IArticleService
    {
        ArticleQueryModel All(
           string searchTerm = null,
           string ctegoryName = null,
           int currPage = 1,
           int exercisesPerPage = 1
           );
        int Create(string title, string articleText, string imgageUrl, int category);
        void Edit(int articleId, string title, string articleText, string imgageUrl, int category);
        void Delete(int articleId);

        IEnumerable<string> AllCategoriesNames();
        public IEnumerable<ArticleCategoryModel> AllCategories();
        bool CategoryExists(int categoryId);
        bool Exists(int id);
        ArticleServiceModel ArticleById(int id);
    }
}
