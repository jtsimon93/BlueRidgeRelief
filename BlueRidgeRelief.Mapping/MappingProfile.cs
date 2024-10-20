using AutoMapper;
using BlueRidgeRelief.Core.Entities;
using BlueRidgeRelief.DTOs;

namespace BlueRidgeRelief.Mapping;

public class MappingProfile : Profile
{

    public MappingProfile()
    {
        CreateMap<Need, NeedDto>().ReverseMap();
        CreateMap<NeedCreateDto, Need>().ReverseMap();
    }
    
}