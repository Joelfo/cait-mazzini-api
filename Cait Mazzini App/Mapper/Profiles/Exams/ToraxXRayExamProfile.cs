using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class ToraxXRayExamProfile : Profile
    {
        public ToraxXRayExamProfile()
        {
            CreateMap<ToraxXRayExam, ToraxXRayExamViewModel>();
            CreateMap<ToraxXRayExamDTO, ToraxXRayExam>();
        }
    }
}
