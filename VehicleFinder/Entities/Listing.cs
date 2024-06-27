using VehicleFinder.Entities.BaseEntity;

namespace VehicleFinder.Entities
{
    public class Listing : BEntity
    {
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool IsSold { get; set; }
        public string UserId { get; set; }
        public User? User { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
