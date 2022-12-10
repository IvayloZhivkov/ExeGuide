namespace ExeGuide.Core.Services.Models
{
    /// <summary>
    /// With this class we can get the equipment name and Id
    /// </summary>
    public class ExerciseEquipmentModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;
    }
}
