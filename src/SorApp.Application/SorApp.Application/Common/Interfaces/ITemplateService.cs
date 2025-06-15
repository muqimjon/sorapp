namespace SorApp.Application.Common.Interfaces;

using SorApp.Application.DTOs;

public interface ITemplateService
{
    Task<List<TemplateDto>> GetAllPublicTemplatesAsync();
    Task<TemplateDto?> GetTemplateByIdAsync(Guid id);
    Task<Guid> CreateTemplateAsync(TemplateDto dto, Guid authorId);
    Task UpdateTemplateAsync(Guid id, TemplateDto dto);
    Task DeleteTemplateAsync(Guid id);

    Task<List<QuestionDto>> GetQuestionsByTemplateIdAsync(Guid templateId);
    Task AddQuestionAsync(Guid templateId, QuestionDto question);
    Task RemoveQuestionAsync(Guid questionId);
}
