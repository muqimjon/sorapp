namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class Comment(long templateId, long authorId, string content) : BaseEntity
{
    public long TemplateId { get; private set; } = templateId;
    public long AuthorId { get; private set; } = authorId;
    public string Content { get; private set; } = content;
}
