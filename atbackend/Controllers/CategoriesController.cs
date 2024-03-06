using atbackend.Interfaces;
using atbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace atbackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
  private readonly ICategoriesServices _categoriesServices;

  public CategoriesController(ICategoriesServices categoriesServices)
  {
    _categoriesServices = categoriesServices;
  }
    


  [HttpGet("getAllCategories")]
  public async Task<List<Category>> GetCategories()
  {
    Console.WriteLine("Hello");
    return await _categoriesServices.GetCategories();
  }
}