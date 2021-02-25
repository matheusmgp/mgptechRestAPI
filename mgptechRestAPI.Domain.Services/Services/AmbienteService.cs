using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Services.Services
{
    public class AmbienteService : BaseService<Ambiente>, IAmbienteService
    {
        private readonly IAmbienteRepository _ambienteRepository;

        public AmbienteService(IAmbienteRepository ambienteRepository) : base(ambienteRepository)
        {
            _ambienteRepository = ambienteRepository;
        }

        public Task<IEnumerable<Ambiente>> FindAllIncludedAsync()
        {
            return _ambienteRepository.FindAllIncludedAsync();
        }

        public Task<IEnumerable<Ambiente>> GetAllAmbienteByNameAsync(string name)
        {
            return _ambienteRepository.GetAllAmbienteByNameAsync(name);
        }
    }
}