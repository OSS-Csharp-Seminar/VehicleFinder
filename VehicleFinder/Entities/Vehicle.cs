﻿using System.ComponentModel.DataAnnotations.Schema;
using VehicleFinder.Entities.BaseEntity;
using VehicleFinder.Enums;

namespace VehicleFinder.Entities
{
    public class Vehicle : BEntity
    {
        public CarManufacturer Brand { get; set; }
        public string Model { get; set; } = string.Empty;
        public int ManufacturingYear { get; set; }
        public DateOnly RegistrationUntil { get; set; }
        public int Kilometers { get; set; }
        public int NumberOfPreviousOwners { get; set; }
        public ShifterType ShifterType { get; set; }
        public int GearCount { get; set; }
        public double AverageConsumption { get; set; }
        public string EngineId { get; set; }
        public Engine? Engine { get; set; }
        public string BodyId { get; set; }
        public Body? Body { get; set; }

    }
}
