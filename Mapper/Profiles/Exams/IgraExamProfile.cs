using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class IgraExamProfile : Profile
    {
        public IgraExamProfile()
        {
            CreateMap<IgraExam, IgraExamViewModel>();
            CreateMap<IgraExamDTO, IgraExam>();
        }
    }
}
