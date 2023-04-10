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
                .ForMember(dest => dest.Id, source => source.MapFrom(source => source.Id))
                .ReverseMap();

            CreateMap<Topic, TopicDto>()
                .ForMember(dest => dest.Id, source => source.MapFrom(source => source.Id))
                .ReverseMap();

            CreateMap<Dialogue, DialogueDto>()
                .ForMember(dest => dest.Id, source => source.MapFrom(source => source.Id))
                .ReverseMap();

        }
    }
}