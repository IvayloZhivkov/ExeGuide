using ExeGuide.DataBase.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeGuide.DataBase.Data.Configurations
{
    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.HasData(Categories());
        }
        private List<ArticleCategory> Categories()
        {
            List<ArticleCategory> categories = new List<ArticleCategory>()
            {
               new ArticleCategory() { Id = 1, ArticleCategoryName = "Food and Health" },
               new ArticleCategory() { Id = 2, ArticleCategoryName = "People" },
               new ArticleCategory() { Id = 3, ArticleCategoryName = "Competitions"},
               new ArticleCategory() { Id = 4, ArticleCategoryName = "Bodybuilding"},
               new ArticleCategory() { Id = 5, ArticleCategoryName = "Workout Plans"}

            };
            return categories;
        }
    }
}
