using VKR.Data;
using VKR.IService;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace VKR.Service
{
    public class FileService : IFileService
    {
        IHostingEnvironment _hostingEnvironment = null;
        public FileService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public List<FileClass> GetAllPDFs() 
        { 
            List<FileClass> files = new List<FileClass>();
            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nFileId = 1;

            foreach(string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                files.Add(new FileClass()
                {
                    FileID = nFileId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }
            return files;
        }
    }
}
