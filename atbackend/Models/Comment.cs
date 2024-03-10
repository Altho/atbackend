namespace atbackend.Models;

public class Comment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Author { get; set; }
    public string? Content { get; set; }
    public bool IsReply { get; set; } 
    public Guid? ReplyTo { get; set; }
    public Guid PostId { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public Post Post { get; set; }
    
}