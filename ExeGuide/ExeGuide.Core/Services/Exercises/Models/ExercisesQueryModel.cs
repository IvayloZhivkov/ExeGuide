using ExeGuide.Core.Services.Exercises;

namespace ExeGuide.Core.Services.Exercises.Models
{
    public class ExercisesQueryModel
    {
        public int TotalExercisesCount { get; set; }

        public IEnumerable<ExerciseServiceModel> Exercises { get; set; } = new List<ExerciseServiceModel>();
    }
}
