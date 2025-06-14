namespace SorApp.Application.DTOs;

public class FormDto
{
    public Guid Id { get; set; }
    public Guid TemplateId { get; set; }
    public Guid RespondentId { get; set; }
    public DateTimeOffset SubmittedAt { get; set; }
}