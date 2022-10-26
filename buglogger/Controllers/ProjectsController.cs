using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using buglogger.Models;
using buglogger.Services;
using CodeWorks.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace buglogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsService _projectsService;
        private readonly ProjectBugsService _projectsBugsService;
        private readonly Auth0Provider _auth0Provider;

        public ProjectsController(ProjectsService projectsService, ProjectBugsService projectsBugsService, Auth0Provider auth0Provider)
        {
            _projectsService = projectsService;
            _projectsBugsService = projectsBugsService;
            _auth0Provider = auth0Provider;
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetOne(int id)
        {
            try 
            {
              Account user = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
              Project project = _projectsService.GetOne(id, user?.Id);
              return Ok(project);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Project>> Create([FromBody] Project projectData)
        {
            try 
            {
              Account user = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
              projectData.CreatorId = user.Id;
              Project project = _projectsService.Create(projectData, user);
              project.Creator = user;
              return Ok(project);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
    }
}