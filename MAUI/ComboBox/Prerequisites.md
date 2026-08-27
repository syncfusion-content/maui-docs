---
layout: post
title: Prerequisites for Smart Searching in .NET MAUI ComboBox | Syncfusion®
description: Learn about prerequisites of smart search using Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfCombobox
documentation: ug
---

# Prerequisites for Smart Searching in .NET MAUI ComboBox

## Prerequisites

Before you begin, ensure you have the following:

- A working .NET MAUI application with the `Syncfusion.Maui.Inputs` package installed.
- An active Azure subscription with access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and a deployed model. If you don't have access, refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account. Note down the deployment name, endpoint URL, and API key.
- The [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package (version 2.x recommended for the `IChatClient` API used in this sample). Install it by running the following command in the Visual Studio Package Manager Console:

    ```powershell
    Install-Package Azure.AI.OpenAI -Version 2.0.0
    ```
    Or using the .NET CLI:
    ```bash
    dotnet add package Azure.AI.OpenAI --version 2.0.0
    ```

## Integrating Azure OpenAI with your .NET MAUI App

First, ensure that you have access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and have created a deployment in the Azure portal.

If you do not have access, refer to the [Create and deploy an Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account.

Note down the deployment name, endpoint URL, and API key.

We will use the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12) NuGet package from the [NuGet Gallery](https://www.nuget.org/). Before getting started, install the Azure.AI.OpenAI NuGet package in your .NET MAUI app.

In your base service class (AzureBaseService), initialize the OpenAIClient. Replace the Endpoint, DeploymentName, Key with actual values from your Azure OpenAI resource.

This creates a chat client using your endpoint, API key, and deployment name. It’s stored in the Client property for use in other methods.

The ComboBoxAzureAIService uses this client to send prompts and receive completions.

In the `GetCompletion` method, we construct the prompt and send it to the Azure OpenAI service. The chat history helps maintain context, but it is cleared for each new prompt in this implementation to keep each search independent.

{% tabs %}
{% highlight c# %}

public abstract class AzureBaseService
{        
    internal const string Endpoint = "YOUR_END_POINT_NAME";

    internal const string DeploymentName = "DEPLOYMENT_NAME";

    internal const string Key = "API_KEY";

    public AzureBaseService()
    {

    }

    /// <summary>
    /// To get the Azure open ai kernal method
    /// </summary>
    private void GetAzureOpenAIKernal()
    {
        try
        {
            var client = new AzureOpenAIClient(new Uri(Endpoint), new AzureKeyCredential(Key)).AsChatClient(modelId: DeploymentName);
            this.Client = client;
        }
        catch (Exception)
        {
        }
    }
    
}

{% endhighlight %}

{% endtabs %}

{% tabs %}
{% highlight c# %}

public class ComboBoxAzureAIService : AzureBaseService
{
    /// <summary>
    /// Gets a completion response from the AzureAI service based on the provided prompt.
    /// </summary>
    /// <param name="prompt"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<string> GetCompletion(string prompt, CancellationToken cancellationToken)
    {
        ChatHistory = string.Empty;
        if (ChatHistory != null && Client != null)
        {
            ChatHistory = ChatHistory + "You are a filtering assistant.";
            // Add the user message to the options
            ChatHistory = ChatHistory + prompt;
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                var chatresponse = await Client.CompleteAsync(ChatHistory);
                cancellationToken.ThrowIfCancellationRequested();
                return chatresponse.ToString();
            }
            catch (RequestFailedException ex)
            {
                // Log the error message and rethrow the exception or handle it appropriately
                Debug.WriteLine($"Request failed: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Handle other potential exceptions
                Debug.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        return "";
    }
}

{% endhighlight %}

{% endtabs %}