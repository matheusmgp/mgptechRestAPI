using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Core.Interfaces.Services
{
    public interface IBaseService<Entity> where Entity : class
    {
        Task<IEnumerable<Entity>> FindAllAsync();

        Task<Entity> FindByIdAsync(int id);

        void Create(Entity entity);

        void Update(int id, Entity entity);

        bool SaveChanges();
    }
}