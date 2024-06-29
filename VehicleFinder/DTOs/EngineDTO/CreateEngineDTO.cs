using System.ComponentModel.DataAnnotations;
using VehicleFinder.Entities;
using VehicleFinder.Enums;

namespace VehicleFinder.DTOs.EngineDTO
{
    public class CreateEngineDTO
    {
        [Required]
        [StringLength(40, ErrorMessage = "The title cannot exceed 40 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string FuelType { get; set; }

        [Required]
        [Range(1, 2000, ErrorMessage = "Horsepower must be between 1 and 2000.")]
        public int Horsepower { get; set; }

        [Required]
        [Range(500, 8000, ErrorMessage = "Engine capacity must be between 500 and 8000 cc.")]
        public int EngineCapacity { get; set; }
    }
}

