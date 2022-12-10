namespace ExeGuide.Core.Services.Models
{
    /// <summary>
    /// With this class we can get the main category name and id
    /// </summary>
    public class ExerciseMainCategoryModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;
    }
}
