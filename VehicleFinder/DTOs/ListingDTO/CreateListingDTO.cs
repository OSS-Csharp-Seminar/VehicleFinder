﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleFinder.DTOs.ListingDTO
{
    public class CreateListingDTO
    {
        [Required]
        [StringLength(40, ErrorMessage = "The title cannot exceed 40 characters.")]
        public string Title { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "The description cannot exceed 1000 characters.")]
        public string Description { get; set; }

        [Required]
        [RegularExpression(@"^\d{8,12}$", ErrorMessage = "Invalid phone number. It must be between 8 and 12 digits.")]
        public string ContactNumber { get; set; }


        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid price")]
        public float Price { get; set; }
        [Required]
        public bool IsSold { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;
        [Required]
        public DateTime CreationDate { get; set; }

        public string? VehicleId { get; set; } = Guid.NewGuid().ToString();
    }
}
