using atbackend.Models;

namespace atbackend.Interfaces;

public interface IPostsServices
{
  Task<List<Post>> GetPosts();
}