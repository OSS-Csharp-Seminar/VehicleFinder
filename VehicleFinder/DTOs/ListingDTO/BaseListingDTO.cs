namespace VehicleFinder.DTOs.ListingDTO
{
    public class BaseListingDTO
    {
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string UserId { get; set; }
        public int VehicleId { get; set; }
    }
}
