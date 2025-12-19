---
layout: post
title: DeepSeek AI for AI-Powered Components | Syncfusion®
description: Learn how to integrate the DeepSeek AI services with Syncfusion<sup>&reg;</sup> AI-Powered Components.
platform: maui
control: SmartComponents
documentation: ug
---

# DeepSeek AI Integration with .NET MAUI Smart Components

The Syncfusion .NET MAUI AI-powered components can enhance applications with intelligent capabilities. You can integrate DeepSeek using the `IChatInferenceService` interface, which standardizes communication between the editor and your custom AI service.

## Setting Up DeepSeek

1. **Obtain a DeepSeek API Key**  
   Create an account at [DeepSeek Platform](https://platform.deepseek.com), sign in, and navigate to [API Keys](https://platform.deepseek.com/api_keys) to generate an API key.
2. **Review Model Specifications**  
   Refer to [DeepSeek Models Documentation](https://api-docs.deepseek.com/quick_start/pricing) for details on available models (e.g., `deepseek-chat`).

## Create a DeepSeek AI Service

This service manages requests to the `DeepSeek` Chat Completions endpoint and returns the generated text.

1. Create a `Services` folder in your project.
2. Add a new file named `DeepSeekAIService.cs` in the `Services` folder.
3. Implement the service as shown below:

{% tabs %}
{% highlight c# tabtitle="DeepSeekAIService.cs" %}

using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Text;
using System.Text.Json;

public class DeepSeekAIService
{
    private readonly string _apiKey = ""; // API key
    private readonly string _modelName = "deepseek-chat"; // Example model
    private readonly string _endpoint = "https://api.deepseek.com/v1/chat/completions";
    private static readonly HttpClient HttpClient = new(new SocketsHttpHandler
    {
        PooledConnectionLifetime = TimeSpan.FromMinutes(30),
        EnableMultipleHttp2Connections = true
    })
    {
        DefaultRequestVersion = HttpVersion.Version20 // Fallback to HTTP/2 for compatibility
    };
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public DeepSeekAIService(IConfiguration configuration)
    {
        if (!HttpClient.DefaultRequestHeaders.Contains("Authorization"))
        {
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }
    }

    public async Task<string> CompleteAsync(List<ChatMessage> chatMessages)
    {
        var requestBody = new DeepSeekChatRequest
        {
            Model = _modelName,
            Temperature = 0.7f, // Controls response randomness (0.0 to 1.0)
            Messages = chatMessages.Select(m => new DeepSeekMessage
            {
                Role = m.Role == ChatRole.User ? "user" : "system", // Align with DeepSeek API roles
                Content = m.Text
            }).ToList()
        };

        var content = new StringContent(JsonSerializer.Serialize(requestBody, JsonOptions), Encoding.UTF8, "application/json");

        try
        {
            var response = await HttpClient.PostAsync(_endpoint, content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<DeepSeekChatResponse>(responseString, JsonOptions);
            return responseObject?.Choices?.FirstOrDefault()?.Message?.Content ?? "No response from DeepSeek.";
        }
        catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
        {
            throw new InvalidOperationException("Failed to communicate with DeepSeek API.", ex);
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Define Request and Response Models

Create a file named `DeepSeekModels.cs` in the Services folder and add:

{% tabs %}
{% highlight c# tabtitle="DeepSeekModels.cs" %}

public class DeepSeekMessage
{
    public string? Role { get; set; }
    public string? Content { get; set; }
}

public class DeepSeekChatRequest
{
    public string? Model { get; set; }
    public float Temperature { get; set; }
    public List<DeepSeekMessage>? Messages { get; set; }
}

public class DeepSeekChatResponse
{
    public List<DeepSeekChoice>? Choices { get; set; }
}

public class DeepSeekChoice
{
    public DeepSeekMessage? Message { get; set; }
}

{% endhighlight %}
{% endtabs %}

## Implement IChatInferenceService

Create `DeepSeekInferenceService.cs`:

{% tabs %}
{% highlight c# tabtitle="DeepSeekInferenceService.cs" %}

using Syncfusion.Maui.SmartComponents;

public class DeepSeekInferenceService : IChatInferenceService
{
    private readonly DeepSeekAIService _deepSeekService;

    public DeepSeekInferenceService(DeepSeekAIService deepSeekService)
    {
        _deepSeekService = deepSeekService;
    }

    public async Task<string> GenerateResponseAsync(List<ChatMessage> chatMessages)
    {
        return await _deepSeekService.CompleteAsync(chatMessages);
    }
}

{% endhighlight %}
{% endtabs %}

## Register Services in MAUI

Update `MauiProgram.cs`:

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="9 10" %}

using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.SmartComponents;

var builder = MauiApp.CreateBuilder();
builder
    .UseMauiApp<App>()
    .ConfigureSyncfusionCore();

builder.Services.AddSingleton<DeepSeekAIService>();
builder.Services.AddSingleton<IChatInferenceService, DeepSeekInferenceService>();


{% endhighlight %}
{% endtabs %}