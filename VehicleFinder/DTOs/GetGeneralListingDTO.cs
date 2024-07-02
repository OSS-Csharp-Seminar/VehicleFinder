using System.ComponentModel.DataAnnotations;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;

namespace VehicleFinder.DTOs
{
    public class GetGeneralListingDTO
    {
        [Required]
        public GetListingDTO Listing { get; set; } = new();

        [Required]
        public GetVehicleDTO Vehicle { get; set; } = new();

        [Required]
        public GetEngineDTO Engine { get; set; } = new();

        [Required]
        public GetBodyDTO Body { get; set; } = new();
    }
}
