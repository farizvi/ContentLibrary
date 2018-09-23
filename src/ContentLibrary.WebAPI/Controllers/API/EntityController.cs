using ContentLibrary.Core.Services;
using ContentLibrary.WebAPI.Mappers;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContentLibrary.WebAPI.Controllers.API
{
    [RoutePrefix("api/entities")]
    public class EntityController : ApiController
    {
        private IEntityService service;

        public EntityController(IEntityService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("{type}")]
        public async Task<IHttpActionResult> GetByType(string type)
        {
            var entities = await service.GetByTypeAsync(type);
            var entitiesModel = entities.Select(e => EntityMapper.ToEntityModel(e)).ToList();

            return Ok(entitiesModel);
        }
    }
}
