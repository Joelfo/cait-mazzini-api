using AutoMapper;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Mapper.Profiles.Exams
{
    public class ExamFileProfile : Profile
    {
        public ExamFileProfile()
        {
            CreateMap<ExamFileMetadata, ExamFileViewModel>();
        }
    }
}
