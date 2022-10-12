using buglogger.Repositories;

namespace buglogger.Services
{
    public class ProjectsService
    {
        private readonly ProjectsRepository _ProjectsRepo;

        public ProjectsService(ProjectsRepository projectsRepo)
        {
            _ProjectsRepo = projectsRepo;
        }
    }
}