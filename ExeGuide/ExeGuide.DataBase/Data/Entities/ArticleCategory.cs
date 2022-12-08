using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.DataBase.Data.Entities
{
    public class ArticleCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ArticleCategoryName { get; set; } = null!;
        public ICollection<Article> Article { get; set; } = new List<Article>();
    }
}
