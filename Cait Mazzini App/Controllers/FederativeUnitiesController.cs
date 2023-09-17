using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cait_Mazzini_App.Controllers
{
    public class FederativeUnitiesController : APIResourceController<FederativeUnityDTO, FederativeUnityViewModel, FederativeUnity, IFederativeUnityRepository>
    {

        public FederativeUnitiesController(IFederativeUnityRepository federativeUnityRepository, IMapper mapper) : base(federativeUnityRepository, mapper)
        {
        }

        [HttpGet("~/Countries/{countryId}/FederativeUnities")]
        public async Task<IActionResult> AllByCountry([FromRoute] int countryId)
        {
            var entities = _repository.AllByCountry(countryId);
            var dtos = _mapper.Map<IList<FederativeUnity>, IList<FederativeUnityDTO>>(entities);
            return Ok(dtos);
        }
    }
}
