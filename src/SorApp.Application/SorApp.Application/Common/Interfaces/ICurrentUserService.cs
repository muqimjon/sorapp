namespace SorApp.Application.Common.Interfaces;

public interface ICurrentUserService
{
    Guid? UserId { get; }
    Task<string?> GetUserEmailAsync();
}
