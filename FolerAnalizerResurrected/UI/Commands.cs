using System.ComponentModel;

namespace FolderAnalizerResurrected
{
     public static class Commands
    {
        public static readonly CommandModel[] CommandList = new CommandModel[]
        {
            new CommandModel(0, "/ext")
        };

        public static int GetCommandId(string message)
        {
            var x = CommandList[0];
            return CommandList.FirstOrDefault(x => x.Syntax == message, new CommandModel(-1)).Id;
        }
    }
}
