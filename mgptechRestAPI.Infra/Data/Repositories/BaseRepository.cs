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
            var istrue =  (_sqlServerContext.SaveChanges() > 0);
            return istrue;
        }

        public async Task<bool> Update(int id, Entity entity) 
        {            
            try
            {
                var teste = _sqlServerContext.Entry(entity).State = EntityState.Modified;
                var updated =   _sqlServerContext.SaveChanges();
                return updated > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<bool> Create(Entity entity)
        {
            try
            {
                _sqlServerContext.Set<Entity>().Add(entity);
                var created = await _sqlServerContext.SaveChangesAsync();
                return created > 0;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    


}