using VehicleFinder.Entities.BaseEntity;

namespace VehicleFinder.Entities
{
    public class User : BEntity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public List<Listing>? Listings { get; set; }
    }
}
