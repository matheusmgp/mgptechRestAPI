using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public  class UserRepository : BaseRepository<User> , IUserRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public UserRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

      
    }
}
