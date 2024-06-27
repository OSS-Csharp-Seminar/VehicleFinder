using Microsoft.AspNetCore.Identity;
using VehicleFinder.Entities.BaseEntity;

namespace VehicleFinder.Entities
{
    public class User : IdentityUser
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string FirstName{ get; set; }

        public string LasttName{ get; set; }
        public List<Listing>? Listings { get; set; }
    }
}
