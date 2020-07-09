using System;
using System.Collections.Generic;
using bookapi.Models;
using libraryApi.services;
using Microsoft.AspNetCore.Mvc;

namespace libraryApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BooksController : ControllerBase
  {
    private readonly BookService _service;
    public BooksController(BookService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAll()
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
    [HttpGet("avilable")]
    public ActionResult<IEnumerable<Book>> GetAvail()
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
    [HttpGet("{id}")]
    public ActionResult<Book> GetById(string id)
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
    public ActionResult<Book> Create([FromBody] Book newBook)
    {
      try
      {
        return Ok(_service.Create(newBook));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}