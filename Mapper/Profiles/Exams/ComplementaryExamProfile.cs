using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class ComplementaryExamProfile : Profile
    {
        public ComplementaryExamProfile()
        {
            CreateMap<ComplementaryExam, ComplementaryExamViewModel>()
                .ForMember(viewModel => viewModel.patientId, opt => opt.MapFrom(model => model.Patient.Id))
                .IncludeAllDerived();
            CreateMap<ComplementaryExamDTO, ComplementaryExam>()
                .ForMember(model => model.Patient, opt => opt.MapFrom(dto => new Patient { Id = dto.patientId }))
                .ForMember(model => model.Date, opt => opt.MapFrom(dto => DateOnly.Parse(dto.date)))
                .IncludeAllDerived();
        }
    }
}
