using atbackend.DTO;
using atbackend.Models;

namespace atbackend.Interfaces;

public interface ICommentsService
{
    Task <List<Comment>> GetComments();
    Task<Comment> PostComment(CommentDTO commentDto);

}