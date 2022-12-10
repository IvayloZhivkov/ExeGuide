namespace ExeGuide.Core.Services.Exercises.Models
{
    /// <summary>
    /// This class is child to ExerciseServiceModel and we use it to separately call the exercise catagories
    /// </summary>
    public class ExerciseDetailsServiceModel : ExerciseServiceModel
    {
        public string MainCategory { get; set; }

        public string SubCategory { get; set; }
        public string Equipment { get;set; }
    }
}
