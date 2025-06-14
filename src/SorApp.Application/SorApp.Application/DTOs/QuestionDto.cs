namespace SorApp.Application.DTOs;

public class QuestionDto
{
    public Guid Id { get; set; }
    public Guid TemplateId { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public bool ShowInResults { get; set; }
}