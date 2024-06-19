using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class BaarExamProfile : Profile
    {
        public BaarExamProfile()
        {
            CreateMap<BaarExam, BaarExamViewModel>();
            CreateMap<BaarExamDTO, BaarExam>();
        }
    }
}
