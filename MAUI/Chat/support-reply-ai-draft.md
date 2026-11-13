---
layout: post
title: Support Reply AI Drafting in .NET MAUI Chat | Syncfusion®
description: Learn how to use Azure OpenAI to auto-draft professional support replies with the Syncfusion® .NET MAUI Chat control.
platform: MAUI
control: SfChat
documentation: ug
---

# Support Reply AI Drafting in .NET MAUI Chat

**What You'll Build**

This guide shows you how to help support agents draft replies faster and better. When your support team selects a customer message and taps "Draft," your app instantly generates a professional reply using Azure OpenAI. The agent can review, edit, or regenerate the reply before sending it.

By the end, you'll have a working app with this complete workflow:

1. Agent selects a customer message
2. Agent taps the "Draft" button
3. AI generates a professional reply
4. Agent reviews, edits, or regenerates the draft
5. Agent sends the final reply

**Before You Start**

You should have:

- A .NET MAUI project (or create one now)
- Azure OpenAI configured (see Prerequisites below)
- Basic C# and XAML knowledge

If you don't have Azure OpenAI set up yet, complete the Prerequisites section first.

## Prerequisites

Complete the shared [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites) to configure Azure OpenAI (Microsoft's AI service) and your .NET MAUI application. Also complete the [Chat getting started](/maui/chat/getting-started) steps.

## Setting Up Your Project

### Install the Required Packages

Your app needs three NuGet packages:

- **Syncfusion.Maui.Chat** - The Chat control for displaying conversations
- **Syncfusion.Maui.Core** - Base components that Chat depends on
- **Azure.AI.OpenAI** - The client library to connect with Azure OpenAI

Install the Azure OpenAI package:

{% tabs %}
{% highlight powershell %}
Install-Package Azure.AI.OpenAI -Version 2.1.0
{% endhighlight %}
{% highlight bash %}
dotnet add package Azure.AI.OpenAI --version 2.1.0
{% endhighlight %}
{% endtabs %}

### Create the OpenAI Service

Think of the `OpenAIService` as a translator between your Chat app and the AI engine. It takes a customer message and sends it to Azure OpenAI, which generates a professional reply.

The service works in three steps:

1. It creates a connection to Azure OpenAI using your endpoint and API key
2. It sends a system instruction (like "be professional and friendly") and the customer message
3. It returns the AI-generated reply for display in the composer

Here's the service implementation:

{% tabs %}
{% highlight c# %}

public class OpenAIService
{
    private readonly AzureOpenAIClient _client;
    private readonly string _deploymentName;

    public OpenAIService(string endpoint, string apiKey, string deploymentName)
    {
        _client = new AzureOpenAIClient(new Uri(endpoint), new AzureKeyCredential(apiKey));
        _deploymentName = deploymentName;
    }

    public async Task<string> GetDraftReplyAsync(string customerMessage, CancellationToken cancellationToken = default)
    {
        var systemPrompt = "You are a helpful and professional customer support agent. Draft a clear, " +
                          "concise, and empathetic reply to the customer's message. Keep the tone professional " +
                          "yet friendly. The reply should address the customer's concern directly.";

        var messages = new List<ChatMessage>
        {
            new SystemChatMessage(systemPrompt),
            new UserChatMessage(customerMessage)
        };

        ChatCompletion response = await _client
            .GetChatClient(_deploymentName)
            .CompleteChatAsync(messages, cancellationToken: cancellationToken);

        return response.Content[0].Text.Trim();
    }
}

{% endhighlight %}
{% endtabs %}

## Building the Chat UI with AI Drafting

This section walks you through building the support reply interface. You'll create a Chat display area and a composer where agents can see and edit the AI-drafted reply.

### Step 1: Create the Chat Interface

The Chat control displays the conversation history. Below it, add a message composer where your support agent can see the AI-drafted reply and prepare to send it.

The layout has three parts:

1. **Chat messages** - Shows the customer and agent messages
2. **Text input** - Where the agent enters or edits the reply
3. **Action buttons** - "Draft" to generate the reply, "Send" to submit it

{% tabs %}
{% highlight xaml %}

<Grid RowDefinitions="*, Auto">
    <!-- Chat Messages Display -->
    <chat:SfChat x:Name="ChatControl"
                 Messages="{Binding Messages}"
                 ShowTypingIndicator="False"
                 VerticalOptions="FillAndExpand" />

    <!-- Message Composer -->
    <Grid Grid.Row="1" Padding="10" ColumnDefinitions="*, Auto, Auto">
        <Entry x:Name="ComposerEntry"
               Placeholder="Type your reply..."
               Text="{Binding ComposerText}"
               VerticalOptions="Center" />

        <Button Grid.Column="1"
                Text="Draft"
                Clicked="OnDraftReplyClicked"
                Margin="5, 0"
                Padding="15, 10" />

        <Button Grid.Column="2"
                Text="Send"
                Clicked="OnSendReplyClicked"
                Margin="5, 0"
                Padding="15, 10" />
    </Grid>
</Grid>

{% endhighlight %}
{% endtabs %}

### Step 2: Add Predefined Customer Messages

Your support team needs a way to select customer messages. You'll create a view model that holds a list of predefined customer messages. When an agent picks one, it becomes the input for the AI draft.

This is important because it gives your support team a quick way to practice drafting without waiting for real customer messages. For production, you'd replace this list with actual customer messages from your system.

{% tabs %}
{% highlight c# %}

public class SupportViewModel : INotifyPropertyChanged
{
    private ObservableCollection<string> _predefinedMessages;
    private string _selectedCustomerMessage;
    private string _composerText;
    private bool _isLoading;

    public ObservableCollection<string> PredefinedMessages
    {
        get => _predefinedMessages;
        set
        {
            _predefinedMessages = value;
            OnPropertyChanged();
        }
    }

    public string SelectedCustomerMessage
    {
        get => _selectedCustomerMessage;
        set
        {
            _selectedCustomerMessage = value;
            OnPropertyChanged();
        }
    }

    public string ComposerText
    {
        get => _composerText;
        set
        {
            _composerText = value;
            OnPropertyChanged();
        }
    }

    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            _isLoading = value;
            OnPropertyChanged();
        }
    }

    public SupportViewModel()
    {
        PredefinedMessages = new ObservableCollection<string>
        {
            "License still shows as expired after renewal",
            "How do I upgrade my subscription?",
            "The application crashed on startup",
            "How can I export my data?"
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

{% endhighlight %}
{% endtabs %}

### Step 3: Generate the AI Draft

Now you'll implement what happens when your support agent taps "Draft." The code sends the selected customer message to Azure OpenAI and displays the generated reply in the composer.

Here's what happens behind the scenes:

1. Agent taps "Draft"
2. Your app checks if a customer message is selected
3. Your app shows a loading indicator while waiting
4. Azure OpenAI generates the reply
5. The reply appears in the composer, ready to edit
6. If something goes wrong, an error message appears

Implement the draft button click handler:

{% tabs %}
{% highlight c# %}

private readonly OpenAIService _openAIService;

private async void OnDraftReplyClicked(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(ViewModel.SelectedCustomerMessage))
    {
        await DisplayAlert("Info", "Please select a customer message to draft a reply.", "OK");
        return;
    }

    ViewModel.IsLoading = true;

    try
    {
        var draftReply = await _openAIService.GetDraftReplyAsync(
            ViewModel.SelectedCustomerMessage);

        ViewModel.ComposerText = draftReply;
    }
    catch (Exception ex)
    {
        await DisplayAlert("Error", $"Failed to generate draft: {ex.Message}", "OK");
    }
    finally
    {
        ViewModel.IsLoading = false;
    }
}

{% endhighlight %}
{% endtabs %}

### Step 4: Let Agents Control the Draft

Your support team should have full control over the AI-generated draft. They might want to:

- **Regenerate** – Get a different reply if they don't like the current one
- **Discard** – Clear the draft and start over
- **Send** – Submit the final reply (after reviewing or editing)

Implement these three actions:

{% tabs %}
{% highlight c# %}

private async void OnRegenerateDraftClicked(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(ViewModel.SelectedCustomerMessage))
        return;

    ViewModel.IsLoading = true;

    try
    {
        // Call AI again with the same customer message
        var newDraft = await _openAIService.GetDraftReplyAsync(
            ViewModel.SelectedCustomerMessage);

        ViewModel.ComposerText = newDraft;
    }
    catch (Exception ex)
    {
        await DisplayAlert("Error", $"Failed to regenerate draft: {ex.Message}", "OK");
    }
    finally
    {
        ViewModel.IsLoading = false;
    }
}

private void OnDiscardDraftClicked(object sender, EventArgs e)
{
    ViewModel.ComposerText = string.Empty;
}

private async void OnSendReplyClicked(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(ViewModel.ComposerText))
    {
        await DisplayAlert("Info", "Please enter a reply before sending.", "OK");
        return;
    }

    // Add the message to the Chat control
    var message = new TextMessage
    {
        Text = ViewModel.ComposerText,
        Author = new Author { Name = "Jordan Lee", Avatar = "jordan.png" }
    };

    ViewModel.Messages.Add(message);

    // Clear the composer
    ViewModel.ComposerText = string.Empty;
}

{% endhighlight %}
{% endtabs %}

### Step 5: Register Services

Your app needs to know where to find the `OpenAIService` and `SupportViewModel`. Register them in your .NET MAUI startup code (`MauiProgram.cs`) so the app can use them anywhere:

{% tabs %}
{% highlight c# %}

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            })
            // Register Syncfusion license
            .ConfigureSyncfusionCore();

        builder.Services.AddSingleton<OpenAIService>();
        builder.Services.AddSingleton<SupportViewModel>();
        builder.Services.AddSingleton<SupportPage>();

        return builder.Build();
    }
}

