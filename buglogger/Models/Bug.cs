namespace buglogger.Models
{
    public class Bug : RepoItem<int>
    {
        public string CreatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Following { get; set; }
        public Profile Creator { get; set; }
    }
    public class projectBugViewModel : Bug
    {
        public int projectBug { get; set; }
    }
}