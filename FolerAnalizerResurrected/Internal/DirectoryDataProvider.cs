using Scripting;
using System.Security;

namespace FolerAnalizerResurrected
{
    public static class DirectoryDataProvider
    {
        static readonly FileSystemObject fso = new FileSystemObject();
        public static long GetFileSize(string path)
        {
            try
            {
                if (fso.FileExists(path))
                {
                    return (long)fso.GetFile(path).Size;
                }
                else if (fso.FolderExists(path))
                {
                    return (long)fso.GetFolder(path).Size;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch(SecurityException)
            {
                return 0;
            }

        }


    }
}
