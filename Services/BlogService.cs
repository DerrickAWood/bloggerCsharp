using System;
using System.Collections.Generic;
using bloggercsharp.Models;
using bloggercsharp.Repositories;

namespace bloggercsharp.Services
{
  public class BlogsService
  {
    public BlogsRepository _repo;

    public BlogsService(BlogsRepository repo)
    {
      _repo = repo;
    }


    public IEnumerable<Blog> GetAll()
    {
      return _repo.GetAll();
    }

    internal Blog Create(Blog newBlog)
    {
      Blog createdBlog = _repo.Create(newBlog);
      return createdBlog;
    }
  }
}