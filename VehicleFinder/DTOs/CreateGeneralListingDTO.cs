using System.ComponentModel.DataAnnotations;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.BodyDTO;

namespace VehicleFinder.DTOs.General
{
    public class CreateGeneralListingDTO
    {
        [Required]
        public CreateListingDTO Listing { get; set; }

        [Required]
        public CreateVehicleDTO Vehicle { get; set; }

        [Required]
        public CreateEngineDTO Engine { get; set; }

        [Required]
        public CreateBodyDTO Body { get; set; }
    }
}
