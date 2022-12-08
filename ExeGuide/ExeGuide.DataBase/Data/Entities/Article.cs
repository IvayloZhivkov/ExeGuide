using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.DataBase.Data.Entities
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        public string ArticleText { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [ForeignKey(nameof(ArticleCategory))]
        public int CategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; } = null!;
    }
}
