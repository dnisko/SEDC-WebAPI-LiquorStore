using AutoMapper;
using Xunit;
using Mappers; // Adjust namespace to where your mapping profile is
using DomainModels; // Adjust namespace to where your domain models are
using DTOs; // Adjust namespace to where your DTOs are

public class xUnitTest
{
    [Fact]
    public void AutoMapper_Configuration_IsValid()
    {
        // Arrange
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<UserMappingProfile>();
            // Add other profiles if needed
        });

        // Act & Assert
        config.AssertConfigurationIsValid();
    }
}