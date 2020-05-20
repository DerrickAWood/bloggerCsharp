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
  }
}