using BlazorInputFile;
using VKR.IService;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace VKR.Service
{
    public class FileUpload : IFileUpload
    {
        IHostingEnvironment _hostingEnvironment = null;
        public FileUpload(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath, "files", file.Name);
            var memoryStream = new MemoryStream();

            await file.Data.CopyToAsync(memoryStream);

            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
