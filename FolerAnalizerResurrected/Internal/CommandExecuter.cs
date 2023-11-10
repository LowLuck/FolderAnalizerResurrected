namespace FolderAnalizerResurrected
{
    public static class CommandExecuter
    {
        public static List<Action> Commands = new List<Action> 
        {
           ShutDown
        };
        public static bool ExecuteCommand(int index)
        {
            try
            {
                Commands[index]();
            }
            catch (Exception) { return false; }
            return true;

        }
        public static void ShutDown()
        {
            Environment.Exit(0);
        }

    }
}
