using AutoMapper;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.DTOs;
using Cait_Mazzini_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cait_Mazzini_App.Controllers
{
    public class PatientExamController : APIResourceController<PatientExamDTO, PatientExam>
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
                return new BadRequestResult();
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

            _genericRepository.Create(entity);

            return new CreatedResult("", null);
        }
    }
}
