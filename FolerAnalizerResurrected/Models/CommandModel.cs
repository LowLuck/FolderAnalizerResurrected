namespace FolderAnalizerResurrected
{
    public class CommandModel
    {
        public string? Syntax { get; set; }
        public int Id { get; set; }

        public CommandModel(int id, string syntax)
        {
            Syntax = syntax;
            Id = id;
        }   
        public CommandModel(int id)
        {
            Id = id;
        }
    }
}
