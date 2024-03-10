using System.Collections;
using System.ComponentModel.DataAnnotations;


namespace atbackend.Models;

public class Post
{
  [Key] public Guid Id { get; set; } = Guid.NewGuid();
  public string? Title { get; set; }
  public bool Published { get; set; }
  public string? Description { get; set; }
  public string? Content { get; set; }
  public string? Category { get; set; }
  public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
  public virtual List<Comment> Comments {get; set; }
}
