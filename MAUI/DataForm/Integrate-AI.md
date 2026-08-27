---
layout: post
title: Integrate AI for Smart Paste in .NET MAUI DataForm | Syncfusion®
description: Learn how to integrate AI for smart paste functionality in .NET MAUI DataForm for intelligent data extraction and field population.
platform: maui
control: SfDataForm
documentation: ug
---

# Integrating Azure OpenAI with the .NET MAUI app

## Step 1: Set Up the .NET MAUI Project

- Create a new [.NET MAUI app](https://learn.microsoft.com/en-us/dotnet/maui/get-started/first-app?view=net-maui-9.0&viewFallbackFrom=net-maui-7.0&tabs=vswin&pivots=devices-android) using [Visual Studio](https://visualstudio.microsoft.com/).
- Add the required NuGet packages:
`Syncfusion.Maui.DataForm`
`Syncfusion.Maui.AIAssistView` and [`Azure.AI.OpenAI`](https://www.nuget.org/packages/Azure.AI.OpenAI/1.0.0-beta.12)

## Step 2: Set up Azure OpenAI

To enable AI functionality in your .NET MAUI DataForm, first ensure that you have access to [Azure OpenAI](https://azure.microsoft.com/en-in/products/ai-services/openai-service). In the Azure portal, create an Azure OpenAI resource and deploy a model such as GPT-35. Assign a deployment name (for example, GPT35Turbo) that you’ll reference in your application code. Finally, copy the API key and endpoint URL from the resource settings, as these are required for authentication and communication with the OpenAI service.

## Step 3: Connect to the Azure OpenAI

To connect your .NET MAUI app to Azure OpenAI, create a service class that handles communication with the AI model. 

{% tabs %}

{% highlight c# %}

/// <summary>
/// Helper class to interact with Azure AI.
/// </summary>
internal class AzureOpenAIServiceConnector : AzureBaseService
{

}

{% endhighlight %}

{% endtabs %}

In this service, define a method called `GetAnswerFromGPT`. This method takes a user prompt from the SfAIAssistView control as input, sends it to the deployed model (e.g., GPT35Turbo), and returns the AI-generated response.

{% tabs %}

{% highlight c# %}

/// <summary>
/// Helper class to interact with Azure AI.
/// </summary>
internal class AzureOpenAIServiceConnector : AzureBaseService
{

    /// <summary>
    /// Retrieves an answer from the deployment name model using the provided user prompt.
    /// </summary>
    /// <param name="userPrompt">The user prompt.</param>
    /// <returns>The AI response.</returns>
    internal async Task<string> GetAnswerFromGPT(string userPrompt)
    {
        ChatHistory = string.Empty;
        if (IsCredentialValid && Client != null && ChatHistory != null)
        {
            // Add the user's prompt as a user message to the conversation.
            ChatHistory = ChatHistory + "You are a predictive analytics assistant.";
            // Add the user's prompt as a user message to the conversation.
            ChatHistory = ChatHistory + userPrompt;
            try
            {
                //// Send the chat completion request to the OpenAI API and await the response.
                var response = await Client.CompleteAsync(ChatHistory);
                return response.ToString();
            }
            catch
            {
                // If an exception occurs (e.g., network issues, API errors), return an empty string.
                return "";
            }
        }

        return "";
    }
}

{% endhighlight %}

{% endtabs %}

Within the base service class (AzureBaseService), initialize the OpenAIClient with your Azure endpoint, deployment name, and API key.

{% tabs %}

{% highlight c# %}

 public abstract class AzureBaseService
 {
     #region Fields
     /// <summary>
     /// The EndPoint
     /// </summary>
     internal const string Endpoint = "YOUR_END_POINT_NAME";

     /// <summary>
     /// The Deployment name
     /// </summary>
     internal const string DeploymentName = "DEPLOYMENT_NAME";

     /// <summary>
     /// The Image Deployment name
     /// </summary>
     internal const string ImageDeploymentName = "IMAGE_DEPOLYMENT_NAME";

     /// <summary>
     /// The API key
     /// </summary>
     internal const string Key = "API_KEY";

     /// <summary>
     /// The already credential validated field
     /// </summary>
     private static bool isAlreadyValidated = false;

     /// <summary>
     /// Indicating whether an credentials are valid or not
     /// </summary>
     private static bool _isCredentialValid;

     #endregion

     public AzureBaseService()
     {
         ValidateCredential();
     }

    internal IChatClient? Client { get; set; }

    /// <summary>
    /// To get the Azure open ai method
    /// </summary>
    private void GetAzureOpenAI()
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