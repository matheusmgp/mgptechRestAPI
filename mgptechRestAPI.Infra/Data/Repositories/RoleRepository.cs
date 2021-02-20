using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class RoleRepository : BaseRepository<Role> , IRoleRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public RoleRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
       
    }
}
