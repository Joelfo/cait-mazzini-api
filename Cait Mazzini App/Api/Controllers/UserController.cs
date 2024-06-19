using AutoMapper;
using CaitMazziniApp.Api.Annotations;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.Core;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Api.Controllers
{
    [AllowAnonymous]
    public class UserController : GenericRepositoryAPIController<UserDTO, UserViewModel, User>
    {
        public UserController(IGenericRepository<User, int> repository, IMapper mapper) : base(repository, mapper)
        {
        }

    }
}
