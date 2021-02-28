using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public CategoriaRepository(SqlServerContext sqlServerContext)
                : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
            _sqlServerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}