namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class Answer(Guid formId, Guid questionId, string value) : BaseEntity
{
    public Guid FormId { get; private set; } = formId;
    public Guid QuestionId { get; private set; } = questionId;
    public string Value { get; private set; } = value;
}
