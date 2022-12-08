using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using ExeGuide.Core.Services.Articles.Models;
using ExeGuide.Core.Services.Exercises.Models;

namespace ExeGuide.Core.Models.Articles
{
    public class AllArticlesQueryModel
    {
        public const int ArticlesPerPage = 3;
         
       public string CategoryName { get; init; }

        [Display(Name = "Saerch by text")]
        public string SearchTerm { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalArticlesCount { get; set; } 

       
        public IEnumerable<string> Category { get; set; }

        public IEnumerable<ArticleServiceModel> Articles { get; set; } = new List<ArticleServiceModel>();
    }
}
