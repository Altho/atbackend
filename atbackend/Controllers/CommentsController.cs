using atbackend.DTO;
using atbackend.Interfaces;
using atbackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace atbackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentsController : ControllerBase
{
    private readonly ICommentsService _commentService;

    public CommentsController(ICommentsService commentService)
    {
        _commentService = commentService;
    }
    


    [HttpGet("getAllcomments")]
    public async Task<List<Comment>> GetComment()
    {
        Console.WriteLine("Hello");
        return await _commentService.GetComments();
    }

    [HttpPost("NewComment")]
    public async Task<Comment> PostComment([FromBody]CommentDTO commentDto)
    {
        return await _commentService.PostComment(commentDto);
    }
    
}