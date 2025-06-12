using AutoMapper.Contracts;
using AutoMapper.Domain;

namespace AutoMapper.UnitTests;

public class MappingProfileForAutoMapper12: Profile
{
    public MappingProfileForAutoMapper12()
    {
        CreateMap<FooDto, Foo>();
        CreateMap<BarDto, Bar>();
    } 
}