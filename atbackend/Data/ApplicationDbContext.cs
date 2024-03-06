using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using atbackend.Models;

namespace atbackend.Data;

public class ApplicationDbContext
  (DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
  public DbSet<Post> Posts { get; set; }
  public DbSet<Category> Categories { get; set; }
}