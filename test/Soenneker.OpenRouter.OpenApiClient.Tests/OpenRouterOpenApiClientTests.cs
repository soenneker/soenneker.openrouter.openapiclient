using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenRouter.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenRouterOpenApiClientTests : HostedUnitTest
{
    public OpenRouterOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
