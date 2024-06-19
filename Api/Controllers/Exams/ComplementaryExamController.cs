using AutoMapper;
using CaitMazziniApp.Api.Controllers.Generic;
using CaitMazziniApp.Api.DTOs.Exams;
using CaitMazziniApp.Api.Services;
using CaitMazziniApp.Api.ViewModels.Exams;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Exams;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Api.Controllers.Exams
{
    public abstract class ComplementaryExamController<TDto, TViewModel, TComplementaryExam> : APIResourceController<TDto, TViewModel, TComplementaryExam, IComplementaryExamRepository<TComplementaryExam>>
        where TComplementaryExam : ComplementaryExam, new()
        where TDto : ComplementaryExamDTO
        where TViewModel : ComplementaryExamViewModel
    {
        private readonly IConfiguration _configuration;
        public readonly FileService _fileService;

        public ComplementaryExamController(IComplementaryExamRepository<TComplementaryExam> repository, IMapper mapper, IConfiguration configuration, FileService fileService) : base(repository, mapper)
        {
            _configuration = configuration;
            _fileService = fileService;
        }

        [HttpGet("ByPatient/{patientId}")]
        public IActionResult GetAllByPatient(int patientId)
        {
            var entities = _repository.GetAllByPatient(patientId);
            var dtos = _mapper.Map<IList<TComplementaryExam>, List<TViewModel>>(entities);
            return Ok(dtos);
        }

        public async override Task<IActionResult> Create([FromForm] TDto dto)
        {
            var examData = _mapper.Map<TComplementaryExam>(dto);

            var files = Request.Form.Files;

            var filesDirectory = _configuration["EXAM_FILES_DIRECTORY"];

            if (filesDirectory == null)
            {
                throw new Exception("Exam files directory is not specified.");
            }

            foreach (var file in files)
            {
                var filePath = await _fileService.SaveEncryptedFile(filesDirectory, file);
                examData.ExamFiles.Add(new()
                {
                    ComplementaryExam = examData,
                    FilePath = filePath,
                    Name = file.FileName
                });
            }

            await _repository.Create(examData);

            return Ok(examData.Id);
        }

        public async override Task<IActionResult> Delete([FromRoute]int id)
        {
            var entity = await _repository.Find(id);
            
            if (entity == null)
            {
                return Ok();
            }

            foreach(var file in entity.ExamFiles)
            {
                _fileService.RemoveFile(file.FilePath);
            }

            await _repository.Delete(id);

            return Ok();
        }
    }
}
