using EmptyParcelLocker.API.Controllers;
using EmptyParcelLocker.API.Services;
using EmptyParcelLocker.API.Test.MockData;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace EmptyParcelLocker.API.Test.Controllers;

public class LockerControllerTests
{
    [Fact]
    public async Task GetLockersAsync_ShouldReturn200Status()
    {
        // Arrange
        var emptyParcelLockerService = new Mock<IEmptyParcelLockerService>();
        emptyParcelLockerService.Setup(_ => _.GetLockersAsync()).ReturnsAsync(LockerMockData.GetLockers(10));
        var systemUnderTest = new LockerController(emptyParcelLockerService.Object);

        // Act
        var result = (OkObjectResult) await systemUnderTest.GetLockersAsync();

        // Assert
        result.StatusCode.Should().Be(200);
    }
}