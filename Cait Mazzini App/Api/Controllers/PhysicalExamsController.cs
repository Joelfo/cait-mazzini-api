using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Api.Controllers
{
    public class PhysicalExamsController : APIResourceController<PhysicalExamDTO, PhysicalExamViewModel, PhysicalExam, IGenericRepository<PhysicalExam, int>>
    {
        public PhysicalExamsController(IGenericRepository<PhysicalExam, int> repository, IMapper mapper) : base(repository, mapper)
        { 
        }
    }
}
