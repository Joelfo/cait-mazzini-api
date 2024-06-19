using AutoMapper;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Base;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Api.Controllers.Generic
{
    public class GenericRepositoryAPIController<TDto, TViewModel, TEntity> : APIResourceController<TDto, TViewModel, TEntity, IGenericRepository<TEntity, int>>
        where TEntity : class, IId, new()
        where TDto : class
        where TViewModel : class
    {
        public GenericRepositoryAPIController(IGenericRepository<TEntity, int> repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
