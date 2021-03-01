using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Service.Services
{
    public class FilialService : BaseService<Filial>, IFilialService
    {
        private readonly IFilialRepository _filialRepository;

        public FilialService(IFilialRepository filialRepository)
             : base(filialRepository)
        {
            _filialRepository = filialRepository;
        }
    }
}