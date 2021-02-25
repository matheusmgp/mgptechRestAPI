using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class AmbienteRepository : BaseRepository<Ambiente>, IAmbienteRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public AmbienteRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
            _sqlServerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<IEnumerable<Ambiente>> FindAllIncludedAsync()
        {
            IQueryable<Ambiente> query = _sqlServerContext.Ambientes
                                         .OrderBy(n => n.NomeFantasia)
                                         .Include(r => r.Roles)
                                         .Include(u => u.Users);

            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable<Ambiente>> GetAllAmbienteByNameAsync(string name)
        {
            IQueryable<Ambiente> query = _sqlServerContext.Ambientes
                                         .OrderBy(n => n.NomeFantasia)
                                         .Include(r => r.Roles)
                                         .Include(u => u.Users)
                                         .Where(n => n.NomeFantasia.Contains(name));

            return await query.ToArrayAsync();


        }
    }
}