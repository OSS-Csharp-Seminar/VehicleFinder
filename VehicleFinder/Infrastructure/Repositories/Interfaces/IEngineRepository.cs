using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IEngineRepository
    {
        Task<IEnumerable<Engine>> GetAllEnginesAsync();
        Task<Engine> GetEngineByIdAsync(string Id);
        Task<string> CreateEngineAsync(Engine model);
        Task UpdateEngineAsync(Engine engine);
        public bool EngineExists(string id);
    }
}
