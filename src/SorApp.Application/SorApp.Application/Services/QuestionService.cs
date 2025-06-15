namespace SorApp.Application.Services;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SorApp.Application.Common.Interfaces;
using SorApp.Domain.Entities;
using SorApp.Domain.Enums;
using SorApp.Application.DTOs;

public class QuestionService(IAppDbContext ctx, IMapper mapper) : IQuestionService
{
    public async Task<List<QuestionDto>> GetByTemplateAsync(Guid templateId)
    {
        var list = await ctx.Questions
            .Where(q => q.TemplateId == templateId)
            .ToListAsync();

        return mapper.Map<List<QuestionDto>>(list);
    }

    public async Task AddAsync(Guid templateId, QuestionDto dto)
    {
        var entity = new Question(templateId, Enum.Parse<QuestionType>(dto.Type), dto.Title, dto.ShowInResults);
        ctx.Questions.Add(entity);
        await ctx.SaveChangesAsync();
    }

    public async Task RemoveAsync(Guid questionId)
    {
        var entity = await ctx.Questions.FindAsync(questionId) ?? throw new KeyNotFoundException();
        ctx.Questions.Remove(entity);
        await ctx.SaveChangesAsync();
    }
}
