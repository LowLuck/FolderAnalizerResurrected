using FolerAnalizerResurrected;
using FolerAnalizerResurrected.UI;

namespace FolderAnalizerResurrected
{
    class Core
    {
        // Add feature of showing any depth of contents. + Add print-on-ready
        // Multiple checks?
        // Archive's contents?
        // Deleting files/directories
        // Search hidden directoris (for example %appdata%
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory path");
            string? path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                DirectoryModel dirModel = new DirectoryModel(path);
                UI.PrintDirectoryList(dirModel);
            }
        }
    }
}