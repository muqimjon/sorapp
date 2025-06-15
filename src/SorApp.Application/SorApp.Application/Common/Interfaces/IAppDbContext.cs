namespace SorApp.Application.Common.Interfaces;

using Microsoft.EntityFrameworkCore;
using SorApp.Domain.Entities;

public interface IAppDbContext
{
    DbSet<Template> Templates { get; }
    DbSet<Question> Questions { get; }
    DbSet<Form> Forms { get; }
    DbSet<Answer> Answers { get; }
    DbSet<Comment> Comments { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
