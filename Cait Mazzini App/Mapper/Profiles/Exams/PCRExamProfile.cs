using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class PCRExamProfile : Profile
    {
        public PCRExamProfile()
        {
            CreateMap<PCRExam, PCRExamViewModel>();
            CreateMap<PCRExamDTO, PCRExam>();
        }
    }
}
