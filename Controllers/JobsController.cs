using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslistcsharp.Models;
using gregslistcsharp.Services;

namespace gregslistcsharp.Controllers
{
  // NOTE Tells DotNet this is a Controller
  [ApiController]

  // NOTE Injects name of Controller into Route
  [Route("/api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _jobsService;

    // NOTE Required Service to Construct (Dependency Injection)
    public JobsController(JobsService jobsService)
    {
      _jobsService = jobsService;
    }

    // NOTE GetAll for Jobs
    [HttpGet]
    // Note Action Result defines the response will be an HTTP Request
    public ActionResult<IEnumerable<Job>> Get()
    {
      try
      {
        IEnumerable<Job> jobs = _jobsService.Get();
        return Ok(jobs);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    // NOTE Get Job By ID
    [HttpGet("{id}")]
    public ActionResult<Job> Get(string id)
    {
      try
      {
        Job found = _jobsService.Get(id);
        return Ok(found);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    // NOTE Post Job Request
    [HttpPost]

    public ActionResult<Job> Create([FromBody] Job newJob)
    {
      try
      {
        Job job = _jobsService.Create(newJob);
        return Ok(job);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    // NOTE Delete Job by Id Request
    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _jobsService.Delete(id);
        return Ok("Successfully Deleted Job");
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}