using System;
using System.Collections.Generic;
using buglogger.Models;
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
        
        [HttpGet]
        public ActionResult<List<Project>> GetAll()
        {
            try 
            {
              List<Project> projects = _projectsService.GetAll();
              return Ok(projects);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
    }
}