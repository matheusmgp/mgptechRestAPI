using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class ProcedimentoRepository : BaseRepository<Procedimento>, IProcedimentoRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public ProcedimentoRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}