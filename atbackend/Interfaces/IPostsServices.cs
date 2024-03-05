namespace atbackend.Interfaces;

public interface IPostsServices
{
  Task<string> GetPosts();
}