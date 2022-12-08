using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExeGuide.Core.Services.Articles.Models
{
    public class ArticleServiceModel
    {
        public int Id { get; set; }


        public string Title { get; set; } = null!;

        [Display(Name = "Article Text")]
        public string ArticleText { get; set; } = null!;

        [Display(Name = "Image Url")]
        public string? ImageUrl { get; set; }

        
    }
}
