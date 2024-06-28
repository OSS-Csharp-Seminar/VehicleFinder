using System.ComponentModel.DataAnnotations;
using VehicleFinder.Enums;

namespace VehicleFinder.DTOs.BodyDTO
{
    public class CreateBodyDTO
    {
        [Required]
        [Range(2, 10, ErrorMessage = "Door count must be between 2 and 10.")]
        public int DoorCount { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Seat count must be between 1 and 100.")]
        public int SeatCount { get; set; }

        [Required]
        public ACType ACType { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The color name cannot exceed 20 characters.")]
        public string Color { get; set; } = string.Empty;

        [Required]
        public BodyShape BodyShape { get; set; }
    }
}
