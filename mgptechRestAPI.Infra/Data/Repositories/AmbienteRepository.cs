using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class AmbienteRepository : BaseRepository<Ambiente> , IAmbienteRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public AmbienteRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
       
    }
}
