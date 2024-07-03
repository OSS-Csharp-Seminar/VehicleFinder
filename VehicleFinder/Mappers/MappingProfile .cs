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
            CreateMap<UpdateVehicleDTO, Vehicle>();

            // Body mappings
            CreateMap<CreateBodyDTO, Body>();
            CreateMap<Body, GetBodyDTO>();
            CreateMap<UpdateBodyDTO, Body>();

            // Engine mappings
            CreateMap<CreateEngineDTO, Engine>();
            CreateMap<Engine, GetEngineDTO>();
            CreateMap<UpdateEngineDTO, Engine>();

            // Listing mappings
            CreateMap<Listing, GetListingDTO>()
                .ForMember(dest => dest.Vehicle, opt => opt.MapFrom(src => src.Vehicle));

            CreateMap<CreateListingDTO, Listing>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore Id for new listings

            CreateMap<UpdateListingDTO, Listing>()
                        .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.VehicleId));
        }
    }
}
