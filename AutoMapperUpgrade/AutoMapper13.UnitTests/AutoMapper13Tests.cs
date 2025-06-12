using AutoMapper;
using NUnit.Framework;

namespace AutoMapper13.UnitTests;

public class AutoMapper13Tests
{
    [Test]
    public void MapperConfiguration_ShouldBeValid()
    {
        var mapperConfigExpression = new MapperConfigurationExpression();

        mapperConfigExpression.DisableConstructorMapping(); // ensure that automapper doesn't try to use non-empty constructors mapping from source member
        mapperConfigExpression.DestinationMemberNamingConvention = ExactMatchNamingConvention.Instance;
        
        foreach (var profile in new []
                 {
                    new MappingProfileForAutoMapper13() 
                 })
        {
            profile.DestinationMemberNamingConvention = mapperConfigExpression.DestinationMemberNamingConvention;

            mapperConfigExpression.AddProfile(profile);
        }

        var mapperConfig = new MapperConfiguration(mapperConfigExpression);

        mapperConfig.AssertConfigurationIsValid();
    }
}