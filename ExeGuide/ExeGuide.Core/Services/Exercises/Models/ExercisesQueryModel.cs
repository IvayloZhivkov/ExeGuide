using ExeGuide.Core.Services.Exercises;

namespace ExeGuide.Core.Services.Exercises.Models
{
    /// <summary>
    /// This class we use to specify the number of exercises shown in the "All exercise" page
    /// </summary>
    public class ExercisesQueryModel
    {
        public int TotalExercisesCount { get; set; }

        public IEnumerable<ExerciseServiceModel> Exercises { get; set; } = new List<ExerciseServiceModel>();
    }
}
