using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientLifeHabits;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Models.PatientLifeHabits;

namespace CaitMazziniApp.Mapper.Profiles.PatientLifeHabitsInfo
{
    public class PhysicalActivityProfile : Profile
    {
        public PhysicalActivityProfile()
        {
            CreateMap<PhysicalActivity, PhysicalActivityViewModel>();
            CreateMap<PhysicalActivityDTO, PhysicalActivity>();
        }
    }
}
