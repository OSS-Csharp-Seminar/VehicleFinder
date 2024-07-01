using static System.Runtime.InteropServices.JavaScript.JSType;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using AutoMapper;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.ListingDTO;

namespace VehicleFinder.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Vehicle mappings
            CreateMap<CreateVehicleDTO, Vehicle>();
            CreateMap<Vehicle, GetVehicleDTO>()
                .ForMember(dest => dest.Engine, opt => opt.MapFrom(src => src.Engine))
                .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body));

            // Body mappings
            CreateMap<CreateBodyDTO, Body>();
            CreateMap<Body, GetBodyDTO>();

            // Engine mappings
            CreateMap<CreateEngineDTO, Engine>();
            CreateMap<Engine, GetEngineDTO>();

            // Listing mappings
            CreateMap<Listing, GetListingDTO>()
                .ForMember(dest => dest.Vehicle, opt => opt.MapFrom(src => src.Vehicle));

            CreateMap<CreateListingDTO, Listing>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore Id for new listings
        }
    }
}
