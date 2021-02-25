using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Core.Interfaces.Repositories
{
    public interface IAmbienteRepository : IBaseRepository<Ambiente>
    {
        Task<IEnumerable<Ambiente>> GetAllAmbienteByNameAsync(string name);
        Task<IEnumerable<Ambiente>> FindAllIncludedAsync();
    }
}