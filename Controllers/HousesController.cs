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
  public class HousesController : ControllerBase
  {
    private readonly HousesService _housesService;
    // NOTE Required Service to construct (Dependency Injection)

    public HousesController(HousesService housesService)
    {
      _housesService = housesService;
    }

    // NOTE GetAll for the GET request
    [HttpGet]

    // NOTE ActionResult defines the response will be an HTTP Request

    public ActionResult<IEnumerable<House>> Get()
    {
      try
      {
        IEnumerable<House> houses = _housesService.Get();
        return Ok(houses);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]

    public ActionResult<House> Get(string id)
    {
      try
      {
        House found = _housesService.Get(id);
        return Ok(found);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]

    // NOTE FromBody is the same as Req.Body from Nodejs. 
    // NOTE C# will take the body and try to convert it into the type provided
    public ActionResult<House> Create([FromBody] House newHouse)
    {
      try
      {
        House house = _housesService.Create(newHouse);
        return Ok(house);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]

    public ActionResult<String> Delete(string id)
    {
      try
      {
        _housesService.Delete(id);
        return Ok("Successfully Deleted House");
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}