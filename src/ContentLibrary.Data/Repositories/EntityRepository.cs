using ContentLibrary.Data.Context;
using ContentLibrary.Data.Contracts;
using ContentLibrary.Domain.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ContentLibrary.Data.Repositories
{
    public class EntityRepository : BaseRepository<Entity>, IEntityRepository
    {
        public EntityRepository(ContentContext dbContext) : base(dbContext)
        {

        }

        public Task<List<Entity>> GetEntityByType(string type)
        {
            SqlParameter paramType = new SqlParameter("@contentType", type);
            return _context.Database.SqlQuery<Entity>("GetEntitiesByType @contentType", paramType).ToListAsync();            
        }
    }

    public interface IEntityRepository : IRepository<Entity>
    {
        Task<List<Entity>> GetEntityByType(string type);
    }
}
