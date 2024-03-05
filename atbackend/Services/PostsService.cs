using atbackend.Interfaces;

namespace atbackend.Services;

public class PostsService : IPostsServices
{
  public async Task<string> GetPosts()
  {
    Console.WriteLine("Coucou!");
    return "Hello World";
  }
}