using AutoMapper;
using AutoMapper.Contracts;
using AutoMapper.Domain;

namespace AutoMapper13.UnitTests;

public class MappingProfileForAutoMapper13: Profile
{
    public MappingProfileForAutoMapper13()
    {
        CreateMap<FooDto, Foo>();
        CreateMap<BarDto, Bar>();
        // Replace the mapping above to fix the test
        // CreateMap<IBarDto, Bar>();
    } 
}