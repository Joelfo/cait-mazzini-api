using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Mapper.Profiles.PatientClinicalHistory
{
    public class DatedImmunizationProfile : Profile
    {
        public DatedImmunizationProfile()
        {
            CreateMap<DatedImmunization, DatedImmunizationViewModel>();
            CreateMap<DatedImmunizationDTO, DatedImmunization>();
        }
    }
}
