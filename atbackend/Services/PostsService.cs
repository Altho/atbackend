using atbackend.Interfaces;
using atbackend.Models;
using atbackend.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace atbackend.Services
{
  public class PostsService : IPostsServices
  {
    private readonly ApplicationDbContext _dbContext;

    public PostsService(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<List<Post>> GetPosts()
    {
      List<Post> posts = await _dbContext.Posts.ToListAsync();
      return posts;
    }
  }
}