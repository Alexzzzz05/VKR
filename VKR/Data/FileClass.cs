namespace VKR.Data
{
    public class FileClass
    {
        public int FileID { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Path { get; set; } = "";
        public List<FileClass> Files { get; set; } = new List<FileClass>();
    }
}
