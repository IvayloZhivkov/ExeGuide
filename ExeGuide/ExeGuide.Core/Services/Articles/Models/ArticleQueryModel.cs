using ExeGuide.Core.Services.Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.Core.Services.Articles.Models
{
    /// <summary>
    /// With this class we tell the site how much articles ther will be in the current page and what there will be (currently Articles)
    /// </summary>
    public class ArticleQueryModel
    {
        public int TotalArticlesCount { get; set; }

        public IEnumerable<ArticleServiceModel> Articles { get; set; } = new List<ArticleServiceModel>();
    }
}
