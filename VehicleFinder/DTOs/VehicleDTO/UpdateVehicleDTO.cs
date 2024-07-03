using System.ComponentModel.DataAnnotations;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.Enums;

namespace VehicleFinder.DTOs.VehicleDTO
{
    public class UpdateVehicleDTO
    {
        public string? Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1886, 2025, ErrorMessage = "Please enter a valid manufacturing year.")]
        public int ManufacturingYear { get; set; }

        [Required]
        public DateOnly RegistrationUntil { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid amount of kilometers.")]
        public int Kilometers { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number of previous owners.")]
        public int NumberOfPreviousOwners { get; set; }

        [Required]
        public ShifterType ShifterType { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "Vehicle should have between 0 and 20 gears.")]
        public int GearCount { get; set; }

        [Required]
        [Range(0.00, 50.0, ErrorMessage = "Consumption should be between 0 and 50L per 100km.")]
        public decimal AverageConsumption { get; set; }

        public string? EngineId { get; set; }

        public string? BodyId { get; set; }

        public UpdateEngineDTO? Engine { get; set; }

        public UpdateBodyDTO? Body { get; set; }
    }
}
