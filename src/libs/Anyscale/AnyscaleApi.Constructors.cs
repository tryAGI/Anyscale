using System.Net.Http.Headers;
using tryAGI.OpenAI;

namespace Anyscale;

/// <summary>
/// Class providing methods for API access.
/// </summary>
public partial class AnyscaleApi
{
    private OpenAiApi OpenAiApi { get; }
    
    /// <summary>
    /// Sets the selected apiKey as a default header for the HttpClient.
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="httpClient"></param>
    public AnyscaleApi(string apiKey, HttpClient httpClient)
    {
        apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        OpenAiApi = new OpenAiApi(apiKey, httpClient)
        {
            BaseUrl = "https://api.endpoints.anyscale.com/v1",
        };
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Creates a model response for the given chat conversation.
    /// </summary>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<CreateChatCompletionResponse> CreateChatCompletionAsync(
        CreateChatCompletionRequest body,
        CancellationToken cancellationToken = default)
    {
        return await OpenAiApi.CreateChatCompletionAsync(body, cancellationToken).ConfigureAwait(false);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Lists the currently available models, and provides basic information about each one such as the owner and availability.
    /// </summary>
    /// <returns>OK</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ListModelsResponse> ListModelsAsync(CancellationToken cancellationToken = default)
    {
        return await OpenAiApi.ListModelsAsync(cancellationToken).ConfigureAwait(false);
    }
}
