namespace SorApp.Domain.Entities;

using Microsoft.AspNetCore.Identity;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public List<Template> Templates { get; set; } = [];
    public List<Form> Forms { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
}

