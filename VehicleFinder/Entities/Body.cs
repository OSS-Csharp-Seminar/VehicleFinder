using VehicleFinder.Entities.BaseEntity;
using VehicleFinder.Enums;

namespace VehicleFinder.Entities
{
    public class Body : BEntity
    {
        public int DoorCount { get; set; }
        public int SeatCount { get; set; }
        public ACType ACType { get; set; }
        public string Color { get; set; } = string.Empty;
        public BodyShape BodyShape { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
