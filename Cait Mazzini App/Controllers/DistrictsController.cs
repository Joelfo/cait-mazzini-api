using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Cait_Mazzini_App.Controllers
{
    public class DistrictsController : APIResourceController<DistrictDTO, DistrictViewModel, District, IDistrictRepository>
    {
        private readonly IDistrictRepository _districtRepository;
        public DistrictsController(IDistrictRepository districtRepository, IMapper mapper) : base(districtRepository, mapper) 
        {
            _districtRepository = districtRepository;
        }

        [HttpGet("/Cities/{cityId}/Districts")]
        public async Task<IActionResult> AllByCity([FromRoute]int cityId)
        {
            var entities = _districtRepository.GetAllByCity(cityId);
            var dtos = entities.Select(entity => _mapper.Map<DistrictDTO>(entity));
            return Ok(dtos);
        }
    }
}
