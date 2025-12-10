---
layout: post
title: Groq AI Integration with AI-Powered Text Editor | Syncfusion®
description: Learn how to implement a custom AI service using the Groq API with Syncfusion<sup>&reg;</sup> AI-Powered Text Editor (SfSmartTextEditor) control.
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Groq AI Integration with .NET MAUI Smart Text Editor

The Syncfusion [.NET MAUI Smart Text Editor] (SfSmartTextEditor) can show AI‑powered suggestions while you type. You can integrate `Groq` using the `IChatInferenceService` interface and Groq’s OpenAI‑compatible Chat Completions API for fast, low‑latency results.

## Setting Up Groq

1. **Create a Groq account & API key**  
   Visit [Groq Cloud Console](https://console.groq.com), and create an API key. Use the Authorization: Bearer {GROQ_API_KEY} header when calling the API
2. **Endpoint (OpenAI‑compatible)**  
   Chat Completions: POST https://api.groq.com/openai/v1/chat/completions.
3. **Choose a Model**  
   Refer to [Groq Models Documentation](https://console.groq.com/docs/models) for details on available models (e.g., `llama3-8b-8192`).

## Create a Groq AI Service

This service calls Groq’s Chat Completions endpoint and returns the first assistant message. It keeps your code simple and OpenAI‑compatible.

1. Create a `Services` folder in your project.
2. Add a new file named `GroqService.cs` in the `Services` folder.
3. Implement the service as shown below, storing the API key securely in a configuration file or environment variable (e.g., `appsettings.json` or environment variables).

{% tabs %}
{% highlight c# tabtitle="GroqService.cs" %}

using Microsoft.Extensions.AI;
using Syncfusion.Maui.SmartComponents;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GroqService
{
    private readonly string _apiKey;
    private readonly string _modelName = "llama3-8b-8192"; // Example model
    private readonly string _endpoint = "https://api.groq.com/openai/v1/chat/completions";
    private static readonly HttpClient HttpClient = new(new SocketsHttpHandler
    {
        PooledConnectionLifetime = TimeSpan.FromMinutes(30),
        EnableMultipleHttp2Connections = true
    })
    {
        DefaultRequestVersion = HttpVersion.Version20 // Fallback to HTTP/2 for broader compatibility
    };
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public GroqService(IConfiguration configuration)
    {
        _apiKey = configuration["Groq:ApiKey"] ?? throw new ArgumentNullException("Groq API key is missing.");
        if (!HttpClient.DefaultRequestHeaders.Contains("Authorization"))
        {
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }
    }

    public async Task<string> CompleteAsync(List<ChatMessage> chatMessages)
    {
        var requestPayload = new GroqChatParameters
        {
            Model = _modelName,
            Messages = chatMessages.Select(m => new Message
            {
                Role = m.Role == ChatRole.User ? "user" : "assistant",
                Content = m.Text
            }).ToList(),
            Stop = new List<string> { "END_INSERTION", "NEED_INFO", "END_RESPONSE" } // Configurable stop sequences
        };

        var content = new StringContent(JsonSerializer.Serialize(requestPayload, JsonOptions), Encoding.UTF8, "application/json");

        try
        {
            var response = await HttpClient.PostAsync(_endpoint, content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<GroqResponseObject>(responseString, JsonOptions);
            return responseObject?.Choices?.FirstOrDefault()?.Message?.Content ?? "No response from model.";
        }
        catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
        {
            throw new InvalidOperationException("Failed to communicate with Groq API.", ex);
        }
    }
}

{% endhighlight %}
{% endtabs %}

N> Store the Groq API key in `appsettings.json` (e.g., `{ "Groq": { "ApiKey": "your-api-key" } }`) or as an environment variable to ensure security.

## Define Request and Response Models

Create a file named `GroqModels.cs` in the Services folder and add:

{% tabs %}
{% highlight c# tabtitle="GroqModels.cs" %}

public class Choice
{
    public Message? Message { get; set; }
}

public class Message
{
    public string? Role { get; set; }
    public string? Content { get; set; }
}

public class GroqChatParameters
{
    public string? Model { get; set; }
    public List<Message>? Messages { get; set; }
    public List<string>? Stop { get; set; }
}

public class GroqResponseObject
{
    public string? Model { get; set; }
    public List<Choice>? Choices { get; set; }
}

{% endhighlight %}
{% endtabs %}

## Implement IChatInferenceService

Create `GroqInferenceService.cs`:

{% tabs %}
{% highlight c# tabtitle="GroqInferenceService.cs" %}

using Syncfusion.Maui.SmartComponents;

public class GroqInferenceService : IChatInferenceService
{
    private readonly GroqService _groqService;

    public GroqInferenceService(GroqService groqService)
    {
        _groqService = groqService;
    }

    public async Task<string> GenerateResponseAsync(List<ChatMessage> chatMessages)
    {
        return await _groqService.CompleteAsync(chatMessages);
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

builder.Services.AddSingleton<GroqService>();
builder.Services.AddSingleton<IChatInferenceService, GroqInferenceService>();


{% endhighlight %}
{% endtabs %}