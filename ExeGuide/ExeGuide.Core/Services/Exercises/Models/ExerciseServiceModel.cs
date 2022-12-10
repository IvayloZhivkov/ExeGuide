using System.ComponentModel.DataAnnotations;

namespace ExeGuide.Core.Services.Exercises.Models
{
    /// <summary>
    /// We use this class to accsess the exercise info for the view and more data manipulation
    /// </summary>
    public class ExerciseServiceModel
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Display(Name = "Description")]
        public string Description { get; set; } = null!;

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;
    }
}
