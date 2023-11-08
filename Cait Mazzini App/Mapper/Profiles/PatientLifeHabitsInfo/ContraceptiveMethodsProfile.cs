using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientClinicalHistory;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Models.PatientLifeHabits;

namespace CaitMazziniApp.Mapper.Profiles.PatientLifeHabitsInfo
{
    public class ContraceptiveMethodsProfile : Profile
    {
        public ContraceptiveMethodsProfile()
        {
            CreateMap<ContraceptiveMethodDTO, ContraceptiveMethod>();
            CreateMap<ContraceptiveMethod, ContraceptiveMethodViewModel>();
        }
    }
}
