namespace SorApp.Application.DTOs;

public class RegisterDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public class LoginDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool IsPersistent { get; set; }
    public bool LockoutOnFailure { get; set; }
}

public class AuthResultDto
{
    public bool IsSuccess { get; set; }
    public IEnumerable<string> Errors { get; set; } = [];
}

