
using System.ComponentModel.DataAnnotations.Schema;

namespace ExeGuide.DataBase.Data.Entities
{
    public class TrainingUsersExercise
    {
        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = null!;

        [ForeignKey(nameof(TrainingUser))]
        public string UserId { get; set; } = null!;
        public TrainingUser TrainingUser { get; set; } = null!;
    }
}
