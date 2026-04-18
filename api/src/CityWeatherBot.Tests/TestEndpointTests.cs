using Microsoft.AspNetCore.Mvc.Testing;

namespace CityWeatherBot.Tests;

public class TestEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public TestEndpointTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetTest_ReturnsTrue()
    {
        var response = await _client.GetAsync("/test");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("true", content);
    }
}
