using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Service.Services
{
    public class SubCategoriaService : BaseService<SubCategoria>, ISubCategoriaService
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;

        public SubCategoriaService(ISubCategoriaRepository subCategoriaRepository) :
            base(subCategoriaRepository)
        {
            _subCategoriaRepository = subCategoriaRepository;
        }
    }
}