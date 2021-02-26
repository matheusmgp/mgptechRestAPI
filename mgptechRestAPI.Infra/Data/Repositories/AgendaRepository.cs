using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public AgendaRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
