using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Cait_Mazzini_App.Controllers
{
    public class PatientsController : APIResourceController<PatientDTO, PatientViewModel, Patient, IPatientRepository>
    {
        public PatientsController(IPatientRepository repository, IMapper mapper) : base(repository, mapper) 
        {
        }

        [HttpGet("ByName")]
        public async Task<IActionResult> AllByName(string name)
        {
            var entities = _repository.AllByName(name);
            var dtos = _mapper.Map<IList<Patient>, IList<PatientDTO>>(entities);
            return Ok(dtos);
        }
    }
}
