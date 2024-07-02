using System.ComponentModel.DataAnnotations;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;

namespace VehicleFinder.DTOs.BodyDTO
{
    public class UpdateGeneralListingDTO
    {
        [Required]
        public UpdateListingDTO Listing { get; set; } = new();

        [Required]
        public UpdateVehicleDTO Vehicle { get; set; } = new();

        [Required]
        public UpdateEngineDTO Engine { get; set; } = new();

        [Required]
        public UpdateBodyDTO Body { get; set; } = new();
    }
}
