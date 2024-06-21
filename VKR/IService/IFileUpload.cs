using BlazorInputFile;
namespace VKR.IService
{
    public interface IFileUpload
    {
        Task Upload(IFileListEntry file);
    }
}
