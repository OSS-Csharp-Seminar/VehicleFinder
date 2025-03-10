﻿using VehicleFinder.DTOs.VehicleDTO;

namespace VehicleFinder.DTOs.ListingDTO
{
    public class GetListingDTO
    {
        public string Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactNumber { get; set; }
        public float Price { get; set; }
        public string UserId { get; set; }
        public bool IsSold { get; set; }
        public GetVehicleDTO Vehicle { get; set; }
    }
}
