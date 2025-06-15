namespace SorApp.WebApi.Services;

using SorApp.Application.DTOs;

public interface IAuthService
{
    Task<AuthResultDto> LoginAsync(LoginDto dto);
    Task<AuthResultDto> RegisterAsync(RegisterDto dto);
    Task LogoutAsync();
}