{% endhighlight %}
{% endtabs %}

## Optional: Customize the AI Reply Tone

*This section is optional. Your app works fine with the default prompt.*

The AI generates replies based on the system prompt you provide. Different prompts create different tones. Here are two examples:

**For technical support**, use a professional, formal tone:

{% tabs %}
{% highlight c# %}

var systemPrompt = "You are a professional technical support specialist. Provide clear, " +
                  "technical, and accurate solutions to customer problems. Use formal language " +
                  "and ensure the reply addresses the root cause of the issue.";

{% endhighlight %}
{% endtabs %}

**For general support**, use a warm, empathetic tone:

{% tabs %}
{% highlight c# %}

var systemPrompt = "You are a friendly and empathetic customer support agent. Respond warmly " +
                  "to customer concerns, validate their feelings, and provide helpful solutions. " +
                  "Keep the tone conversational yet professional.";

{% endhighlight %}
{% endtabs %}

Try different prompts to match your team's style. Each prompt produces different reply quality and tone. Find what works best for your support team by testing with real customer messages.

## See It in Action

The following image shows the complete workflow—from selecting a message to reviewing and sending the AI-drafted reply:

![AI-powered support reply drafting in .NET MAUI Chat](images/support-reply-ai-draft.gif)

## Next Steps

Find the complete, working sample in the [AI use-case demos repository](https://github.com/syncfusion/maui-ai-usecase-demos).