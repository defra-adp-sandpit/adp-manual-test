using Adp.Manual.Test.Api.HealthChecks;

using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Adp.Manual.Test.Api.Tests.HealthChecksTests;

public class ReadinessCheckTests
{
    private readonly ReadinessCheck _sut = new();

    [Fact]
    public async Task CheckHealthAsync_Returns_Healthy()
    {
        //Arrange
        var mockContext = new HealthCheckContext();
        var cancellationToken = new CancellationToken();

        //Act
        var result = await _sut.CheckHealthAsync(mockContext, cancellationToken);

        //Assert
        result.Should().BeEquivalentTo(HealthCheckResult.Healthy("OK"));
    }
}