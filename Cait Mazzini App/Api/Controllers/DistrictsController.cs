using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Controllers
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
            var entities = await _districtRepository.GetAllByCity(cityId);
            var dtos = entities.Select(entity => _mapper.Map<DistrictViewModel>(entity));
            return Ok(dtos);
        }
    }
}
