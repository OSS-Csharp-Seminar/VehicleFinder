using VehicleFinder.Entities.BaseEntity;
using VehicleFinder.Enums;

namespace VehicleFinder.Entities
{
    public class Vehicle : BEntity
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int ManufacturingYear { get; set; }
        public DateOnly RegistrationUntil { get; set; }
        public int Kilometers { get; set; }
        public int NumberOfPreviousOwners { get; set; }
        public ShifterType ShifterType { get; set; }
        public int GearCount { get; set; }
        public decimal AverageConsumption { get; set; }
        public Listing Listing { get; set; }
        public Guid EngineId { get; set; }
        public Engine? Engine { get; set; }
        public Guid BodyId { get; set; }
        public Body? Body { get; set; }

    }
}
