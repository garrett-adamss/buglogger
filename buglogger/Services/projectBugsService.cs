using buglogger.Repositories;

namespace buglogger.Services
{
    public class ProjectBugsService
    {
        private readonly ProjectBugsRepository _projectBugsRepo;

        public ProjectBugsService(ProjectBugsRepository projectBugsRepo)
        {
            _projectBugsRepo = projectBugsRepo;
        }


    }
}