using buglogger.Services;
using Microsoft.AspNetCore.Mvc;

namespace buglogger.Controllers
{
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsService _projectsService;
    }
}