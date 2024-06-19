using CaitMazziniApp.Api.Services;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Core;
using Microsoft.AspNetCore.Mvc;

namespace CaitMazziniApp.Api.Controllers
{
    [Route("Patients/{patientId}/ScannedChart")]
    public class ScannedChartController : ControllerBase
    {
        public readonly FileService _fileService;
        public readonly IConfiguration _configuration;
        public readonly IScannedChartMetadataRepository _repository;
 
        public ScannedChartController(FileService fileService, IConfiguration configuration, IScannedChartMetadataRepository repository)
        {
            _fileService = fileService;
            _configuration = configuration;
            _repository = repository;
        }

        [HttpGet("Check")]
        public async Task<IActionResult> CheckScannedChart([FromRoute]int patientId)
        {
            var scannedChartMetaData = await _repository.GetByPatient(patientId);
            bool result = true;
            if (scannedChartMetaData == null)
            {
                result = false;
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromRoute]int patientId, IFormFile file)
        {
            var filesDirectory = _configuration["SCANNED_CHART_FILES_DIRECTORY"];

            var filePath = await _fileService.SaveEncryptedFile(filesDirectory, file);

            var entity = new ScannedChartMetadata
            {
                Patient = new() { Id = patientId },
                FilePath = filePath,
            };

            await _repository.Create(entity);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromRoute]int patientId)
        {
            var scannedChartMetaData = await _repository.GetByPatient(patientId);
            if (scannedChartMetaData == null)
            {
                return NotFound();
            }
            
            var path = scannedChartMetaData.FilePath;
            var contentType = "application/pdf";

            try
            {
                var fileStream = await _fileService.GetDecryptedFile(path);
                return File(fileStream, contentType);
            } catch (FileNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
