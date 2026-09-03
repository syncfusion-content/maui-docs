---
layout: post
title: Prerequisites for the AI solution samples | Syncfusion®
description: Learn the prerequisites for using AI solution samples with Syncfusion® .NET MAUI controls and get started quickly.
platform: maui
control: SfAutocomplete
documentation: ug
---
# Integrating Azure OpenAI with the .NET MAUI App

## Step 1: Set Up Azure OpenAI Service

First, open [Visual Studio](https://visualstudio.microsoft.com/) and [create a new .NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-7.0&tabs=vswin&pivots=devices-android).

Before enabling AI, ensure that you have access to [Azure OpenAI](https://azure.microsoft.com/en-in/products/ai-services/openai-service) and have set up a deployment in the Azure portal. 

**Configure Azure OpenAI:**

1. Log in to the [Azure Portal](https://portal.azure.com/)
2. Create a new OpenAI resource (or use an existing one)
3. Deploy a **GPT-4o** model (or GPT-4 Turbo) for text analysis
4. Copy your deployment name, endpoint URL, and API key from the **Keys and Endpoint** section

**Install NuGet Package:**

Run the following command in the Package Manager Console or terminal:

```
dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.12
```

Alternatively, use the NuGet Package Manager in Visual Studio to install the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/) package.

## Step 2: Create the Azure OpenAI service class

Create a helper class to manage communication with Azure OpenAI. **Important**: Store your API key securely using environment variables or Azure Key Vault, not hard coded strings.

{% tabs %}

{% highlight c# %}

using Azure;
using Azure.AI.OpenAI;
using System;
using System.Threading.Tasks;

internal class AzureOpenAIService
{
    const string endpoint = "https://{YOUR_END_POINT}.openai.azure.com";
    const string deploymentName = "GPT-4O";
    const string imageDeploymentName = "DALL-E";
    string key = "API key";
    
    OpenAIClient? client;
    ChatCompletionsOptions? chatCompletions;
    
    internal AzureOpenAIService()
    {
        
    }
}

{% endhighlight %}

{% endtabs %}

## Step 3: Initialize the OpenAI Client

To set up the connection to Azure OpenAI. Refer to the following code.

{% tabs %}

{% highlight c# %}

// At the time of required.
this.client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(key))

{% endhighlight %}

{% endtabs %}

This connection allows you to send prompts to the model and **receive responses**, which can be used to generates.

## Step 4: Implement the GetResultsFromAI Method

Implement a method to retrieve responses from the Azure OpenAI API based on user prompts.

{% tabs %}

{% highlight c# %}

using Azure;
using Azure.AI.OpenAI;
using System;
using System.Threading.Tasks;

public async Task<string> GetResultsFromAI(string userPrompt)
{
    if (this.Client != null && this.chatCompletions != null)
    {
        // Add the system message and user message to the options.
        this.chatCompletions.Messages.Add(new ChatRequestSystemMessage("You are a predictive analytics assistant."));
        this.chatCompletions.Messages.Add(new ChatRequestUserMessage(userPrompt));
        try
        {
            var response = await Client.GetChatCompletionsAsync(this.chatCompletions);
            return response.Value.Choices[0].Message.Content;
        }
        catch
        {
            return string.Empty;
        }
    }
    return string.Empty;
}

{% endhighlight %}

{% endtabs %}