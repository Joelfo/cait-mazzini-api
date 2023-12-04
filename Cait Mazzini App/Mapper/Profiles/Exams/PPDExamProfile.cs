using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class PPDExamProfile : Profile
    {
        public PPDExamProfile()
        {
            CreateMap<PPDExam, PPDExamViewModel>();
            CreateMap<PPDExamDTO, PPDExam>();
        }
    }
}
