---
layout: post
title: Custom AI Service in .NET MAUI AI-Powered Text Editor control | Syncfusion<sup>&reg;</sup>
description: Learn how to use IChatInferenceService to integrate custom AI services with Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Text Editor (SfSmartTextEditor) control
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# Custom AI Service Integration with .NET MAUI Smart Text Editor

The Syncfusion .NET MAUI AI-Powered Text Editor can use AI to provide intelligent suggestions while typing. By default, it works with providers like `OpenAI` or `Azure OpenAI` or `ollama`, but you can also integrate your own AI service using the `IChatInferenceService` interface. This interface ensures smooth communication between the smart text editor and your custom AI logic.

## IChatInferenceService Interface

The `IChatInferenceService` interface defines how the Smart Text Editor interacts with an AI service. It sends user input and context messages and expects an AI-generated response.

{% tabs %}
{% highlight xaml tabtitle="C#" %}

using Syncfusion.Maui.SmartComponents;

Public interface IChatInferenceService
{
    Task<string> GenerateResponseAsync(List<ChatMessage> chatMessages);
}

{% endhighlight %}
{% endtabs %}

- **Purpose**: Provides a standard way to connect any AI service.
- **Parameter**: The `chatMessages` contains the user’s text and previous context.
- **Benefit**: Lets you switch AI providers without changing the editor code.

## Custom AI Service Implementation

Here’s a simple example of a mock AI service that implements `IChatInferenceService`. You can replace the logic with your own AI integration:

{% tabs %}
{% highlight xaml tabtitle="C#" %}

using Microsoft.Extensions.AI;
using Syncfusion.Maui.SmartComponents;

public class MockAIService : IChatInferenceService
{
    public Task<string> GenerateResponseAsync(List<ChatMessage> chatMessages);
    {

    }
}

{% endhighlight %}
{% endtabs %}

## Registering the Custom AI Service

Register the custom AI service in **MauiProgram.cs**:

{% tabs %}
{% highlight xaml tabtitle="C#" %}

using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.SmartComponents;

var builder = MauiApp.CreateBuilder()
....

builder.Services.AddSingleton<IChatInferenceService, MockAIService>();

{% endhighlight %}
{% endtabs %}

## How to test Custom AI Integration

1. Implement and register your custom AI service.
2. Add SfSmartTextEditor to your page.
3. Run the app and start typing.
4. Check if suggestions appear based on your AI logic.
5. Use SuggestionDisplayMode to choose Inline or Popup display.

## Implemented AI Services

Here are examples of AI services integrated using the `IChatInferenceService` interface:

| Service | Documentation |
|---------|---------------|
| Claude | [Claude Integration](claude-service) |
| DeepSeek | [DeepSeek Integration](deepseek-service) |
| Groq | [Groq Integration](groq-service) |
| Gemini | [Gemini Integration](gemini-service) |

## Troubleshooting

If the custom AI service does not work as expected, try the following:
- **No Suggestions Displayed**: Ensure the `IChatInferenceService` implementation is registered in **MauiProgram.cs** and returns valid responses. Check for errors in the `GenerateResponseAsync` method.