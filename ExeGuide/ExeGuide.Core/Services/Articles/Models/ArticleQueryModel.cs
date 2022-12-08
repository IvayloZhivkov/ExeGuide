using ExeGuide.Core.Services.Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.Core.Services.Articles.Models
{
    public class ArticleQueryModel
    {
        public int TotalArticlesCount { get; set; }

        public IEnumerable<ArticleServiceModel> Articles { get; set; } = new List<ArticleServiceModel>();
    }
}
