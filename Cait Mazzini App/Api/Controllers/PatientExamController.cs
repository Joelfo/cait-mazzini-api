using AutoMapper;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.DTOs;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Core;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Controllers
{
    public class PatientExamController : APIResourceController<PatientExamDTO, PatientExamDTO, PatientExam, IGenericRepository<PatientExam, int>>
    {
        private readonly IConfiguration _configuration;
        public PatientExamController(IGenericRepository<PatientExam, int> genericRepository, IMapper mapper, IConfiguration configuration) : base(genericRepository, mapper)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public override async Task<IActionResult> Create(PatientExamDTO dto)
        {
            if (dto.examFile.Length == 0)
            {
                return BadRequest("An empty file has been provided");
            }
            
            var filePath = Path.Combine(_configuration["StoredExamFilesPath"], Path.GetRandomFileName());
                
            using (var stream = System.IO.File.Create(filePath))
            {
                await dto.examFile.CopyToAsync(stream);
                stream.Close();
            }

            var entity = new PatientExam()
            {
                Date = dto.date,
                FilePath = filePath,
                Patient = new Patient()
                {
                    Id = dto.patientId
                }
            };

            _repository.Create(entity);

            return Created("", null);
        }
    }
}
