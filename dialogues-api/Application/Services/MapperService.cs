using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class MapperService : IMapperService
    {
        private readonly IMapper _autoMapper;

        public MapperService(IMapper autoMapper)
        {
            _autoMapper = autoMapper;
        }

        public CategoryDto ConvertToDto(Category entity)
        {
            return _autoMapper.Map<CategoryDto>(entity);
        }

        public TopicDto ConvertToDto(Topic entity)
        {
            return _autoMapper.Map<TopicDto>(entity);
        }

        public Category ConvertToEntity(CategoryDto dto)
        {
            return _autoMapper.Map<Category>(dto);
        }

        public Topic ConvertToEntity(TopicDto dto)
        {
            return _autoMapper.Map<Topic>(dto);
        }
    }
}