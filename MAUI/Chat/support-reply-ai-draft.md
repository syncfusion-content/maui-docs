---
layout: post
title: Support Reply AI Drafting in .NET MAUI Chat | Syncfusion®
description: Learn how to use Azure OpenAI to auto-draft professional support replies with the Syncfusion® .NET MAUI Chat control.
platform: MAUI
control: SfChat
documentation: ug
---

# Support Reply AI Drafting in .NET MAUI Chat

This guide shows you how to build a support reply feature using the Syncfusion [.NET MAUI Chat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html) control (`SfChat`) and Azure OpenAI. The `SfChat` control displays the conversation history between support agents and customers. When your support team selects a customer message and taps **Draft**, Azure OpenAI generates a professional reply that agents can review, edit, or regenerate before sending it through the Chat control.

## What You'll Build

By the end, you'll have a working app with this complete workflow:

1. Agent selects a customer message
2. Agent taps the "Draft" button
3. AI generates a professional reply
4. Agent reviews, edits, or regenerates the draft
5. Agent sends the final reply through the Chat control

## Before You Start

You should have:

- A .NET MAUI project (or create one now)
- Azure OpenAI configured (see Prerequisites below)
- Basic C# and XAML knowledge

If you don't have Azure OpenAI set up yet, complete the Prerequisites section first.

## Prerequisites

