namespace FolderAnalizerResurrected
{
    public class FileModel
    {
        public string? Path { get; set; }
        public long Size { get; set; }

        public string GetName()
        {
            return System.IO.Path.GetFileName(Path);
        }

        public FileModel(string path)
        {
            Path = path;
            Size = DirectoryDataProvider.GetFileSize(path);
        }
        public FileModel()
        {
        }
    }
}
