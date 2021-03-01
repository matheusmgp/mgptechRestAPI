using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class PendenciaRepository : BaseRepository<Pendencia>, IPendenciaRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public PendenciaRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}