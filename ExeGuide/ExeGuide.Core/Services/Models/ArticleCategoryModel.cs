namespace ExeGuide.Core.Services.Models
{
    /// <summary>
    /// With this class we can get the article category name and id
    /// </summary>
    public class ArticleCategoryModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;
    }
}
