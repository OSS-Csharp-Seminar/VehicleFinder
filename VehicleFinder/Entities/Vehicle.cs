using VehicleFinder.Entities.BaseEntity;

namespace VehicleFinder.Entities
{
    public class Vehicle : BEntity
    {
        //placeholder values
        public string Brand { get; set; }
        public string Model { get; set; }
        public Listing Listing { get; set; }
        
    }
}
