using ExeGuide.Core.Services.Exercises;

namespace ExeGuide.Core.Services.Exercises.Models
{
    /// <summary>
    /// With this class we tell the site how much exercises ther are and what there will be (currently Exercises)
    /// </summary>
    public class ExercisesQueryModel
    {
        public int TotalExercisesCount { get; set; }

        public IEnumerable<ExerciseServiceModel> Exercises { get; set; } = new List<ExerciseServiceModel>();
    }
}
