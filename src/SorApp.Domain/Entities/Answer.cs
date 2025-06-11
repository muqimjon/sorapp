namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class Answer(long formId, long questionId, string value) : BaseEntity
{
    public long FormId { get; private set; } = formId;
    public long QuestionId { get; private set; } = questionId;
    public string Value { get; private set; } = value;
}
