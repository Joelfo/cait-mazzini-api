using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class OtherExamProfile : Profile
    {
        public OtherExamProfile()
        {
            CreateMap<OtherExamDTO, OtherExam>();
            CreateMap<OtherExam, OtherExamViewModel>();
        }
    }
}
