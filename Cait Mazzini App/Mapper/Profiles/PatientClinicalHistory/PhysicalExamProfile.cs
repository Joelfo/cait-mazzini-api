using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Mapper.Profiles.PatientClinicalHistory
{
    public class PhysicalExamProfile : Profile
    {
        public PhysicalExamProfile()
        {
            CreateMap<PhysicalExam, PhysicalExamViewModel>();
            CreateMap<PhysicalExamDTO, PhysicalExam>();
        }
    }
}
