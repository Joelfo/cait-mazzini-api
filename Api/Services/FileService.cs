using System.IO;

namespace CaitMazziniApp.Api.Services
{
    public class FileService
    {
        private readonly EncryptionService _encryptionService;

        public FileService(EncryptionService encryptionService) 
        {
            _encryptionService = encryptionService;
        }

        public async Task<string> SaveEncryptedFile(string directory, IFormFile file)
        {
            if (String.IsNullOrEmpty(directory))
            {
                throw new ArgumentNullException(nameof(directory));
            }

            var filePath = Path.Combine(directory, Path.GetRandomFileName());

            using (var fileStream = new MemoryStream())
            {
                await file.CopyToAsync(fileStream);
                var encryptedStream = _encryptionService.GetEncryptedStream(fileStream);
                using (var stream = System.IO.File.Create(filePath))
                {
                    await encryptedStream.CopyToAsync(stream);
                }
            }

            return filePath;
        }

        public async Task<MemoryStream> GetDecryptedFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                using (var file = System.IO.File.OpenRead(filePath))
                {
                    var memoryFileStream = new MemoryStream();
                    await file.CopyToAsync(memoryFileStream);
                    var decryptedStream = _encryptionService.GetDecryptedStream(memoryFileStream);
                    return decryptedStream;
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
};
