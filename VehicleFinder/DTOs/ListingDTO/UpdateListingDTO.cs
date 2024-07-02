using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleFinder.DTOs.ListingDTO
{
    public class UpdateListingDTO
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public float Price { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsSold { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int VehicleId { get; set; }
    }
}
