---
layout: post
title: Configure AI Service with AI-Powered Components | Syncfusion®
description: Learn how to implement a configure AI service with Syncfusion<sup>&reg;</sup> AI-Powered Components.
platform: maui
control: SmartComponents
documentation: ug
---

# Configure AI Service With Smart Components

The Smart Components uses a chat inference service resolved from dependency injection to generate contextual suggestions. Register a compatible chat client and an inference adapter in `MauiProgram.cs`.

### Azure OpenAI

For **Azure OpenAI**, first [deploy an Azure OpenAI Service resource and model](https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/create-resource), then values for `azureOpenAIKey`, `azureOpenAIEndpoint` and `azureOpenAIModel` will all be provided to you.

* Install the following NuGet packages to your project:

{% tabs %}

{% highlight c# tabtitle="Package Manager" %}

Install-Package Microsoft.Extensions.AI
Install-Package Microsoft.Extensions.AI.OpenAI
Install-Package Azure.AI.OpenAI

{% endhighlight %}

{% endtabs %}

* To configure the AI service, add the following settings to the **MauiProgram.cs** file in your application.

{% tabs %}
{% highlight C# tabtitle="MauiProgram" hl_lines="5 21" %}

using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Logging;
using System.ClientModel;
using Syncfusion.Maui.SmartComponents.Hosting;

var builder = MauiApp.CreateBuilder();

....

string azureOpenAIKey = "AZURE_OPENAI_KEY";
string azureOpenAIEndpoint = "AZURE_OPENAI_ENDPOINT";
string azureOpenAIModel = "AZURE_OPENAI_MODEL";
AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(
     new Uri(azureOpenAIEndpoint),
     new ApiKeyCredential(azureOpenAIKey)
);
IChatClient azureOpenAIChatClient = azureOpenAIClient.GetChatClient(azureOpenAIModel).AsIChatClient();
builder.Services.AddChatClient(azureOpenAIChatClient);

builder.ConfigureSyncfusionAIServices();

{% endhighlight %}
{% endtabs %}

### OpenAI

For **OpenAI**, create an API key and place it at `openAIApiKey`. The value for `openAIModel` is the model you wish.

* Install the following NuGet packages to your project:

{% tabs %}

{% highlight c# tabtitle="Package Manager" %}

Install-Package Microsoft.Extensions.AI
Install-Package Microsoft.Extensions.AI.OpenAI

{% endhighlight %}

{% endtabs %}

* To configure the AI service, add the following settings to the **MauiProgram.cs** file in your app.

{% tabs %}
{% highlight C# tabtitle="Blazor Server App" hl_lines="3 23" %}

using Microsoft.Extensions.AI;
using OpenAI;
using Syncfusion.Maui.SmartComponents.Hosting;

var builder = MauiApp.CreateBuilder();

....

string openAIApikey = "API-KEY";
string openAIModel = "gpt-4o-mini"; // example

var openAIClient = new OpenAIClient(
    new ApiKeyCredential(openAIApikey),
    new OpenAIClientOptions
    {
        // Default OpenAI endpoint; include /v1 if your SDK expects it
        Endpoint = new Uri("https://api.openai.com/v1/")
    });

IChatClient openAIChatClient = openAIClient.GetChatClient(openAIModel).AsIChatClient();
builder.Services.AddChatClient(openAIClient);

builder.ConfigureSyncfusionAIServices();

{% endhighlight %}
{% endtabs %}

### Ollama

To use Ollama for running self hosted models:

1. **Download and install Ollama**  
   Visit [Ollama's official website](https://ollama.com) and install the application appropriate for your operating system.

2. **Install the desired model from the Ollama library**  
   You can browse and install models from the [Ollama Library](https://ollama.com/library) (e.g., `llama2:13b`, `mistral:7b`, etc.).

3. **Configure your application**

   - Provide the `Endpoint` URL where the model is hosted (e.g., `http://localhost:11434`).
   - Set `ModelName` to the specific model you installed (e.g., `llama2:13b`).

* Install the following NuGet packages to your project:

{% tabs %}

{% highlight c# tabtitle="Package Manager" %}

Install-Package Microsoft.Extensions.AI
Install-Package OllamaSharp

{% endhighlight %}

{% endtabs %}

* Add the following settings to the **MauiProgram.cs** file in your application.

{% tabs %}
{% highlight C# tabtitle="MauiProgram" hl_lines="3 13" %}

using Microsoft.Extensions.AI;
using OllamaSharp;
using Syncfusion.Maui.SmartComponents.Hosting;

var builder = MauiApp.CreateBuilder();

....

string ModelName = "MODEL_NAME";
IChatClient chatClient = new OllamaApiClient("http://localhost:11434", ModelName);
builder.Services.AddChatClient(chatClient);

builder.ConfigureSyncfusionAIServices();

{% endhighlight %}
{% endtabs %}