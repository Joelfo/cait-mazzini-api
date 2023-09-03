using AutoMapper;
using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Models.Base;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace Cait_Mazzini_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class APIResourceController<TDto, TEntity> : ControllerBase
        where TEntity : BaseModel
        where TDto : class
    {
        protected readonly IGenericRepository<TEntity, int> _genericRepository;
        protected readonly IMapper _mapper;

        public APIResourceController(IGenericRepository<TEntity, int> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetÁll([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            var entities = _genericRepository.All(skip, take);
            var dtos = entities.Select(entity => _mapper.Map<TDto>(entity));
            return new OkObjectResult(dtos);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(int id)
        {
            var entity = _genericRepository.Find(id);
            if (entity != null)
            {
                var dto = _mapper.Map<TDto>(entity);
                return new OkObjectResult(dto);
            }
            else
            {
                return new NotFoundResult();
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _genericRepository.Create(entity);
            return new CreatedResult("", null);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromRoute] int id, [FromBody] TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = id;
            _genericRepository.Update(entity);
            return new OkResult();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete([FromRoute] int id)
        {
            _genericRepository.Delete(id);
            return new OkResult();
        }
    }
}
