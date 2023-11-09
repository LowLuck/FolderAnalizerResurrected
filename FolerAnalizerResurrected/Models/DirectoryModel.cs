namespace FolerAnalizerResurrected
{
    public class DirectoryModel : FileModel
    {
        public List<FileModel> Contents { get; set; }
        public void GetContents()
        {
            string[] subDirectoriesPaths = Directory.GetDirectories(Path).Union(Directory.GetFiles(Path)).ToArray();
            foreach (string subDirectoryPath in subDirectoriesPaths)
            {
                DirectoryModel subDirectory = new DirectoryModel
                {
                    Path = subDirectoryPath,
                    Size = DirectoryDataProvider.GetFileSize(subDirectoryPath)
                };
                Contents.Add(subDirectory);
            }
        }
        public DirectoryModel()
        {
            Contents = new List<FileModel>();
        }
        public DirectoryModel(string path) 
            : base(path)
        {
            Contents = new List<FileModel>();
            GetContents();
            
        }
    }
}
