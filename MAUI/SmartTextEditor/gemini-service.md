---
layout: post
title: Gemini AI Integration with .NET MAUI Smart Text Editor | Syncfusion
description: Learn how to implement a custom AI service using Google's Gemini API with Syncfusion<sup>&reg;</sup> Smart Text Editor (SfSmartTextEditor) control.
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Gemini AI Integration with .NET MAUI Smart Text Editor

The Syncfusion [.NET MAUI Smart Text Editor] provides AI-powered suggestions for context-aware text input. By default, it works with providers like OpenAI or Azure OpenAI, but you can integrate `Google Gemini AI` using the `IChatInferenceService` interface. This guide explains how to implement and register Gemini AI for the Smart Text Editor in a .NET MAUI app.

## Setting Up Gemini

1. **Get a Gemini API Key**  
   Visit [Google AI Studio](https://ai.google.dev/gemini-api/docs/api-key), sign in, and generate an API key.
2. **Review Model Details**  
   Refer to [Gemini Models Documentation](https://ai.google.dev/gemini-api/docs/models) for details on available models.

## Create a Gemini AI Service

Create a service class to handle `Gemini API` calls, including authentication, request/response handling, and safety settings.

1. Create a `Services` folder in your MAUI project.
2. Add a new file named `GeminiService.cs` in the Services folder.
3. Implement the service as shown below:

{% tabs %}
{% highlight c# tabtitle="GeminiService.cs" %}

using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

public class GeminiService
{
    private readonly string _apiKey = "";
    private readonly string _modelName = "gemini-2.0-flash"; // Example model
    private readonly string _endpoint = "https://generativelanguage.googleapis.com/v1beta/models/";
    private static readonly HttpClient HttpClient = new(new SocketsHttpHandler
    {
        PooledConnectionLifetime = TimeSpan.FromMinutes(30),
        EnableMultipleHttp2Connections = true
    })
    {
        DefaultRequestVersion = HttpVersion.Version20
    };

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public GeminiService(IConfiguration configuration)
    {
        HttpClient.DefaultRequestHeaders.Clear();
        HttpClient.DefaultRequestHeaders.Add("x-goog-api-key", _apiKey);
    }

    public async Task<string> CompleteAsync(List<ChatMessage> chatMessages)
    {
        var requestUri = $"{_endpoint}{_modelName}:generateContent";
        var parameters = BuildGeminiChatParameters(chatMessages);
        var payload = new StringContent(JsonSerializer.Serialize(parameters, JsonOptions), Encoding.UTF8, "application/json");

        try
        {
            using var response = await HttpClient.PostAsync(requestUri, payload);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<GeminiResponseObject>(json, JsonOptions);
            return result?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text ?? "No response from model.";
        }
        catch (Exception ex) when (ex is HttpRequestException or JsonException)
        {
            throw new InvalidOperationException("Gemini API error.", ex);
        }
    }

    private GeminiChatParameters BuildGeminiChatParameters(List<ChatMessage> messages)
    {
        var contents = messages.Select(m => new ResponseContent(m.Text, m.Role == ChatRole.User ? "user" : "model")).ToList();
        return new GeminiChatParameters
        {
            Contents = contents,
            GenerationConfig = new GenerationConfig
            {
                MaxOutputTokens = 2000,
                StopSequences = new List<string> { "END_INSERTION", "NEED_INFO", "END_RESPONSE" }
            },
            SafetySettings = new List<SafetySetting>
        {
            new() { Category = "HARM_CATEGORY_HARASSMENT", Threshold = "BLOCK_ONLY_HIGH" },
            new() { Category = "HARM_CATEGORY_HATE_SPEECH", Threshold = "BLOCK_ONLY_HIGH" },
            new() { Category = "HARM_CATEGORY_SEXUALLY_EXPLICIT", Threshold = "BLOCK_ONLY_HIGH" },
            new() { Category = "HARM_CATEGORY_DANGEROUS_CONTENT", Threshold = "BLOCK_ONLY_HIGH" },
            new() { Category = "HARM_CATEGORY_DANGEROUS_CONTENT", Threshold = "BLOCK_ONLY_HIGH" },
        }
        };
    }
}

{% endhighlight %}
{% endtabs %}

N> Store the Gemini API key securely in appsettings.json or as an environment variable.

## Define Request and Response Models

Create a file named `GeminiModels.cs` in the Services folder and add:

{% tabs %}
{% highlight c# tabtitle="GeminiModels.cs" %}


public class Part { public string Text { get; set; } }
public class Content { public Part[] Parts { get; init; } = Array.Empty<Part>(); }
public class Candidate { public Content Content { get; init; } = new(); }
public class GeminiResponseObject { public Candidate[] Candidates { get; init; } = Array.Empty<Candidate>(); }

public class ResponseContent
{
    public List<Part> Parts { get; init; }
    public string Role { get; init; }
    public ResponseContent(string text, string role)
    {
        Parts = new List<Part> { new Part { Text = text } };
        Role = role;
    }
}

public class GenerationConfig
{
    public int MaxOutputTokens { get; init; } = 2048;
    public List<string> StopSequences { get; init; } = new();
}

public class SafetySetting
{
    public string Category { get; init; } = string.Empty;
    public string Threshold { get; init; } = string.Empty;
}

public class GeminiChatParameters
{
    public List<ResponseContent> Contents { get; init; } = new();
    public GenerationConfig GenerationConfig { get; init; } = new();
    public List<SafetySetting> SafetySettings { get; init; } = new();
}

{% endhighlight %}
{% endtabs %}

## Implement IChatInferenceService

Create `GeminiInferenceService.cs`:

{% tabs %}
{% highlight c# tabtitle="GeminiInferenceService.cs" %}


using Syncfusion.Maui.SmartComponents;

public class GeminiInferenceService : IChatInferenceService
{
    private readonly GeminiService _geminiService;

    public GeminiInferenceService(GeminiService geminiService)
    {
        _geminiService = geminiService;
    }

    public async Task<string> GenerateResponseAsync(List<ChatMessage> chatMessages)
    {
        return await _geminiService.CompleteAsync(chatMessages);
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

builder.Services.AddSingleton<GeminiService>();
builder.Services.AddSingleton<IChatInferenceService, GeminiInferenceService>();


{% endhighlight %}
{% endtabs %}