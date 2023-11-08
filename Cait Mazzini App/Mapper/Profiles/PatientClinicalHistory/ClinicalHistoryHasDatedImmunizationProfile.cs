using AutoMapper;
using CaitMazziniApp.Api.ViewModels.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Mapper.Profiles.PatientClinicalHistory
{
    public class ClinicalHistoryHasDatedImmunizationProfile : Profile
    {
        public ClinicalHistoryHasDatedImmunizationProfile()
        {
            CreateMap<ClinicalHistoryHasDatedImmunization, ClinicalHistoryHasDatedImmunizationViewModel>();
        }
    }
}
