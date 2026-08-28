---
layout: post
title: Prerequisites for Smart Searching in Autocomplete | Syncfusion®
description: Learn about the prerequisites for smart search using the Syncfusion® .NET MAUI Autocomplete control.
platform: maui
control: SfAutocomplete
documentation: ug
---
# Prerequisites for Smart Searching

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

First, ensure you have access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and have created a deployment in the Azure portal.

If you don’t have access, please refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account.

Note down the deployment name, endpoint URL, and API key.

Use the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12) NuGet package from the [NuGet Gallery](https://www.nuget.org/). Before getting started, install the Azure.AI.OpenAI NuGet package in your .NET MAUI app.

In your base service class (`AzureBaseService`), initialize the `OpenAIClient`. Replace the `Endpoint`, `DeploymentName`, and `Key` with actual values from your Azure OpenAI resource.

This creates a chat client using your endpoint, API key, and deployment name. It is stored in the `Client` property for use in other methods.

`ComboBoxAzureAIService` uses this `Client` to send prompts and receive completions.

In the `GetCompletion` method, construct the prompt and send it to the Azure OpenAI Service. The `ChatHistory` helps maintain context but is cleared for each new prompt in this implementation to ensure that each search is independent.

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

public class AzureAIService : AzureBaseService
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
        if(ChatHistory != null)
        {
            ChatHistory = ChatHistory + "You are a filtering assistant.";
            ChatHistory = ChatHistory + prompt;
            try
            {
                if (Client != null)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    var chatresponse = await Client.CompleteAsync(prompt);
                    return chatresponse.ToString();
                }
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