namespace SorApp.WebApi.Services;

using Microsoft.AspNetCore.Components;
using SorApp.Application.DTOs;

public class AuthService(HttpClient http, NavigationManager nav) : IAuthService
{
    public async Task<AuthResultDto> LoginAsync(LoginDto dto)
    {
        try
        {
            var response = await http.PostAsJsonAsync("/login", dto);
            if (response.IsSuccessStatusCode)
            {
                nav.NavigateTo("/", forceLoad: true);
                return new AuthResultDto { IsSuccess = true };
            }

            var content = await response.Content.ReadFromJsonAsync<AuthResultDto>();
            return content ?? new AuthResultDto { IsSuccess = false, Errors = ["Unknown error"] };
        }
        catch (Exception ex)
        {
            return new AuthResultDto
            {
                IsSuccess = false,
                Errors = [$"Unexpected error: {ex.Message}"]
            };
        }
    }

    public Task<AuthResultDto> RegisterAsync(RegisterDto dto) => throw new NotImplementedException();
    public Task LogoutAsync() => throw new NotImplementedException();
}
