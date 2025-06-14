namespace SorApp.Application.Services;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SorApp.Application.DTOs;
using SorApp.Application.Interfaces;
using SorApp.Domain.Entities;
using SorApp.Infrastructure.Data;

public class CommentService(AppDbContext ctx, IMapper mapper) : ICommentService
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
}