Complete the shared [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites) to configure Azure OpenAI (Microsoft's AI service) and your .NET MAUI application. Also complete the [Chat getting started](/maui/chat/getting-started) steps.

## Setting Up Your Project

### Step 1: Install the Required Packages

Your app needs three NuGet packages:

- **Syncfusion.Maui.Chat** - The Chat control for displaying conversations and messages
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

## Step 2: Build the Chat UI with AI Drafting

**Note:** Step 1 includes completing the prerequisites above.

The `SfChat` control displays the conversation history between customer and agent. Below the Chat control, add a message composer where your support agent can see the AI-drafted reply and prepare to send it.

The layout has three parts:

1. **Chat messages** (`SfChat`) - Displays customer and agent messages
2. **Text editor** (`Editor`) - Where the agent reviews or edits the AI-drafted reply
3. **Action buttons** - **Draft** to generate the reply, **Send** to submit it

### Creating the Chat Interface

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
        <Editor x:Name="ComposerEditor"
                Placeholder="Type your reply..."
                Text="{Binding ComposerText}"
                IsReadOnly="{Binding IsComposerReadOnly}"
                IsEnabled="{Binding IsComposerEnabled}"
                MinimumHeightRequest="80"
                MaximumHeightRequest="150" />

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

## Understanding SfChat Messages

The `SfChat` control displays messages using the `TextMessage` class. Each message has two required parts:

- **`Text`** - The message content (for example, "How do I reset my password?")
- **`Author`** - Who sent the message, including a name and optional avatar image

The `SfChat` control stores all messages in a collection. When you add a message to this collection, `SfChat` automatically displays it in the conversation area. Customer messages appear on the left, and agent messages appear on the right.

Example of creating a message for SfChat:

{% tabs %}
{% highlight c# %}

// Create a customer message
var customerMessage = new TextMessage
{
    Text = "How do I reset my password?",
    Author = new Author 
    { 
        Name = "Customer",
        Avatar = "customer.png"
    }
};

// Create an agent reply
var agentReply = new TextMessage
{
    Text = "Click Settings > Security > Change Password.",
    Author = new Author 
    { 
        Name = "Support Agent",
        Avatar = "agent.png"
    }
};

// Add messages to the SfChat Messages collection
chatControl.Messages.Add(customerMessage);
chatControl.Messages.Add(agentReply);

{% endhighlight %}
{% endtabs %}

## Step 3: Create the Message Data Model

Build a view model that holds the messages displayed in `SfChat` and manages the drafted reply. The view model uses the MVVM (Model-View-ViewModel) pattern to keep the UI synchronized with your data.

### Understanding the View Model and MVVM Pattern

The view model implements `INotifyPropertyChanged`, a .NET pattern that notifies the UI when data changes. When you set a property like `ComposerText`, the `OnPropertyChanged()` method tells the UI to update its display. This synchronizes the `SfChat` control and Editor field with your underlying data.

For this sample, the view model includes predefined customer messages to test the draft feature. In production, load actual customer messages from your system (a database, API, or message queue).

Here's the view model with predefined messages:

{% tabs %}
{% highlight c# %}

public class SupportViewModel : INotifyPropertyChanged
{
    private ObservableCollection<TextMessage> _messages;
    private ObservableCollection<string> _predefinedMessages;
    private string _selectedCustomerMessage;
    private string _composerText;
    private bool _isLoading;

    // Messages displayed in SfChat
    public ObservableCollection<TextMessage> Messages
    {
        get => _messages;
        set
        {
            _messages = value;
            OnPropertyChanged();
        }
    }

    // Customer messages available for drafting replies
    public ObservableCollection<string> PredefinedMessages
    {
        get => _predefinedMessages;
        set
        {
            _predefinedMessages = value;
            OnPropertyChanged();
        }
    }

    // Currently selected customer message for drafting
    public string SelectedCustomerMessage
    {
        get => _selectedCustomerMessage;
        set
        {
            _selectedCustomerMessage = value;
            OnPropertyChanged();
        }
    }

    // AI-drafted reply text in the composer
    public string ComposerText
    {
        get => _composerText;
        set
        {
            _composerText = value;
            OnPropertyChanged();
        }
    }

    // Indicates whether the AI is generating a reply
    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            _isLoading = value;
            OnPropertyChanged();
        }
    }

    // Disables the composer while generating a draft
    public bool IsComposerReadOnly => IsLoading;

    // Disables the composer while generating a draft
    public bool IsComposerEnabled => !IsLoading;

    public SupportViewModel()
    {
        Messages = new ObservableCollection<TextMessage>();
        PredefinedMessages = new ObservableCollection<string>
        {
            "License still shows as expired after renewal",
            "How do I upgrade my subscription?",
            "The application crashed on startup",
            "How can I export my data?"
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    // Notifies the UI when a property changes
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Create the OpenAI Service

The `OpenAIService` manages communication between your app and Azure OpenAI. It accepts a customer message, sends it to the AI with instructions about tone and style, and returns the generated reply.

The service performs three steps:

1. Creates a connection to Azure OpenAI using your endpoint and API key
2. Sends a system prompt (instructions like "be professional and friendly") and the customer message
3. Returns the AI-generated reply

Here's the service implementation:

{% tabs %}
{% highlight c# %}

public class OpenAIService
{
    private readonly AzureOpenAIClient _client;
    private readonly string _deploymentName;

    // Initializes the Azure OpenAI connection
    public OpenAIService(string endpoint, string apiKey, string deploymentName)
    {
        _client = new AzureOpenAIClient(new Uri(endpoint), new AzureKeyCredential(apiKey));
        _deploymentName = deploymentName;
    }

    // Generates a drafted reply for a customer message
    public async Task<string> GetDraftReplyAsync(string customerMessage, CancellationToken cancellationToken = default)
    {
        // System prompt: Instructs the AI on tone, style, and behavior
        var systemPrompt = "You are a helpful and professional customer support agent. Draft a clear, " +
                          "concise, and empathetic reply to the customer's message. Keep the tone professional " +
                          "yet friendly. The reply should address the customer's concern directly.";

        // Build the messages for the AI
        var messages = new List<ChatMessage>
        {
            new SystemChatMessage(systemPrompt),
            new UserChatMessage(customerMessage)
        };

        // Send the request to Azure OpenAI
        ChatCompletion response = await _client
            .GetChatClient(_deploymentName)
            .CompleteChatAsync(messages, cancellationToken: cancellationToken);

        // Return the generated reply
        return response.Content[0].Text.Trim();
    }
}

{% endhighlight %}
{% endtabs %}

### Understanding Async/Await

The `GetDraftReplyAsync` method uses `async` and `await`. This pattern allows your app to wait for Azure OpenAI's response without blocking the UI. While the AI is generating a reply, your support agent can interact with the app normally. When the response arrives, the reply automatically appears in the composer.

## Step 5: Generate the AI Draft

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
    // Validate that a customer message is selected
    if (string.IsNullOrEmpty(ViewModel.SelectedCustomerMessage))
    {
        await DisplayAlert("Info", "Please select a customer message to draft a reply.", "OK");
        return;
    }

    // Show a loading indicator
    ViewModel.IsLoading = true;

    try
    {
        // Call the OpenAI service to generate a reply
        // Using 'await' waits for the response without freezing the UI
        var draftReply = await _openAIService.GetDraftReplyAsync(
            ViewModel.SelectedCustomerMessage);

        // Display the AI-generated reply in the composer
        ViewModel.ComposerText = draftReply;
    }
    catch (Exception ex)
    {
        // If something goes wrong, show an error message
        await DisplayAlert("Error", $"Failed to generate draft: {ex.Message}", "OK");
    }
    finally
    {
        // Always hide the loading indicator
        ViewModel.IsLoading = false;
    }
}

{% endhighlight %}
{% endtabs %}

## Step 6: Let Agents Control the Draft

Give your support team full control over the drafted reply. Agents may need to:

- **Regenerate** – Request a different reply if the current one doesn't fit
- **Discard** – Clear the draft and start over
- **Send** – Submit the final reply to the `SfChat` control (after reviewing or editing)

Implement these three actions:

{% tabs %}
{% highlight c# %}

// Request a different draft reply from the AI
private async void OnRegenerateDraftClicked(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(ViewModel.SelectedCustomerMessage))
        return;

    ViewModel.IsLoading = true;

    try
    {
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

// Clear the draft and start over
private void OnDiscardDraftClicked(object sender, EventArgs e)
{
    ViewModel.ComposerText = string.Empty;
}

// Add the reply to the SfChat control and clear the composer
private async void OnSendReplyClicked(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(ViewModel.ComposerText))
    {
        await DisplayAlert("Info", "Please enter a reply before sending.", "OK");
        return;
    }

    var message = new TextMessage
    {
        Text = ViewModel.ComposerText,
        Author = new Author { Name = "Support Agent", Avatar = "agent.png" }
    };

    ViewModel.Messages.Add(message);
    ViewModel.ComposerText = string.Empty;
}

{% endhighlight %}
{% endtabs %}

## Step 7: Register Services in Your App Startup

Register the `OpenAIService` and `SupportViewModel` in your app startup (`MauiProgram.cs`) so the app can access them from any page. Dependency injection enables testing and decouples components.

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

        // Register services (AddSingleton creates one instance for the app lifetime)
        builder.Services.AddSingleton<OpenAIService>();
        builder.Services.AddSingleton<SupportViewModel>();
        builder.Services.AddSingleton<SupportPage>();

        return builder.Build();
    }
}

{% endhighlight %}
{% endtabs %}

## Optional: Customize the AI Reply Tone

*This section is optional. Your app works fine with the default prompt in the `GetDraftReplyAsync` method.*

The AI generates replies based on the system prompt. Different prompts produce different tones and styles. Here are three examples for the `OpenAIService` class:

### For Technical Support

Use a professional, formal tone:

{% tabs %}
{% highlight c# %}

// Replace the systemPrompt variable in GetDraftReplyAsync with this:
var systemPrompt = "You are a professional technical support specialist. Provide clear, " +
                  "technical, and accurate solutions to customer problems. Use formal language " +
                  "and ensure the reply addresses the root cause of the issue.";

{% endhighlight %}
{% endtabs %}

### For General Customer Support

Use a warm, empathetic tone:

{% tabs %}
{% highlight c# %}

// Replace the systemPrompt variable in GetDraftReplyAsync with this:
var systemPrompt = "You are a friendly and empathetic customer support agent. Respond warmly " +
                  "to customer concerns, validate their feelings, and provide helpful solutions. " +
                  "Keep the tone conversational yet professional.";

{% endhighlight %}
{% endtabs %}

### For Billing Support

Use a reassuring, solution-focused tone:

{% tabs %}
{% highlight c# %}

// Replace the systemPrompt variable in GetDraftReplyAsync with this:
var systemPrompt = "You are a knowledgeable billing support representative. Help customers " +
                  "resolve their payment and subscription concerns with clarity. Always verify " +
                  "account details and offer clear next steps to resolve issues quickly.";

{% endhighlight %}
{% endtabs %}

### Tips for Creating Your Own Prompt

Test different prompts to match your team's voice. Each prompt produces different reply quality and tone. To create a custom prompt:

1. Start with a clear role: "You are a..." statement
2. Specify the tone: "professional and friendly" or "empathetic and warm"
3. Set constraints: "Keep replies under 150 words" or "Provide step-by-step instructions"
4. Define guardrails: "Only suggest official solutions" or "Always offer to escalate"

Test your prompts with real customer messages. Once you find what works best, update the `systemPrompt` variable in `GetDraftReplyAsync`.

## Next Steps

Find the complete, working sample in the [AI use-case demos repository](https://github.com/syncfusion/maui-ai-usecase-demos).