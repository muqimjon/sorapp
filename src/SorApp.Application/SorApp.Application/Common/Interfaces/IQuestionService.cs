namespace SorApp.Application.Common.Interfaces;

using SorApp.Application.DTOs;

public interface IQuestionService
{
    Task<List<QuestionDto>> GetByTemplateAsync(Guid templateId);
    Task AddAsync(Guid templateId, QuestionDto dto);
    Task RemoveAsync(Guid questionId);
}