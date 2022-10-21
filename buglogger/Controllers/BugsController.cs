using System;
using System.Collections.Generic;
using buglogger.Models;
using buglogger.Services;
// using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CodeWorks.Utils;
using Microsoft.AspNetCore.Authorization;

namespace buglogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : ControllerBase
    {
        private readonly BugsService _bugsService;
        private readonly Auth0Provider _auth0Provider;

        public BugsController(BugsService bugsService, Auth0Provider auth0Provider)
        {
            _bugsService = bugsService;
            _auth0Provider = auth0Provider;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Bug>> Create([FromBody] Bug bugData){
            try 
            {
              Account user = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
              bugData.CreatorId = user.Id;
              Bug bug = _bugsService.Create(bugData, user);
              bug.Creator = user;
              return Ok(bug);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Bug>> GetAll()
        {
            try 
            {
              List<Bug> bugs = _bugsService.GetAll();
              return Ok(bugs);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bug>> GetOneAsync(int id)
        {
            try 
            {
                Account user = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
                Bug bug = _bugsService.GetOne(id, user?.Id);
                return Ok(bug);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Bug>> Update(int id, [FromBody] Bug bugData)
        {
            try 
            {
                Account user = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
                bugData.Id = id;
                Bug bug = _bugsService.Update(bugData, user);
                return Ok(bug);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
        
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<string>> Delete(int id)
        {
            try 
            {
                Account user = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
                string message = _bugsService.Delete(id, user);
                return Ok(message);
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
    }
}