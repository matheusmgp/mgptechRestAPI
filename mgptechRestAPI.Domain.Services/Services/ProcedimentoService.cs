using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Service.Services
{
    public  class ProcedimentoService : BaseService<Procedimento>, IProcedimentoService
    {
        private readonly IProcedimentoRepository _procedimentoRepository;

        public ProcedimentoService(IProcedimentoRepository procedimentoRepository)
                : base(procedimentoRepository)
        {
            _procedimentoRepository = procedimentoRepository;
        }
    }
}