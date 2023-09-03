using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class PatientController : APIResourceController<PatientDTO, Patient>
    {
        public PatientController(IGenericRepository<Patient, int> genericRepository, IMapper mapper) : base(genericRepository, mapper) 
        {
        }
    }
}
