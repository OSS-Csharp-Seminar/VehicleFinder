namespace VehicleFinder.DTOs.ListingDTO
{
    public class GetListingDTO
    {
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool IsSold { get; set; }
        public int UserId { get; set; }
        public int VehicleId { get; set; }
    }
}
