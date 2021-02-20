using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Services.Services
{
    public class AmbienteService : BaseService<Ambiente>, IAmbienteService
    {
        private readonly IAmbienteRepository _ambienteRepository;

        public AmbienteService(IAmbienteRepository ambienteRepository) : base(ambienteRepository)
        {
            _ambienteRepository = ambienteRepository;
        }
    }
}