namespace SorApp.Application;

using Microsoft.Extensions.DependencyInjection;
using SorApp.Application.Common.Interfaces;
using SorApp.Application.Common.Mappings;
using SorApp.Application.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile).Assembly);

        services.AddScoped<ITemplateService, TemplateService>();
        services.AddScoped<IQuestionService, QuestionService>();
        services.AddScoped<IFormService, FormService>();
        services.AddScoped<ICommentService, CommentService>();

        return services;
    }
}
