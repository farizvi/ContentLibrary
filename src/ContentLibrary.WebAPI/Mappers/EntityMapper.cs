using ContentLibrary.Domain.Entities;
using ContentLibrary.WebAPI.Models;

namespace ContentLibrary.WebAPI.Mappers
{
    public static class EntityMapper
    {
        public static EntityModel ToEntityModel(Entity entity)
        {
            return new EntityModel()
            {
                EntityId = entity.Id,
                Type = entity.Type,
                Content = entity.Content,
                DateCreated = entity.Created
            };
            
        }
    }
}