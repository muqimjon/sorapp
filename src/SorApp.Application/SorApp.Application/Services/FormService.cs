namespace SorApp.Application.Services;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SorApp.Application.Common.Interfaces;
using SorApp.Application.DTOs;
using SorApp.Domain.Entities;

public class FormService(IAppDbContext ctx, IMapper mapper) : IFormService
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

    public async Task AddAnswerAsync(AnswerDto dto)
    {
        var ans = mapper.Map<Answer>(dto);
        ctx.Answers.Add(ans);
        await ctx.SaveChangesAsync();
    }

    public Task<List<FormDto>> GetFormsByTemplateIdAsync(Guid templateId)
    {
        throw new NotImplementedException();
    }

    public Task<FormDto?> GetFormByIdAsync(Guid formId)
    {
        throw new NotImplementedException();
    }

    public Task<Guid> SubmitFormAsync(FormDto dto, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFormAsync(Guid formId, Guid userId)
    {
        throw new NotImplementedException();
    }
}