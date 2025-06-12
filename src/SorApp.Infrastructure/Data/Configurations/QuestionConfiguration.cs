namespace SorApp.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SorApp.Domain.Entities;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(q => q.Title)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(q => q.Type)
               .HasConversion<string>();

        builder.Property(q => q.ShowInResults)
               .IsRequired();

        builder.Property(q => q.Text)
               .HasMaxLength(1000);
    }
}