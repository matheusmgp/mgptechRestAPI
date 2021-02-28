using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    internal class SubCategoriaRepository : BaseRepository<SubCategoria>, ISubCategoriaRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public SubCategoriaRepository(SqlServerContext sqlServerContext)
                : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
            _sqlServerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}