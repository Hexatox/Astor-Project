using Azure.Storage.Blobs;

namespace views_practice.Utility
{
    public class UploadFileBlob : IUploadFile
    {
        private readonly IConfiguration configuration;
        public UploadFileBlob(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<string?> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return null;
            }

            try
            {
                var blobConnectionString = Environment.GetEnvironmentVariable ("BlodConnectionString");  
                var containerName = Environment.GetEnvironmentVariable("BlodContainerName");  

                var blobContainerClient = new BlobContainerClient(blobConnectionString, containerName);
                var blobClient = blobContainerClient.GetBlobClient(file.FileName);

                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0; 
                    await blobClient.UploadAsync(stream, true);
                }

                return blobClient.Uri.AbsoluteUri; 
            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
