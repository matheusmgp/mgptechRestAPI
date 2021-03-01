using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    class FilialRepository : BaseRepository<Filial>, IFilialRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public FilialRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
