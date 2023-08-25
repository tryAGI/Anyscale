namespace Anyscale;

// ReSharper disable InconsistentNaming
#pragma warning disable CA1707

/// <summary>
/// According https://app.endpoints.anyscale.com/
/// </summary>
public static class ModelIds
{
    /// <summary>
    /// Meta developed and publicly released the Llama 2 family of large language models (LLMs),
    /// a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 70 billion parameters.
    /// Our fine-tuned LLMs, called Llama-2-Chat, are optimized for dialogue use cases.
    /// Llama-2-Chat models outperform open-source chat models on most benchmarks we tested,
    /// and in our human evaluations for helpfulness and safety, are on par with some popular closed-source models like ChatGPT and PaLM.
    /// </summary>
    public const string Llama2_7B = "meta-llama/Llama-2-7b-chat-hf";
    
    /// <summary>
    /// Meta developed and publicly released the Llama 2 family of large language models (LLMs),
    /// a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 70 billion parameters.
    /// Our fine-tuned LLMs, called Llama-2-Chat, are optimized for dialogue use cases.
    /// Llama-2-Chat models outperform open-source chat models on most benchmarks we tested,
    /// and in our human evaluations for helpfulness and safety, are on par with some popular closed-source models like ChatGPT and PaLM.
    /// </summary>
    public const string Llama2_13B = "meta-llama/Llama-2-13b-chat-hf";

    /// <summary>
    /// Meta developed and publicly released the Llama 2 family of large language models (LLMs),
    /// a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 70 billion parameters.
    /// Our fine-tuned LLMs, called Llama-2-Chat, are optimized for dialogue use cases.
    /// Llama-2-Chat models outperform open-source chat models on most benchmarks we tested,
    /// and in our human evaluations for helpfulness and safety, are on par with some popular closed-source models like ChatGPT and PaLM.
    /// </summary>
    public const string Llama2_70B = "meta-llama/Llama-2-70b-chat-hf";

    /// <summary>
    /// Code Llama is a collection of pretrained and fine-tuned generative text models ranging in scale from 7 billion to 34 billion parameters.
    /// This is the 34B parameter version, fine tuned for instructions.
    /// This model is designed for general code synthesis and understanding.
    /// </summary>
    public const string CodeLlama_34B = "codellama/CodeLlama-34b-Instruct-hf";

}