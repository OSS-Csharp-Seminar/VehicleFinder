using VehicleFinder.DTOs.VehicleDTO;

namespace VehicleFinder.DTOs.ListingDTO
{
    public class GetListingDTO
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Guid UserId { get; set; }
        public bool IsSold { get; set; }
        public GetVehicleDTO Vehicle { get; set; }
    }
}
