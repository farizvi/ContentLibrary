using ContentLibrary.Domain.Entities;
using System.Linq;

namespace ContentLibrary.Data.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        
        T GetById(int id);
        
        void Create(T obj);
        
        void Update(T obj);

        void Delete(T obj);
    }
}
