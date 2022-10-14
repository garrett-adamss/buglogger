using buglogger.Services;
using Microsoft.AspNetCore.Mvc;

namespace buglogger.Controllers
{
    public class ProjectBugsController : ControllerBase
    {
        private readonly ProjectBugsService _projectBugsService;

        public ProjectBugsController(ProjectBugsService projectBugsService)
        {
            _projectBugsService = projectBugsService;
        }

        // [HttpPost]
        // [Authorize]
        // public async Task<ActionResult<Project>> Create([FromBody] Project newProject)
        // {
        //     try 
        //     {
        //       Account user = await HttpContext.GetUserInfoAsync<Account>();
        //     }
        //     catch (Exception e)
        //     {
        //        return BadRequest(e.Message);
        //     }
        // }
    }
}