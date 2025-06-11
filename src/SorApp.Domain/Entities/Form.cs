namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class Form(long templateId, long respondentId) : BaseEntity
{
    public long TemplateId { get; private set; } = templateId;
    public long RespondentId { get; private set; } = respondentId;
    public DateTime SubmittedAt { get; private set; } = DateTime.UtcNow;
    public List<Answer> Answers { get; private set; } = [];

    public void AddAnswer(Answer a) => Answers.Add(a);
}
