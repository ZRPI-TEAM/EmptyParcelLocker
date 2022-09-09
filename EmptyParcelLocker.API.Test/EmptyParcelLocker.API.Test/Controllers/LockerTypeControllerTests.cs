using EmptyParcelLocker.API.Controllers;
using EmptyParcelLocker.API.Services;
using EmptyParcelLocker.API.Test.MockData;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace EmptyParcelLocker.API.Test.Controllers;

public class LockerTypeControllerTests
{
    [Fact]
    public async Task GetLockerTypesAsync_ShouldReturn200Status()
    {
        // Arrange
        var emptyParcelLockerService = new Mock<IEmptyParcelLockerService>();
        emptyParcelLockerService.Setup(_ => _.GetLockerTypesAsync()).ReturnsAsync(LockerTypeMockData.GetLockerTypes());
        var sut = new LockerTypeController(emptyParcelLockerService.Object);
        
        // Act
        var result = (OkObjectResult) await sut.GetLockerTypesAsync();

        // Assert
        result.StatusCode.Should().Be(200);
    }
}