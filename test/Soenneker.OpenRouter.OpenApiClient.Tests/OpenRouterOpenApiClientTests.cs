using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenRouter.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenRouterOpenApiClientTests : FixturedUnitTest
{
    public OpenRouterOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
