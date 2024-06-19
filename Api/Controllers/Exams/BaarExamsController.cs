using AutoMapper;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.Services;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Api.Controllers.Exams
{
    public class BaarExamsController : ComplementaryExamController<BaarExamDTO, BaarExamViewModel, BaarExam> 
    {
        public BaarExamsController(IComplementaryExamRepository<BaarExam> repository, IMapper mapper, IConfiguration config, FileService fileService) : base(repository, mapper, config, fileService)
        {
            
        }
    }
}
