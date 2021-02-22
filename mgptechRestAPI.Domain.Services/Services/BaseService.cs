using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Services.Services
{
    public class BaseService<Entity> : IBaseService<Entity> where Entity : class
    {
        private readonly IBaseRepository<Entity> _repository;

        public BaseService(IBaseRepository<Entity> repository)
        {
            _repository = repository;
        }

        public  Task<bool> Create(Entity entity)
        {
            return _repository.Create(entity);
        }

        public async Task<IEnumerable<Entity>> FindAllAsync()
        {
            return await _repository.FindAllAsync();
        }

        public async Task<Entity> FindByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public bool SaveChanges()
        {
            var istrue =  _repository.SaveChanges();
            return istrue;
        }

        public Task<bool> Update(int id, Entity entity)
        {
            return _repository.Update(id, entity);
        }
    }
}