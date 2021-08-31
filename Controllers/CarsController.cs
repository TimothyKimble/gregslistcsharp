using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslistcsharp.Models;
using gregslistcsharp.Services;

namespace gregslistcsharp.Controllers
{
  // NOTE ApiController tells Dotnet register this class as a controller
  [ApiController]

  // NOTE super() : Route ("[controller]") injects the name of the Controller 
  [Route("/api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _carsService;
    // NOTE Required Service to struct (Dependency Injection)
    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }


    // NOTE GetAll through GET request
    [HttpGet]
    // NOTE returns HTTPResult (ok, badrequest, forbidden) of type collection (aka IEnumberable) of type Cat
    // NOTE ActionResult defines the response will be an HTTPRequest
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        IEnumerable<Car> cars = _carsService.Get();
        // NOTE ok is the HTTPResponse: 200 ok
        return Ok(cars);
      }
      catch (Exception err)
      {
        // BadRequest is HTTPResponse: 400 Bad Request
        return BadRequest(err.Message);
      }
    }


    // NOTE '/:id' : "{id}"
    [HttpGet("{id}")]

    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car found = _carsService.Get(id);
        return Ok(found);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    // NOTE req.body : [FromBody]
    // NOTE C# will take the body and try to convert it into the type provided
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _carsService.Create(newCar);
        return Ok(car);
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
        // this is later handled in the actual DB
        _carsService.Delete(id);
        return Ok("Successfully Deleted Car");
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}