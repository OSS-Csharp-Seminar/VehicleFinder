using static System.Runtime.InteropServices.JavaScript.JSType;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using AutoMapper;

namespace VehicleFinder.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateVehicleDTO, Vehicle>();
        }
    }
}
