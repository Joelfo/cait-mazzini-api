using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Microsoft.AspNetCore.Components;

namespace Cait_Mazzini_App.Controllers
{
    [Route("[controller]")]
    public class VitalSignsMeasurementController : APIResourceController<VitalSignsMeasurementDTO, VitalSignsMeasurement>
    {
        public VitalSignsMeasurementController (IGenericRepository<VitalSignsMeasurement, int> repository, IMapper mapper) 
            : base(repository, mapper) 
        { 
        }

    }
}
