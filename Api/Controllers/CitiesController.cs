﻿using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Controllers
{
    [Route("[controller]")]
    public class CitiesController : APIResourceController<CityDTO, CityViewModel, City, IGenericRepository<City, int>>
    {
        public CitiesController(IGenericRepository<City, int> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        { 
        }
    }
}
