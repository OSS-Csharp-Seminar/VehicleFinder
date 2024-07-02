using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;

namespace VehicleFinder.DTOs.VehicleDTO
{
    public class GetVehicleDTO : CreateVehicleDTO
    {
        public string Id { get; set; }
        public GetEngineDTO Engine { get; set; }
        public GetBodyDTO Body { get; set; }
    }
}
