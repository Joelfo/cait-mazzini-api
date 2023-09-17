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
    public abstract class APIResourceController<TDto, TViewModel, TEntity, TRepository> : ControllerBase
        where TEntity : BaseModel
        where TDto : class
        where TRepository : IGenericRepository<TEntity, int>
    {
        protected readonly TRepository _repository;
        protected readonly IMapper _mapper;

        public APIResourceController(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Áll([FromQuery] int? skip, [FromQuery] int? take)
        {
            IList<TEntity> entities;
            entities = _repository.All(skip, take);
            var dtos = entities.Select(entity => _mapper.Map<TViewModel>(entity));
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Show(int id)
        {
            var entity = _repository.Find(id);
            if (entity != null)
            {
                var dto = _mapper.Map<TViewModel>(entity);
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
            _repository.Create(entity);
            return Ok(entity.Id);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromRoute] int id, [FromBody] TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = id;
            _repository.Update(entity);
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete([FromRoute] int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
