using ContentLibrary.Core.Contracts;
using ContentLibrary.Data.Repositories;
using ContentLibrary.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContentLibrary.Core.Services
{
    public class EntityService : BaseService<Entity>, IEntityService
    {
        private IEntityRepository _respository;

        public EntityService(IEntityRepository repository) : base(repository)
        {
            _respository = repository;
        }

        public Task<List<Entity>> GetByTypeAsync(string type)
        {
            return _respository.GetEntityByType(type);
        }
    }

    public interface IEntityService : IBaseService<Entity>
    {
        Task<List<Entity>> GetByTypeAsync(string type);
    }
}
