using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Controllers
{
    public class FederativeUnitiesController : APIResourceController<FederativeUnityDTO, FederativeUnityViewModel, FederativeUnity, IFederativeUnityRepository>
    {

        public FederativeUnitiesController(IFederativeUnityRepository federativeUnityRepository, IMapper mapper) : base(federativeUnityRepository, mapper)
        {
        }

        [HttpGet("~/Countries/{countryId}/FederativeUnities")]
        public async Task<IActionResult> AllByCountry([FromRoute] int countryId)
        {
            var entities = (await _repository.AllByCountry(countryId)).ToList();
            var dtos = _mapper.Map<List<FederativeUnity>, List<FederativeUnityViewModel>>(entities);
            return Ok(dtos);
        }
    }
}
