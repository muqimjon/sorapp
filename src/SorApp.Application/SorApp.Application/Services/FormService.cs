namespace SorApp.Application.Services;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SorApp.Application.DTOs;
using SorApp.Application.Interfaces;
using SorApp.Domain.Entities;
using SorApp.Infrastructure.Data;

public class FormService(AppDbContext ctx, IMapper mapper) : IFormService
{
    public async Task<List<FormDto>> GetByTemplateAsync(Guid templateId)
    {
        var list = await ctx.Forms
            .Where(f => f.TemplateId == templateId)
            .Include(f => f.Answers)
            .ToListAsync();

        return mapper.Map<List<FormDto>>(list);
    }

    public async Task<Guid> CreateAsync(FormDto dto)
    {
        var form = new Form(dto.TemplateId, dto.RespondentId);
        ctx.Forms.Add(form);
        await ctx.SaveChangesAsync();
        return form.Id;
    }

    public async Task AddAnswerAsync(Guid formId, AnswerDto dto)
    {
        var ans = mapper.Map<Answer>(dto);
        ctx.Answers.Add(ans);
        await ctx.SaveChangesAsync();
    }
}