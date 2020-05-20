using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bloggercsharp.Models;
using bloggercsharp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bloggercsharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BlogsController : ControllerBase
  {
    public BlogsService _bs { get; }

    public BlogsController(BlogsService bs)
    {
      _bs = bs;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Blog>> GetAll()
    {
      try
      {
          return Ok(_bs.GetAll());
      }
      catch (System.Exception err)
      {
          return BadRequest(err.Message) ;
      }
    }
    [HttpPost]
    public ActionResult<Blog> Create([FromBody] Blog newBlog)
    {
      try
      {
          return Ok(_bs.Create(newBlog));
      }
      catch (System.Exception err)
      {
          return BadRequest(err.Message);
      }
    }
  }
}