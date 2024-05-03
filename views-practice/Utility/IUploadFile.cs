namespace views_practice.Utility
{
    public interface IUploadFile
    {
        Task<string?> Upload (IFormFile file);
    }
}
