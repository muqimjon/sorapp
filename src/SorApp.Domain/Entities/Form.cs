namespace SorApp.Domain.Entities;

using SorApp.Domain.Common;

public class Form(Guid templateId, Guid respondentId) : BaseEntity
{
    public Guid TemplateId { get; private set; } = templateId;
    public Guid RespondentId { get; private set; } = respondentId;
    public DateTimeOffset SubmittedAt { get; private set; } = DateTimeOffset.UtcNow;
    public List<Answer> Answers { get; private set; } = [];

    public void AddAnswer(Answer a) => Answers.Add(a);
}
