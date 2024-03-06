using atbackend.Models;

namespace atbackend.Interfaces;

public interface ICategoriesServices
{
  Task <List<Category>> GetCategories();
}