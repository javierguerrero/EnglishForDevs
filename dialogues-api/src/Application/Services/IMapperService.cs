using Application.DTOs;
using Domain.Entities;

namespace Application.Services
{
    public interface IMapperService
    {
        Category ConvertToEntity(CategoryDto dto);

        Topic ConvertToEntity(TopicDto dto);

        Dialogue ConvertToEntity(DialogueDto dto);

        CategoryDto ConvertToDto(Category entity);

        TopicDto ConvertToDto(Topic entity);

        DialogueDto ConvertToDto(Dialogue entity);
    }
}