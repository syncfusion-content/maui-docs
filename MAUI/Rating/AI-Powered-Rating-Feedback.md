---
layout: post
title: AI-Powered Rating Feedback in .NET MAUI Rating | Syncfusion®
description: Learn how to analyze customer feedback with Azure OpenAI and display a suggested rating using the .NET MAUI Rating control.
platform: MAUI
control: SfRating
documentation: ug
---

# AI-Powered Rating Feedback in .NET MAUI Rating

This sample uses Azure OpenAI to analyze customer support feedback and display a suggested satisfaction rating with the Syncfusion [.NET MAUI Rating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control. As the user enters feedback, the app waits briefly before sending it for analysis and updates the read-only rating with the result.

## Integrating Azure OpenAI with the .NET MAUI App

Before implementing the rating flow, complete the shared [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites) to configure Azure OpenAI and your .NET MAUI application. Also complete the [Rating getting started](https://help.syncfusion.com/maui/rating/getting-started) steps.

## Implementing AI-Powered Rating Feedback

**Step 1: Install the required packages**

The sample uses `Syncfusion.Maui.Inputs` for `SfRating`, `Syncfusion.Maui.Core` for `SfTextInputLayout`, and `Azure.AI.OpenAI` for Azure OpenAI integration. Install the Azure OpenAI SDK version used by the sample:

{% tabs %}
{% highlight powershell %}
Install-Package Azure.AI.OpenAI -Version 2.1.0
{% endhighlight %}
{% highlight bash %}
dotnet add package Azure.AI.OpenAI --version 2.1.0
{% endhighlight %}
{% endtabs %}

The sample's `OpenAIService` creates an `AzureOpenAIClient` and uses the configured deployment to submit the feedback. The service sends a system instruction describing the rating scale and the feedback text as the user message.

**Step 2: Create the Feedback and Rating UI**

Use an `Editor` inside `SfTextInputLayout` to collect feedback. The `CharMaxLength` property limits the input to 300 characters, and the `TextChanged` event passes changes to the view model.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout CharMaxLength="300"
                               ShowCharCount="True">
    <Editor Placeholder="Describe your customer support experience..."
            TextChanged="OnFeedbackTextChanged" />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% endtabs %}

Bind `SfRating` to the view model's `Rating` property and set `IsReadOnly` to `True` so the suggested score is controlled by the AI response.

{% tabs %}
{% highlight xaml %}

<rating:SfRating ItemCount="5"
                 ItemSize="32"
                 Value="{Binding Rating, Mode=OneWay}"
                 IsReadOnly="True" />

{% endhighlight %}
{% endtabs %}

The sample also binds an `ActivityIndicator` to `IsAnalyzing` and displays `ErrorMessage` when a request fails.

**Step 3: Analyze Feedback and Update the Rating**

The page forwards editor changes to `MainViewModel.OnFeedbackChanged`. The view model cancels the previous request, resets the displayed rating, and waits 500 milliseconds before requesting a new rating. It uses cancellation and a request-version check to prevent an older response from replacing the result for newer text.

`OpenAIService.GetSuggestedRatingAsync` sends the feedback to the configured chat deployment. It parses the response as an invariant-culture decimal and clamps valid numbers to the `0.0`–`5.0` range before returning them:

{% tabs %}
{% highlight c# %}

var messages = new List<ChatMessage>
{
    new SystemChatMessage(SystemPrompt),
    new UserChatMessage(feedback)
};

ChatCompletion response = await _client
    .GetChatClient(_deploymentName)
    .CompleteChatAsync(messages, cancellationToken: cancellationToken);

string result = response.Content[0].Text.Trim();
if (double.TryParse(result, NumberStyles.Float, CultureInfo.InvariantCulture, out double rating))
{
    return Math.Clamp(rating, 0.0, 5.0);
}

throw new InvalidOperationException(
    $"AI returned a value that could not be parsed as a number: '{result}'.");

{% endhighlight %}
{% endtabs %}

The system instruction asks the model to return a rating from `0.0` to `5.0`.

**Step 4: Register the Services**

Register `OpenAIService`, `MainViewModel`, and `MainPage` with the .NET MAUI dependency injection container in `MauiProgram`.

{% tabs %}
{% highlight c# %}

builder.Services.AddSingleton<OpenAIService>();
builder.Services.AddSingleton<MainViewModel>();
builder.Services.AddSingleton<MainPage>();

{% endhighlight %}
{% endtabs %}

The app validates the Azure OpenAI configuration at startup and displays an alert if the service cannot be configured.

## Output

The following image shows the AI-powered rating feedback sample.

![AI-powered rating feedback in .NET MAUI Rating](images/AIRatingFeedback.gif)

You can find the complete sample in the [AI use-case demos repository](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master/AI%20Solutions/Rating/AIRatingFeedback).
