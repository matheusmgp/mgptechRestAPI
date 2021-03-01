using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Service.Services
{
    public class PendenciaService : BaseService<Pendencia>, IPendenciaService
    {
        private readonly IPendenciaRepository _pendenciaRepository;

        public PendenciaService(IPendenciaRepository pendenciaRepository)
             : base(pendenciaRepository)
        {
            _pendenciaRepository = pendenciaRepository;
        }
    }
}