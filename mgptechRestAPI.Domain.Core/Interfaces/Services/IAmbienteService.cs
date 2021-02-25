using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Core.Interfaces.Services
{
    public interface IAmbienteService : IBaseService<Ambiente>
    {
        Task<IEnumerable<Ambiente>> GetAllAmbienteByNameAsync(string name);
        Task<IEnumerable<Ambiente>> FindAllIncludedAsync();
    }
}