namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;
using SorApp.Domain.Enums;

public class Question(Guid templateId, QuestionType type, string title, bool showInResults) : BaseEntity
{
    public QuestionType Type { get; private set; } = type;
    public string Title { get; private set; } = title;
    public bool ShowInResults { get; private set; } = showInResults;
    public string Text { get; set; } = string.Empty;

    public Guid TemplateId { get; private set; } = templateId;
    public Template Template { get; set; } = default!;

    public void ChangeTitle(string title)
    {
        Title = title;
        SetUpdatedAt();
    }
}
