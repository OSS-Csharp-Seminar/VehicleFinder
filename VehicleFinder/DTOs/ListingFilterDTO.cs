using VehicleFinder.Enums;

namespace VehicleFinder.DTOs
{
    public class ListingFilterDTO
    {
        public string Title { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public DateTime? CreationDate { get; set; }
        public int? YearMin { get; set; }
        public int? YearMax { get; set; }
        public float? PriceMin { get; set; }
        public float? PriceMax { get; set; }
        public bool? IsSold { get; set; }
        public string? FuelType { get; set; }
        public int? HorsepowerMin { get; set; }
        public int? HorsepowerMax { get; set; }
        public int? DoorCount { get; set; }
        public int? SeatCount { get; set; }
        public BodyShape? BodyShape { get; set; }
        public ACType? ACType { get; set; }
        public DrivetrainType? DrivetrainType { get; set; }
        public ShifterType? ShifterType { get; set; }
    }
}
