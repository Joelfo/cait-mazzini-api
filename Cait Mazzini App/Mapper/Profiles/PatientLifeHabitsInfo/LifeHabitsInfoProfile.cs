using AutoMapper;
using CaitMazziniApp.Api.DTOs.PatientLifeHabits;
using CaitMazziniApp.Api.ViewModels.PatientLifeHabits;
using CaitMazziniApp.Models.PatientLifeHabits;

namespace CaitMazziniApp.Mapper.Profiles.PatientLifeHabitsInfo
{
    public class LifeHabitsInfoProfile : Profile
    {
        public LifeHabitsInfoProfile()
        {
            CreateMap<LifeHabitsInfoDTO, LifeHabitsInfo>()
                .ForMember(entity => entity.PhysicalActivities, opt =>
                    opt.MapFrom(dto => dto.physicalActivityIds.Select(id => new PhysicalActivity { Id = id }))
                )
                .ForMember(entity => entity.ContraceptiveMethods, opt =>
                    opt.MapFrom(dto => dto.contraceptiveMethodIds.Select(id => new ContraceptiveMethod { Id = id }))
                ) ;
            CreateMap<LifeHabitsInfo, LifeHabitsInfoVIewModel>()
                .ForMember(viewModel => viewModel.physicalActivityIds, opt =>
                    opt.MapFrom(entity => entity.PhysicalActivities.Select(x => x.Id))
                )
                .ForMember(viewModel => viewModel.contraceptiveMethodIds, opt =>
                    opt.MapFrom(entity => entity.ContraceptiveMethods.Select(x => x.Id))
                );
        }
    }
}
