namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class Comment(Guid templateId, Guid authorId, string content) : BaseEntity
{
    public Guid TemplateId { get; private set; } = templateId;
    public Guid AuthorId { get; private set; } = authorId;
    public string Content { get; private set; } = content;
}
