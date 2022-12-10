using ExeGuide.Core.Services.Models;
using MessagePack.Formatters;
using System.ComponentModel.DataAnnotations;

namespace ExeGuide.Areas.Writer.Models
{
    /// <summary>
    /// This clas we explain what information an article containss
    /// </summary>
    public class ArticleFormModel
    {
        [Required]
        [MaxLength(100)]
        [MinLength(10)]

        [Display(Name = "Title")]
        public string Title { get; init; } = null!;

        [Required]
        [MinLength(100)]

        [Display(Name = "Text")]
        public string ArticleText { get; init; } = null!;


        [Display(Name = "Image Url")]
        public string? ImageUrl { get; init; }

        [Display(Name = "Category") ]
        public int CategoryId { get; init; }
        public IEnumerable<ArticleCategoryModel> ArticleCategory { get; set; } = new List<ArticleCategoryModel>();
    }
}
