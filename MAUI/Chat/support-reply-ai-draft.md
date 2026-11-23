---
layout: post
title: Support Reply AI Drafting in .NET MAUI Chat | Syncfusion®
description: Learn how to generate AI-drafted support replies in the Syncfusion® .NET MAUI Chat (SfChat) control, and review, edit, and send them.
platform: maui
control: SfChat
documentation: ug
---

# Support Reply AI Drafting in .NET MAUI Chat

This article demonstrates how to draft support replies with AI in the Syncfusion® [.NET MAUI Chat](https://help.syncfusion.com/maui/chat/overview) (`SfChat`) control. The agent selects a customer message, and the AI places a draft reply in the chat composer. The agent reviews, edits, and sends it. The AI never sends a reply on its own.

## Prerequisites

Before you start, complete the following:

* The shared [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites).
* The [Chat getting started](/maui/chat/getting-started) steps.
* Install the `CommunityToolkit.Mvvm` NuGet package.

## Implementing AI reply drafting

**Step 1: Add the chat**

Bind `SfChat` to a view model. The built-in composer handles editing and sending, and the `Suggestions` property shows the workflow chips.

{% tabs %}
{% highlight xaml %}

<chat:SfChat x:Name="ConversationChat"
             Messages="{Binding Messages}"
             CurrentUser="{Binding CurrentUser}"
             Suggestions="{Binding ChatSuggestions}"
             SuggestionItemSelected="OnSuggestionItemSelected"
             SendMessageCommand="{Binding NativeSendCommand}"
             ShowMessageInputView="True"
             AllowMultilineInput="True" />

{% endhighlight %}
{% endtabs %}

**Step 2: Load the conversation**

Set the support agent as `CurrentUser`, and add the customer and agent `TextMessage` objects to `Messages`.

{% tabs %}
{% highlight c# %}

public Author CurrentUser { get; } = new Author { Name = "Support Agent" };

public ObservableCollection<object> Messages { get; } = new()
{
    new TextMessage
    {
        Author = new Author { Name = "Alex Morgan" },
        Text = "License still shows as expired after renewal"
    }
};

{% endhighlight %}
{% endtabs %}

**Step 3: Select a customer message**

Use a [message template](/maui/chat/messages) to make customer messages tappable. Bind the tap to `SelectMessageCommand`, and show a **Draft Reply** button on the selected message that runs `DraftReplyCommand`.

| Action | Result |
|--------|--------|
| Tap a customer message | Selects it. Only one message can be selected. |
| Tap the selected message again | Clears the selection. |
| Select another message while a draft exists | Asks for confirmation before discarding the draft. |

N> Agent messages cannot be selected.

**Step 4: Track the workflow state**

Keep the selection, composer state, and chips in the view model.

{% tabs %}
{% highlight c# %}

public sealed partial class SupportChatViewModel : ObservableObject
{
    [ObservableProperty]
    public partial TextMessage? SelectedMessage { get; set; }

    [ObservableProperty]
    public partial ChatSuggestions? ChatSuggestions { get; set; }

    [ObservableProperty]
    public partial string EditorText { get; set; } = string.Empty;

    [ObservableProperty]
    public partial bool IsComposerEnabled { get; set; }

    [ObservableProperty]
    public partial bool IsComposerReadOnly { get; set; }

    public ICommand NativeSendCommand { get; }
}

{% endhighlight %}
{% endtabs %}

Update the composer and chips for each state:

| State | Chips | Composer |
|-------|-------|----------|
| Customer message selected | None. **Draft Reply** appears on the selected message. | Read-only |
| Drafting | None | Read-only |
| Draft ready | **Regenerate**, **Discard** | Editable |
| Regenerating | None | Read-only |
| Draft failed | **Retry** | Read-only |

While drafting or regenerating, the selected message shows "Drafting reply..." or "Regenerating reply...".

**Step 5: Generate the draft**

Define a service that takes the selected message and the recent conversation, and returns a validated reply.

{% tabs %}
{% highlight c# %}

public sealed record SupportReplyRequest(
    string SelectedMessageText,
    IReadOnlyList<string> RecentConversationContext);

public interface ISupportReplyService
{
    Task<SupportReplyValidationResult> DraftReplyAsync(
        SupportReplyRequest request,
        CancellationToken cancellationToken);
}

{% endhighlight %}
{% endtabs %}

In the implementation, send the request to your AI service with a system prompt that applies these rules:

| Rule | Purpose |
|------|---------|
| Use only the selected message and earlier messages | Prevents invented details. |
| Do not invent menus, links, account status, policies, or timelines | Keeps the reply accurate. |
| Do not repeat steps the customer already tried | Keeps the reply relevant. |
| Do not ask for passwords, API keys, or authentication codes | Protects customer data. |
| Return plain text under 1,000 characters | Matches the validator. |

N> Treat customer text as untrusted data. Tell the model not to follow instructions inside it.

Place the validated reply in the composer:

{% tabs %}
{% highlight c# %}

var result = await _supportReplyService.DraftReplyAsync(request, cancellationToken);

if (result.IsValid && result.Response is not null)
{
    EditorText = result.Response.Reply;
}

{% endhighlight %}
{% endtabs %}

**Step 6: Validate the reply**

`SupportReplyValidator` rejects a reply before it reaches the composer if it:

* Is empty or longer than 1,000 characters.
* Contains a link.
* Mentions passwords, API keys, or authentication codes.
* Claims an action that did not happen, such as a verification, escalation, refund, or guaranteed outcome.

When a reply is rejected, the agent sees an error message and can retry.

**Step 7: Handle the chips**

Handle the **Regenerate**, **Discard**, and **Retry** chips in `SuggestionItemSelected`. Cancel the default send and keep the chips visible, so the chip text does not become message content.

{% tabs %}
{% highlight c# %}

private async void OnSuggestionItemSelected(object? sender, SuggestionItemSelectedEventArgs e)
{
    e.CancelSendMessage = true;
    e.HideAfterSelection = false;

    await ViewModel.HandleSuggestionActionAsync((e.SelectedItem as Suggestion)?.Text);
}

{% endhighlight %}
{% endtabs %}

| Chip | Action |
|------|--------|
| **Regenerate** | Asks "Replace draft?", then generates a new draft. If it fails, the previous draft is kept. |
| **Discard** | Asks "Discard draft?", then clears the draft and the selection. |
| **Retry** | Repeats a failed first draft. |

**Step 8: Send the reply**

The Send button runs `SendMessageCommand`. Mark the event as handled, and add the reviewed text as a support agent message.

{% tabs %}
{% highlight c# %}

private void SendNativeMessage(object? args)
{
    if (args is not SendMessageEventArgs sendArgs) return;
    sendArgs.Handled = true;

    var text = sendArgs.Message?.Text?.Trim() ?? string.Empty;
    if (text.Length == 0 || text != EditorText.Trim()) return;

    Messages.Add(new TextMessage { Author = CurrentUser, DateTime = DateTime.Now, Text = text });
    SelectedMessage = null;
}

{% endhighlight %}
{% endtabs %}

**Step 9: Register the services**

Register the services in `MauiProgram.cs`.

{% tabs %}
{% highlight c# %}

builder.Services.AddSingleton<ConversationService>();
builder.Services.AddSingleton<IChatSuggestionService, ChatSuggestionService>();
builder.Services.AddSingleton<ISupportReplyService, SupportReplyService>();
builder.Services.AddSingleton<SupportReplyValidator>();
builder.Services.AddTransient<SupportChatViewModel>();
builder.Services.AddTransient<SupportChatPage>();

{% endhighlight %}
{% endtabs %}

## How it works

1. The agent selects a customer message.
2. **Draft Reply** sends the message and recent conversation to the AI service.
3. The validator checks the reply, and the composer shows it.
4. The agent edits it, regenerates it, or discards it.
5. The Send button adds the reviewed reply to the conversation.

## Output

![AI-powered support reply drafting in .NET MAUI Chat](images/support-reply-ai-draft.gif)

## See also

* [Suggestions in .NET MAUI Chat](/maui/chat/suggestions)
* [Messages in .NET MAUI Chat](/maui/chat/messages)
* [AI use-case demos](https://github.com/syncfusion/maui-ai-usecase-demos)
