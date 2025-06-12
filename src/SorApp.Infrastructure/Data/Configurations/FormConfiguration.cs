namespace SorApp.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SorApp.Domain.Entities;

public class FormConfiguration : IEntityTypeConfiguration<Form>
{
    public void Configure(EntityTypeBuilder<Form> builder)
    {
        builder.HasKey(f => f.Id);

        builder.HasMany(f => f.Answers)
               .WithOne()
               .HasForeignKey(a => a.FormId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}