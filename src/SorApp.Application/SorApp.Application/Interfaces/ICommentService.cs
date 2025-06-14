namespace SorApp.Application.Interfaces;

using SorApp.Application.DTOs;

public interface ICommentService
{
    Task<List<CommentDto>> GetCommentsByTemplateIdAsync(Guid templateId);
    Task<CommentDto> AddCommentAsync(CommentDto comment, Guid userId);
}