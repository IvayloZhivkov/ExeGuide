using Microsoft.Extensions.Logging.Abstractions;

namespace ExeGuide.Core.Services.Models
{
    public class ExerciseIndexServiceModel
    {
        public int Id { get; init; }

        public string Title { get; init; }

        public string ImageUrl { get; init; } 
    }
}
