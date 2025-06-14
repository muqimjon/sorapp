namespace SorApp.Application.Services;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SorApp.Application.DTOs;
using SorApp.Application.Interfaces;
using SorApp.Domain.Entities;
using SorApp.Domain.Enums;
using SorApp.Infrastructure.Data;

public class TemplateService(AppDbContext ctx, IMapper mapper) : ITemplateService
{
    public async Task<List<TemplateDto>> GetAllPublicTemplatesAsync()
    {
        var templates = await ctx.Templates
            .Where(t => t.Status == TemplateStatus.Public)
            .ToListAsync();
        return mapper.Map<List<TemplateDto>>(templates);
    }

    public async Task<TemplateDto?> GetTemplateByIdAsync(Guid id)
    {
        var t = await ctx.Templates.FindAsync(id);
        return t == null ? null : mapper.Map<TemplateDto>(t);
    }

    public async Task<Guid> CreateTemplateAsync(TemplateDto dto, Guid authorId)
    {
        var entity = mapper.Map<Template>(dto);
        entity.AuthorId = authorId;
        ctx.Templates.Add(entity);
        await ctx.SaveChangesAsync();
        return entity.Id;
    }

    public async Task UpdateTemplateAsync(Guid id, TemplateDto dto)
    {
        var entity = await ctx.Templates.FindAsync(id) ?? throw new KeyNotFoundException();
        entity.Update(dto.Title, dto.Description, Enum.Parse<TemplateStatus>(dto.Status));
        entity.Tags = dto.Tags;
        await ctx.SaveChangesAsync();
    }

    public async Task DeleteTemplateAsync(Guid id)
    {
        var entity = await ctx.Templates.FindAsync(id) ?? throw new KeyNotFoundException();
        ctx.Templates.Remove(entity);
        await ctx.SaveChangesAsync();
    }

    public Task<List<QuestionDto>> GetQuestionsByTemplateIdAsync(Guid templateId)
    {
        throw new NotImplementedException();
    }

    public Task AddQuestionAsync(Guid templateId, QuestionDto question)
    {
        throw new NotImplementedException();
    }

    public Task RemoveQuestionAsync(Guid questionId)
    {
        throw new NotImplementedException();
    }
}
