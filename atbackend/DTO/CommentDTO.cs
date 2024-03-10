namespace atbackend.DTO;

public class CommentDTO
{
    public string Author { get; set; }
    public string Content { get; set; }
    public bool IsReply { get; set; }
    public Guid? ReplyTo { get; set; }
    public Guid PostId { get; set; }
}