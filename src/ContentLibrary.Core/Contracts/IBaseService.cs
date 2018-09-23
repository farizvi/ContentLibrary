using ContentLibrary.Domain.Entities;
using System.Collections.Generic;

namespace ContentLibrary.Core.Contracts
{
    public interface IBaseService<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
