using FolderAnalizerResurrected;

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
            Console.WriteLine("Type /ext to leave");
            Console.WriteLine("Enter directory path");

            UI.ReadInput();
        }
    }
}