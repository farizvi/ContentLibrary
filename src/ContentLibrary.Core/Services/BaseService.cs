using ContentLibrary.Core.Contracts;
using ContentLibrary.Data.Contracts;
using ContentLibrary.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ContentLibrary.Core.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IRepository<T> repository;

        public BaseService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public List<T> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public T GetById(int id)
        {
            return repository.GetAll().Where(r => r.Id.Equals(id)).FirstOrDefault();
        }

        public void Create(T obj)
        {
            repository.Create(obj);
        }

        public void Update(T obj)
        {
            repository.Update(obj);
        }

        public void Delete(T obj)
        {
            repository.Delete(obj);
        }
    }
}
