using buglogger.Services;
using Microsoft.AspNetCore.Mvc;

namespace buglogger.Controllers
{
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsService _projectsService;
        private readonly ProjectBugsService _projectsBugsService;

        public ProjectsController(ProjectsService projectsService, ProjectBugsService projectsBugsService)
        {
            _projectsService = projectsService;
            _projectsBugsService = projectsBugsService;
        }
    }
}