using VehicleFinder.Entities.BaseEntity;

namespace VehicleFinder.Entities
{
    public class Vehicle : BEntity
    {
        //placeholder values
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int ManufacturingYear { get; set; }
        public DateOnly RegistrationUntil { get; set; }
        public int Kilometers { get; set; }
        public int NumberOfPreviousOwners { get; set; }
        public Listing Listing { get; set; }
        
        //missing Engine
        
        //missing Body
        
    }
}
