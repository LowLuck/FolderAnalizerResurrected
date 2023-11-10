namespace FolerAnalizerResurrected.UI
{
    public static class UI
    {
        public static void PrintDirectoryList(DirectoryModel directoryModel)
        {
            string[] convertedSize = ConvertByteToUserFriendly(directoryModel.Size);
            string message = $"\n{directoryModel.GetName()} {convertedSize[0]} {convertedSize[1]}";

            int indent = 2;
            char indentSymbol = '-';

            int totalStringSize = directoryModel.Contents.Max(x => x.GetName().Length) + 2;
            foreach (FileModel file in directoryModel.Contents.OrderBy(x => -x.Size))
            {
                string fileName = file.GetName();
                convertedSize = ConvertByteToUserFriendly(DirectoryDataProvider.GetFileSize(file.Path));
                message += $"\n{new string(indentSymbol, indent)}{fileName}{new string(' ', totalStringSize - fileName.Length)}{convertedSize[0]} {convertedSize[1]}";
            }

            Console.WriteLine(message);
        }
        public static string[] ConvertByteToUserFriendly(long bytes)
        {
            string[] symbols = {"Bytes", "KB", "MB", "GB", "TB", "PB"};
            int currentSymbol = 0;

            while (bytes >= 1024 & currentSymbol < 5)
            {
                bytes = (bytes / 1024);
                currentSymbol += 1;
            }
            return new string[] {Convert.ToString(bytes), symbols[currentSymbol]};
        }
    }
}
