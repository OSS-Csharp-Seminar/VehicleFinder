using System.ComponentModel.DataAnnotations;
using VehicleFinder.Entities.BaseEntity;
using VehicleFinder.Enums;

namespace VehicleFinder.Entities
{
    public class Engine : BEntity
    {
        public string Name { get; set; } = string.Empty;

        // Store FuelType as string in the database
        public string FuelTypeString { get; set; }

        // Enum property using FuelTypeString for persistence
        [EnumDataType(typeof(FuelType))]
        public FuelType FuelType
        {
            get { return Enum.Parse<FuelType>(FuelTypeString); }
            set { FuelTypeString = value.ToString(); }
        }
        public int Horsepower { get; set; }
        public int EngineCapacity { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}