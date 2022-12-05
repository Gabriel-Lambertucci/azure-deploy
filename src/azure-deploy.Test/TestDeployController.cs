using FluentAssertions;

namespace AzureDeploy.Test;

public class TestDeployController
{
    /// <summary>
    /// This function is to test the api controller requests
    /// </summary>
    [Fact]
    public async void TestGetStatusCodeSuccess()
    {
        var application = new WebApplication();
        var response = await application.ApiGetRequest("/Deploy");
        var result = await response.Content.ReadAsStringAsync();
        result. Should().Be("Estou realizando o deploy da minha API utilizando Azure");
    }
}