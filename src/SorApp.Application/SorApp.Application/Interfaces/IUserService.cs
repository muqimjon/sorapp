namespace SorApp.Application.Interfaces;

using global::SorApp.Application.DTOs;

public interface IUserService
{
    Task<UserDto?> GetByIdAsync(Guid id);
    Task<List<UserDto>> SearchUsersAsync(string searchTerm); // name/email orqali qidirish
    Task<List<TemplateDto>> GetUserTemplatesAsync(Guid userId);
    Task<List<FormDto>> GetUserFormsAsync(Guid userId);
}
