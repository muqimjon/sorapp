namespace SorApp.Application.Common.Mappings;

using AutoMapper;
using SorApp.Application.DTOs;
using SorApp.Domain.Entities;
using SorApp.Domain.Enums;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Template <-> TemplateDto
        CreateMap<Template, TemplateDto>()
            .ForMember(d => d.Status, o => o.MapFrom(s => s.Status.ToString()));
        CreateMap<TemplateDto, Template>()
            .ForMember(d => d.Status, o => o.MapFrom(s => Enum.Parse<TemplateStatus>(s.Status)));

        // Question <-> QuestionDto
        CreateMap<Question, QuestionDto>()
            .ForMember(d => d.Type, o => o.MapFrom(s => s.Type.ToString()));
        CreateMap<QuestionDto, Question>()
            .ConstructUsing(dto =>
                new Question(dto.TemplateId, Enum.Parse<QuestionType>(dto.Type), dto.Title, dto.ShowInResults));

        // Form <-> FormDto
        CreateMap<Form, FormDto>();
        CreateMap<FormDto, Form>()
            .ConstructUsing(dto => new Form(dto.TemplateId, dto.RespondentId));

        // Answer <-> AnswerDto
        CreateMap<Answer, AnswerDto>();
        CreateMap<AnswerDto, Answer>()
            .ConstructUsing(dto => new Answer(dto.FormId, dto.QuestionId, dto.Value));

        // Comment <-> CommentDto
        CreateMap<Comment, CommentDto>();

        // User <-> UserDto
        CreateMap<User, UserDto>().ReverseMap();
    }
}
