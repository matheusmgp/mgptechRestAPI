using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    class SetorRepository : BaseRepository<Setor> , ISetorRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public SetorRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
