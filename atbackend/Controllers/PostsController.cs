using atbackend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace atbackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
  private readonly IPostsServices _postsServices;

  public PostsController(IPostsServices postsServices)
  {
    _postsServices = postsServices;
  }


  [HttpGet("Woolooloo")]
  public async Task<string> GetPosts()
  {
    Console.WriteLine("Hello");
    return await _postsServices.GetPosts();
  }
}