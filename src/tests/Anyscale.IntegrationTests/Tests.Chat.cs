using tryAGI.OpenAI;

namespace Anyscale.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateChatCompletion()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Messages = new List<ChatCompletionRequestMessage>
            {
                "You are a helpful weather assistant.".AsSystemMessage(),
                "What's the weather like today?".AsUserMessage(),
            },
            Model = ModelIds.Llama2_70B,
            User = "Anyscale.IntegrationTests.Tests.CreateChatCompletion",
        });
        response.GetFirstChoiceMessage().Content.Should().NotBeEmpty();

        Console.WriteLine(response.GetFirstChoiceMessage().Content);
    }
}
