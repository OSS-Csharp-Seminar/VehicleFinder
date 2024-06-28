using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IEngineRepository
    {
        Task<IEnumerable<Engine>> GetAllEnginesAsync();
        Task<Engine> GetEngineByIdAsync(int Id);
        Task<int> CreateEngineAsync(Engine model);
    }
}
