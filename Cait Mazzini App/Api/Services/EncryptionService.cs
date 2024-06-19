using System.Security.Cryptography;
using System.Text;

namespace CaitMazziniApp.Api.Services
{
    public class EncryptionService
    {
        private readonly IConfiguration _configuration;

        public EncryptionService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Stream GetEncryptedStream(MemoryStream originalStream) { 
        
            string key = _configuration["ENCRYPTION_KEY"];
            if (string.IsNullOrEmpty(key))
            {
                throw new Exception("ENCRYPTION_KEY configuration variable is not defined");
            }
            var keyBytes = Convert.FromBase64String(key);
            using (var aesGcm = new AesGcm(keyBytes))
            {
                var nonce = new byte[AesGcm.NonceByteSizes.MaxSize];
                RandomNumberGenerator.Fill(nonce);

                var originalStreamBytes = originalStream.ToArray();

                var encryptedStreamBytes = new byte[originalStreamBytes.Length];
                var authenticationTag = new byte[AesGcm.TagByteSizes.MaxSize];

                aesGcm.Encrypt(nonce, originalStreamBytes, encryptedStreamBytes, authenticationTag);

                var storingBytes = new byte[nonce.Length + encryptedStreamBytes.Length + authenticationTag.Length];

                // storingBytes é composto por: [nonce(IV) + authenticationTag + encryptedBytes]
                Buffer.BlockCopy(nonce, 0, storingBytes, 0, nonce.Length);
                Buffer.BlockCopy(authenticationTag, 0, storingBytes, nonce.Length, authenticationTag.Length);
                Buffer.BlockCopy(encryptedStreamBytes, 0, storingBytes, (nonce.Length + authenticationTag.Length), encryptedStreamBytes.Length);

                var encryptedStreamToStore = new MemoryStream(storingBytes);
                return encryptedStreamToStore;
            }  
        }

        public MemoryStream GetDecryptedStream(MemoryStream encryptedStream)
        {
            string key = _configuration["ENCRYPTION_KEY"];
            if (string.IsNullOrEmpty(key))
            {
                throw new Exception("ENCRYPTION_KEY configuration variable is not defined");
            }

            var keyBytes = Convert.FromBase64String(key);

            var encryptedBytes = encryptedStream.ToArray();
            var nonce = encryptedBytes.Take(AesGcm.NonceByteSizes.MaxSize).ToArray();
            var authenticationKey = encryptedBytes.Skip(AesGcm.NonceByteSizes.MaxSize).Take(AesGcm.TagByteSizes.MaxSize).ToArray();
            var encryptedContent = encryptedBytes.Skip(nonce.Length + authenticationKey.Length).ToArray(); 

            using ( var aesGcm = new AesGcm(keyBytes) )
            {
                var decryptedBytes = new byte[encryptedContent.Length];
                aesGcm.Decrypt(nonce, encryptedContent, authenticationKey, decryptedBytes);
                
                var decryptedStream = new MemoryStream(decryptedBytes);
                return decryptedStream;
            }
        }
    }
}
