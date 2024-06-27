namespace VehicleFinder.DTOs.ListingDTO
{
    public class GetListingDTO : BaseListingDTO
    {
        public int Id { get; set; }
        public bool IsSold { get; set; }
    }
}
