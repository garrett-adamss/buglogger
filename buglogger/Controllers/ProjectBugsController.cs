using System;
using System.Collections.Generic;
using buglogger.Models;
using buglogger.Services;
using CodeWorks.Utils;
using Microsoft.AspNetCore.Mvc;

namespace buglogger.Controllers
{
    public class ProjectBugsController : ControllerBase
    {
        private readonly ProjectBugsService _projectBugsService;
        private readonly Auth0Provider _auth0Provider;

        public ProjectBugsController(ProjectBugsService projectBugsService, Auth0Provider auth0Provider)
        {
            _projectBugsService = projectBugsService;
            _auth0Provider = auth0Provider;
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

        [HttpGet]
        public ActionResult<List<Project>> GetAll()
        {
            try 
            {
              List<Project> projects = _projectBugsService.GetAll();
              return Ok(projects);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
    }
}