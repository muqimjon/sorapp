namespace SorApp.Application.Services;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SorApp.Application.Common.Interfaces;
using SorApp.Application.DTOs;
using SorApp.Domain.Entities;

public class CommentService(IAppDbContext ctx, IMapper mapper) : ICommentService
{
    public async Task<List<CommentDto>> GetByTemplateAsync(Guid templateId)
    {
        var list = await ctx.Comments
            .Where(c => c.TemplateId == templateId)
            .ToListAsync();

        return mapper.Map<List<CommentDto>>(list);
    }

    public async Task<Guid> AddAsync(CommentDto dto)
    {
        var comment = new Comment(dto.TemplateId, dto.AuthorId, dto.Content);
        ctx.Comments.Add(comment);
        await ctx.SaveChangesAsync();
        return comment.Id;
    }

    public Task<List<CommentDto>> GetCommentsByTemplateIdAsync(Guid templateId)
    {
        throw new NotImplementedException();
    }

    public Task<CommentDto> AddCommentAsync(CommentDto comment, Guid userId)
    {
        throw new NotImplementedException();
    }
}