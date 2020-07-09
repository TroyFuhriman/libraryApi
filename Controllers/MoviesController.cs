using System;
using System.Collections.Generic;
using libraryApi.Models;
using libraryApi.services;
using Microsoft.AspNetCore.Mvc;

namespace libraryApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MoviesController : ControllerBase
  {
    private readonly MovieService _service;
    public MoviesController(MovieService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Movie>> GetAll()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (Exception error)
      {

        return BadRequest(error.Message);
      }
    }
    [HttpGet("available")]
    public ActionResult<IEnumerable<Movie>> GetAvail()
    {
      try
      {
        return Ok(_service.GetAvail());
      }
      catch (Exception error)
      {

        return BadRequest(error.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Movie> GetById(string id)
    {
      try
      {
        return Ok(_service.getById(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Movie> Create([FromBody] Movie newMovie)
    {
      try
      {
        return Ok(_service.Create(newMovie));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Movie> Edit([FromBody] Movie editMovie, string id)
    {
      try
      {
        return Ok(_service.Edit(editMovie, id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Movie> Delete(string id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (Exception q)
      {
        return BadRequest(q.Message);
      }
    }
  }
}