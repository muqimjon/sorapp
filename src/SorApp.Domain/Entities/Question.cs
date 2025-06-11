namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;
using SorApp.Domain.Enums;

public class Question(long templateId, QuestionType type, string title, bool showInResults) : BaseEntity
{
    public long TemplateId { get; private set; } = templateId;
    public QuestionType Type { get; private set; } = type;
    public string Title { get; private set; } = title;
    public bool ShowInResults { get; private set; } = showInResults;

    public void ChangeTitle(string title)
    {
        Title = title;
        SetUpdatedAt();
    }
}
