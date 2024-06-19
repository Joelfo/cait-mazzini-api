using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.Services;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Mapper.Profiles.Exams;

namespace CaitMazziniApp.Api.Controllers.Exams
{
    public class OtherExamsController : ComplementaryExamController<OtherExamDTO, OtherExamViewModel, OtherExam>
    {
        public OtherExamsController(IComplementaryExamRepository<OtherExam> repository, IMapper mapper, IConfiguration config, FileService fileService) : base(repository, mapper, config, fileService)
        {
            
        }
    }
}
