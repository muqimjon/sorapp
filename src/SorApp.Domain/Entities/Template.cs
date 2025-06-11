namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;
using SorApp.Domain.Enums;

public class Template(Guid authorId, string title, string description, TemplateStatus status) : BaseEntity
{
    public Guid AuthorId { get; private set; } = authorId;
    public string Title { get; private set; } = title;
    public string Description { get; private set; } = description;
    public TemplateStatus Status { get; private set; } = status;
    public List<string> Tags { get; private set; } = [];
    public List<Question> Questions { get; private set; } = [];

    public void Update(string title, string description, TemplateStatus status)
    {
        Title = title;
        Description = description;
        Status = status;
        SetUpdatedAt();
    }

    public void AddQuestion(Question q) => Questions.Add(q);
    public void RemoveQuestion(Guid questionId) =>
        Questions.RemoveAll(q => q.Id == questionId);
}