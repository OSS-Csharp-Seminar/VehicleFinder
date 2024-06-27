using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleFinder.DTOs.VehicleDTO
{
    public class CreateVehicleDTO
    {
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1886, 2100, ErrorMessage = "Please enter a valid manufacturing year")]
        public int ManufacturingYear { get; set; }

        [Required]
        public DateOnly RegistrationUntil { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid kilometer")]
        public int Kilometers { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number of previous owners")]
        public int NumberOfPreviousOwners { get; set; }
    }
}
