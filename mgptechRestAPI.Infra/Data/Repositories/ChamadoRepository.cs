using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class ChamadoRepository : BaseRepository<Chamado>, IChamadoRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public ChamadoRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}