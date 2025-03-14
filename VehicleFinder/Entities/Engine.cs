﻿using System.ComponentModel.DataAnnotations;
using VehicleFinder.Entities.BaseEntity;
using VehicleFinder.Enums;

namespace VehicleFinder.Entities
{
    public class Engine : BEntity
    {
        public string Name { get; set; } = string.Empty;
        public FuelType FuelType { get; set; }
        public int Horsepower { get; set; }
        public int EngineCapacity { get; set; }
    }
}