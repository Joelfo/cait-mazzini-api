using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.Services;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Api.Controllers.Exams
{
    public class ToraxXRayExamsController : ComplementaryExamController<ToraxXRayExamDTO, ToraxXRayExamViewModel, ToraxXRayExam>
    {
        public ToraxXRayExamsController(IComplementaryExamRepository<ToraxXRayExam> repository, IMapper mapper, IConfiguration configuration, FileService fileService) : base(repository, mapper, configuration, fileService)
        {
            
        }
    }
}
