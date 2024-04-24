using Azure.Storage.Blobs;

namespace views_practice.Utility
{
    public class UploadFileBlob
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
                var blobConnectionString = configuration.GetConnectionString("BlodConnectionString");  // Check if the key is correctly spelled
                var containerName = configuration["BlodContainerName"];  // Make sure this key matches exactly what's in the configuration file

                // Setup the blob client
                var blobContainerClient = new BlobContainerClient(blobConnectionString, containerName);
                var blobClient = blobContainerClient.GetBlobClient(file.FileName);

                // Upload the file
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    stream.Position = 0; // Reset the position to the beginning after copying
                    await blobClient.UploadAsync(stream, true);
                }

                return blobClient.Uri.AbsoluteUri; // Return the full URL to the uploaded file
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return $"Failed to upload file: {ex.Message}";
            }


        }
    }
}
