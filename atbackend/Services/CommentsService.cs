using atbackend.Data;
using atbackend.DTO;
using atbackend.Interfaces;
using atbackend.Migrations;
using atbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace atbackend.Services;


public class CommentsService : ICommentsService
{
    private readonly ApplicationDbContext _dbContext;

    public CommentsService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Comment>> GetComments()
    {
        List<Comment> comments = await _dbContext.Comments.ToListAsync();
        return comments;
    }

    public async Task<Comment> PostComment(CommentDTO commentDTO)
    {
        var comment = new Comment
        {
            Id = new Guid(),
            Author = commentDTO.Author,
            Content = commentDTO.Content,
            IsReply = commentDTO.IsReply,
            PostId = commentDTO.PostId,
            ReplyTo = commentDTO.ReplyTo ?? null
        };
        _dbContext.Comments.Add(comment);
        await _dbContext.SaveChangesAsync();
        var upsertedComment = await _dbContext.Comments.FindAsync(comment.Id);
        return upsertedComment;
    }
}