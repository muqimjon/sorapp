namespace SorApp.Application.Common.Interfaces;

using SorApp.Application.DTOs;

public interface IFormService
{
    Task<List<FormDto>> GetFormsByTemplateIdAsync(Guid templateId);
    Task<FormDto?> GetFormByIdAsync(Guid formId);
    Task<Guid> SubmitFormAsync(FormDto dto, Guid userId);
    Task DeleteFormAsync(Guid formId, Guid userId);
}