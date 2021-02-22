using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Task<IEnumerable<Entity>> FindAllAsync();

        Task<Entity> FindByIdAsync(int id);

        Task<bool> Create(Entity entity);

        Task<bool> Update(int id, Entity entity);

        bool SaveChanges();
    }
}