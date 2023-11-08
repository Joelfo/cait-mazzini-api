using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Controllers;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Api.Controllers
{
    public class DatedImmunizationsController : APIResourceController<DatedImmunizationDTO, DatedImmunizationViewModel, DatedImmunization, IGenericRepository<DatedImmunization, int>>
    {
        public DatedImmunizationsController(IGenericRepository<DatedImmunization, int> repository, IMapper mapper) : base(repository, mapper) { }
     }
}
