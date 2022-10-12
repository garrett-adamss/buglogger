namespace buglogger.Models
{
    public class Project : RepoItem<int>
    {
        public string CreatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Profile Creator { get; set; }
    }
}