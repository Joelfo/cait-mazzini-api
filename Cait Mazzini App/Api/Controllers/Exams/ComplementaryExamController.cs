using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Exams;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Api.Controllers.Exams
{
    public abstract class ComplementaryExamController<TDto, TViewModel, TComplementaryExam> : APIResourceController<TDto, TViewModel, TComplementaryExam, IComplementaryExamRepository<TComplementaryExam>>
        where TComplementaryExam : ComplementaryExam, new()
        where TDto : class
        where TViewModel : class
    {
        public ComplementaryExamController(IComplementaryExamRepository<TComplementaryExam> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        [HttpGet("ByPatient/{patientId}")]
        public IActionResult GetAllByPatient(int patientId)
        {
            var entities = _repository.GetAllByPatient(patientId);
            var dtos = _mapper.Map<IList<TComplementaryExam>, List<TViewModel>>(entities);
            return Ok(dtos);
        }
    }
}
