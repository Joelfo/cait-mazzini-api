using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class BiopsyExamProfile : Profile
    {
        public BiopsyExamProfile()
        {
            CreateMap<BiopsyExam, BiopsyExamViewModel>();
            CreateMap<BiopsyExamDTO, BiopsyExam>();
        }
    }
}
