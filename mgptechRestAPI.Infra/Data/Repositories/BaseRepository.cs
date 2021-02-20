using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data.Repositories
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        private readonly SqlServerContext _sqlServerContext;

        public BaseRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Create(Entity entity)
        {
            try
            {
                _sqlServerContext.Set<Entity>().Add(entity);
                _sqlServerContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<IEnumerable<Entity>> FindAllAsync()
        {
            IQueryable<Entity> query = _sqlServerContext.Set<Entity>();

            query = query.AsNoTracking();

            return await query.ToArrayAsync();
        }

        public async Task<Entity> FindByIdAsync(int id)
        {
            return await _sqlServerContext.Set<Entity>().FindAsync(id);
        }

        public bool SaveChanges()
        {
            return (_sqlServerContext.SaveChanges() > 0);
        }

        public void Update(int id, Entity entity)
        {
            try
            {
                _sqlServerContext.Entry(entity).State = EntityState.Modified;
                _sqlServerContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}