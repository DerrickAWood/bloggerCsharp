using System;
using System.Collections.Generic;
using System.Data;
using bloggercsharp.Models;
using Dapper;

namespace bloggercsharp.Repositories
{
  public class BlogsRepository
  {
    private readonly IDbConnection _db;

    public BlogsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Blog> GetAll()
    {
      string sql = "SELECT * FROM blogs";
      return _db.Query<Blog>(sql);
    }

    internal Blog Create(Blog newBlog)
    {
      string sql = @"
      INSERT INTO blogs
      (title, body, isPublished)
      VALUES 
      (@Title, @Body, @isPublished)
      SELECT LAST_INSERT_ID()";
     newBlog.Id = _db.ExecuteScalar<int>(sql, newBlog);
     return newBlog;
    }
  }
}