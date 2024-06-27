using System;
using System.ComponentModel.DataAnnotations;
using VehicleFinder.DTOs.VehicleDTO;

namespace VehicleFinder.DTOs.ListingDTO
{
    public class CreateListingDTO
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid price")]
        public float Price { get; set; }

        public bool IsSold { get; set; }

        public string UserId { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; }

        [Required]
        public CreateVehicleDTO Vehicle { get; set; }
    }
}
