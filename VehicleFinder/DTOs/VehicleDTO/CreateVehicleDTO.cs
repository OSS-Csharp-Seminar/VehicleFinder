using System;
using System.ComponentModel.DataAnnotations;
using VehicleFinder.Enums;

namespace VehicleFinder.DTOs.VehicleDTO
{
    public class CreateVehicleDTO
    {
        [Required]
        public CarManufacturer Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1886, 2025, ErrorMessage = "Please enter a valid manufacturing year.")]
        public int ManufacturingYear { get; set; }

        [Required]
        [DateAfter("ManufacturingYear", ErrorMessage = "The registration date must be after the manufacturing year.")]
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
        [Range(0.00, 50.0, ErrorMessage = "Consumption should be between 0 and 50L per 100km. ")]
        public double AverageConsumption { get; set; }
        
        public string? EngineId { get; set; } = Guid.NewGuid().ToString();

        public string? BodyId { get; set; } = Guid.NewGuid().ToString();

    }
}
