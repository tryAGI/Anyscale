# Anyscale

[![Nuget package](https://img.shields.io/nuget/vpre/Anyscale)](https://www.nuget.org/packages/Anyscale/)
[![dotnet](https://github.com/tryAGI/Anyscale/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Anyscale/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Anyscale)](https://github.com/tryAGI/Anyscale/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

SDK for Anyscale Endpoint that makes it easy and cheap to use LLama 2

### Usage
```csharp
using Anyscale;

using var httpClient = new HttpClient();
var api = new AnyscaleApi(apiKey, httpClient);
var response = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Messages = new List<ChatCompletionRequestMessage>
    {
        "You are a helpful weather assistant.".AsSystemMessage(),
        "What's the weather like today?".AsUserMessage(),
    },
    Model = ModelIds.Llama2_70B,
});
var message = result.GetFirstChoiceMessage().Content;
```

## Support

Priority place for bugs: https://github.com/tryAGI/Anyscale/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Anyscale/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  