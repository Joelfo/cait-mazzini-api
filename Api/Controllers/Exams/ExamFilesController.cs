using CaitMazziniApp.Api.Services;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Exams;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CaitMazziniApp.Api.Controllers.Exams
{
    public class ExamFilesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IGenericRepository<ExamFileMetadata, int> _repository;
        private readonly FileService _fileService;

        public ExamFilesController(IConfiguration configuration, IGenericRepository<ExamFileMetadata, int> repository,
            FileService fileService)
        {
            _configuration = configuration;
            _repository = repository;
            _fileService = fileService;
        }

        [HttpGet("EncryptionKey")]
        public async Task<IActionResult> GetNewEncryptionKey()
        {
            var key = new byte[32];
            RandomNumberGenerator.Fill(key);
            var asciiEncoding = new ASCIIEncoding();
            return Ok(Convert.ToBase64String(key));
        }

        [HttpPost("Exams/{complementaryExamId}/Files")]
        public async Task<IActionResult> AddFile([FromRoute] int complementaryExamId, IFormFile file)
        {
            var filesDirectory = _configuration["EXAMS_FILES_DIRECTORY"];

            var filePath = await _fileService.SaveEncryptedFile(filesDirectory, file);

            var entity = new ExamFileMetadata
            {
                Name = Path.GetFileName(file.Name),
                FilePath = filePath,
                ComplementaryExam = new() { Id = complementaryExamId }
            };
            await _repository.Create(entity);

            return new OkResult();
        }

        [HttpGet("Exams/{complementaryExamId}/Files/{id}")]
        public async Task<ActionResult> GetFile(int complementaryExamId, int id)
        {
            //var filesDirctory = _configuration["EXAMS_FILES_DIRECTORY"];
            var entity = await _repository.Find(id);
            if (entity == null)
            {
                return new OkResult();
            }
            var filePath = entity.FilePath;
            var file = await _fileService.GetDecryptedFile(filePath);
            return File(file, "application/octet-stream");
        }
    }

}
