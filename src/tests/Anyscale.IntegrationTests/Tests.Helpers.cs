namespace Anyscale.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AnyscaleApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ANYSCALE_API_KEY") ??
            throw new AssertInconclusiveException("ANYSCALE_API_KEY environment variable is not found.");

        var client = new HttpClient();
        return new AnyscaleApi(apiKey, client);
    }
}
