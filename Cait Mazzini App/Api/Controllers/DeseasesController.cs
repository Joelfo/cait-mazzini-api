using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Controllers;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Api.Controllers
{
    public class DeseasesController : APIResourceController<DeseaseDTO, DeseaseViewModel, Desease, IGenericRepository<Desease, int>>
    {
        public DeseasesController(IGenericRepository<Desease, int> repository, IMapper mapper) : base(repository, mapper) { }

    }
}
