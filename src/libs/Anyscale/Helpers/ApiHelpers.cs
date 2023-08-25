namespace Anyscale;

#pragma warning disable CS0618

/// <summary>
/// According https://app.endpoints.anyscale.com/ <br/>
/// </summary>
public static class ApiHelpers
{
    /// <summary>
    /// Supports Llama 2 and CodeLlama models <br/>
    /// According https://app.endpoints.anyscale.com/ <br/>
    /// </summary>
    /// <param name="modelId">The model id we want to know the context size for.</param>
    /// <param name="completionTokens"></param>
    /// <param name="promptTokens"></param>
    /// <returns>The maximum context size</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double CalculatePriceInUsd(string modelId, int completionTokens, int promptTokens)
    {
        var pricePerToken = modelId switch
        {
            // Llama2 models
            ModelIds.Llama2_7B => 0.25 * 0.001 * 0.001,
            ModelIds.Llama2_13B => 0.50 * 0.001 * 0.001,
            ModelIds.Llama2_70B => 1.00 * 0.001 * 0.001,
            
            ModelIds.CodeLlama_34B => throw new NotImplementedException(),
            
            _ => throw new NotImplementedException(),
        };
        
        return completionTokens * pricePerToken +
               promptTokens * pricePerToken;
    }
    
    /// <summary>
    /// Calculates the maximum number of tokens possible to generate for a model. <br/>
    /// Returns the maximum input number of tokens for a embedding model. <br/>
    /// According https://platform.openai.com/docs/models/overview <br/>
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int CalculateContextLength(string modelId)
    {
        return modelId switch
        {
            // Llama2 models
            ModelIds.Llama2_7B => 4_096,
            ModelIds.Llama2_13B => 4_096,
            ModelIds.Llama2_70B => 4_096,
            
            ModelIds.CodeLlama_34B => 100_000,
            
            _ => throw new NotImplementedException(),
        };
    }
}