using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class CanalComunicacaoRepository : BaseRepository<CanalComunicacao>, ICanalComunicacaoRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public CanalComunicacaoRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
