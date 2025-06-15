namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class User : BaseEntity
{
    public Guid AppUserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public List<Template> Templates { get; set; } = [];
    public List<Form> Forms { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
}

