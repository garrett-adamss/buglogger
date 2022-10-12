namespace buglogger.Models
{
    public class ProjectBug : RepoItem<int>
    {
        public string CreatorId { get; set; }
        public int ProjectId { get; set; }
        public int BugId { get; set; }
        public Profile Creator { get; set;}
    }
}