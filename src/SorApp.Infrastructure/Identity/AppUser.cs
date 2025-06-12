namespace SorApp.Infrastructure.Identity;

using Microsoft.AspNetCore.Identity;
using SorApp.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public List<Template> Templates { get; set; } = [];
    public List<Form> Forms { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
}

