using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Mapper.Profiles.PatientClinicalHistory
{
    public class ClinicalHistoryProfile : Profile
    {
        public ClinicalHistoryProfile()
        {
            CreateMap<ClinicalHistoryDTO, ClinicalHistory>()
                .ForMember(
                    entity => entity.PreviousDeseases,
                    opt => opt.MapFrom(dto => dto.previousDeseaseIds.Select(id => new Desease { Id = id }))
                 )
                .ForMember(
                    entity => entity.ClinicalHistoryHasDatedImmunizations,
                    opt => opt.MapFrom(dto => dto.datedImmunizationIds.Select(x => new ClinicalHistoryHasDatedImmunization { DatedImmunizationId = x.ImmunizationId, LastDoseDate = x.LastDoseDate }))
                )
                .ForMember(
                    entity => entity.Immunizations,
                    opt => opt.MapFrom(dto => dto.immunizationIds.Select(id => new Immunization { Id = id }))
                );
            CreateMap<ClinicalHistory, ClinicalHistoryViewModel>();
        }
    }
}
