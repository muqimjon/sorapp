﻿namespace SorApp.Application.DTOs;

public class CommentDto
{
    public Guid Id { get; set; }
    public Guid TemplateId { get; set; }
    public Guid AuthorId { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}