using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.Name, source => source.MapFrom(source => source.Name))
                .ReverseMap();

            CreateMap<Topic, TopicDto>()
                .ForMember(dest => dest.Name, source => source.MapFrom(source => source.Name))
                .ReverseMap();

        }
    }
}