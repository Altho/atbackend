using atbackend.Data;
using atbackend.Interfaces;
using atbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace atbackend.Services;


  public class CategoriesService : ICategoriesServices
  {
    private readonly ApplicationDbContext _dbContext;

    public CategoriesService(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<List<Category>> GetCategories()
    {
      List<Category> categories = await _dbContext.Categories.ToListAsync();
      return categories;
    }
}