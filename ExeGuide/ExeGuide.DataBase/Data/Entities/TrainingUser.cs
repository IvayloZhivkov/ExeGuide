using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExeGuide.DataBase.Data.Entities
{
    public class TrainingUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }


        public ICollection<TrainingUsersExercise> TrainingUsersExercises { get; set; } = new List<TrainingUsersExercise>();
    }
}
