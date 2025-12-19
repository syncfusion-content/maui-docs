---
layout: post
title: Claude AI for AI-Powered Components | Syncfusion®
description: Learn how to implement a custom AI service using the Claude API with Syncfusion<sup>&reg;</sup> AI-Powered Components.
platform: maui
control: SmartComponents
documentation: ug
---

# Claude AI Integration with .NET MAUI Smart Components

The Syncfusion .NET MAUI AI-powered components can enhance applications with intelligent capabilities. You can integrate Anthropic `Claude AI` using the `IChatInferenceService` interface, which acts as a bridge between the editor and your custom AI service.

## Setting Up Claude

1. **Create an Anthropic Account**  
   Visit [Anthropic Console](https://console.anthropic.com), sign up, and complete the verification process.
2. **Obtain an API Key**  
   Navigate to [API Keys](https://console.anthropic.com/settings/keys) and click "Create Key."
3. **Review Model Specifications**  
   Refer to [Claude Models Documentation](https://docs.anthropic.com/claude/docs/models-overview) for details on available models.

## Define Request and Response Models

Create a file named `ClaudeModels.cs` in the Services folder and add:

{% tabs %}
{% highlight c# tabtitle="ClaudeModels.cs" %}

public class ClaudeChatRequest
{
    public string? Model { get; set; }
    public int Max_tokens { get; set; }
    public List<ClaudeMessage>? Messages { get; set; }
    public List<string>? Stop_sequences  { get; set; }
}

public class ClaudeMessage
{
    public string? Role { get; set; }
    public string? Content { get; set; }
}

public class ClaudeChatResponse
{
    public List<ClaudeContentBlock>? Content { get; set; }
}

public class ClaudeContentBlock
{
    public string? Text { get; set; }
}

{% endhighlight %}
{% endtabs %}

## Create a Claude AI Service

This service handles communication with the Claude API, including authentication and response parsing.

1. Create a `Services` folder in your project.
2. Add a new file named `ClaudeAIService.cs` in the `Services` folder.
3. Implement the service as shown below:

{% tabs %}
{% highlight c# tabtitle="ClaudeAIService.cs" %}

using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

public class ClaudeAIService
{
    private readonly string _apiKey = ""; // API key
    private readonly string _modelName = "claude-3-5-sonnet-20241022"; // Example model
    private readonly string _endpoint = "https://api.anthropic.com/v1/messages";
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

    public ClaudeAIService()
    {
        if (!HttpClient.DefaultRequestHeaders.Contains("x-api-key"))
        {
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Add("x-api-key", _apiKey);
            HttpClient.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01"); // Check latest version in Claude API docs
        }
    }

    public async Task<string> CompleteAsync(List<ChatMessage> chatMessages)
    {
        var requestBody = new ClaudeChatRequest
        {
            Model = _modelName,
            Max_tokens = 1000, // Maximum tokens in response
            Messages = chatMessages.Select(m => new ClaudeMessage
            {
                Role = m.Role == ChatRole.User ? "user" : "assistant",
                Content = m.Text
            }).ToList(),
            Stop_sequences  = new List<string> { "END_INSERTION", "NEED_INFO", "END_RESPONSE" } // Configurable stop sequences
        };

        var content = new StringContent(JsonSerializer.Serialize(requestBody, JsonOptions), Encoding.UTF8, "application/json");

        try
        {
            var response = await HttpClient.PostAsync(_endpoint, content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<ClaudeChatResponse>(responseString, JsonOptions);
            return responseObject?.Content?.FirstOrDefault()?.Text ?? "No response from Claude model.";
        }
        catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
        {
            throw new InvalidOperationException("Failed to communicate with Claude API.", ex);
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Implement IChatInferenceService

Create `ClaudeInferenceService.cs`:

{% tabs %}
{% highlight c# tabtitle="ClaudeInferenceService.cs" %}

using Syncfusion.Maui.SmartComponents;

public class ClaudeInferenceService : IChatInferenceService
{
    private readonly ClaudeAIService _claudeService;

    public ClaudeInferenceService(ClaudeAIService claudeService)
    {
        _claudeService = claudeService;
    }

    public async Task<string> GenerateResponseAsync(List<ChatMessage> chatMessages)
    {
        return await _claudeService.CompleteAsync(chatMessages);
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

builder.Services.AddSingleton<ClaudeAIService>();
builder.Services.AddSingleton<IChatInferenceService, ClaudeInferenceService>();


{% endhighlight %}
{% endtabs %}