using ContentLibrary.Data.Context;
using ContentLibrary.Data.Contracts;
using ContentLibrary.Domain.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace ContentLibrary.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected ContentContext _context;
        private IDbSet<T> _entities;

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }

        public BaseRepository(ContentContext dbContext)
        {
            _context = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return Entities;
        }

        public T GetById(int id)
        {
            return Entities.Find(id);
        }

        public void Create(T obj)
        {
            try
            {
                if (obj == null)
                    throw new Exception("Cannot insert null object");

                Entities.Add(obj);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T obj)
        {
            try
            {
                if (obj == null)
                    throw new Exception("Cannot update null object");

                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(T obj)
        {
            try
            {
                if (obj == null)
                    throw new Exception("Cannot delete null object");

                Entities.Remove(obj);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
