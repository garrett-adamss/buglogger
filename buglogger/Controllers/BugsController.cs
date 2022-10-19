using System;
using System.Collections.Generic;
using buglogger.Models;

using buglogger.Services;
// using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace buglogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : ControllerBase
    {
        private readonly BugsService _bugsService;

        public BugsController(BugsService bugsService)
        {
            _bugsService = bugsService;
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

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Bug>> GetOneAsync(int id)
        // {
        //     try 
        //     {
        //         // Account user = await HttpContext.GetUserInfoAsync<Account>();
        //         Bug bug = _bugsService.GetOne(id);
        //         return Ok(bug);
        //     }
        //     catch (Exception e)
        //     {
        //        return BadRequest(e.Message);
        //     }
        // }
        // [HttpDelete("{id}")]
        // [Authorize]
        // public async Task<ActionResult<string>> Delete(int id)
        // {
        //     try 
        //     {
        //         string message = _bugsService.Delete(id );
        //         return Ok(message);
        //     }
        //     catch (Exception e)
        //     {
        //        return BadRequest(e.Message);
        //     }
        // }
    }
}