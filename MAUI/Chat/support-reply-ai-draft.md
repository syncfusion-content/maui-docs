---
layout: post
title: Support Reply AI Drafting in .NET MAUI Chat | Syncfusion®
description: Learn how to implement AI-powered support reply drafting in the Syncfusion® .NET MAUI Chat (SfChat) control, where an agent selects a customer message, reviews an AI-generated draft, and sends it.
platform: maui
control: SfChat
documentation: ug
---

# Support Reply AI Drafting in .NET MAUI Chat

This article demonstrates how to implement an AI-powered support reply drafting workflow in the Syncfusion® [.NET MAUI Chat](https://help.syncfusion.com/maui/chat/overview) (`SfChat`) control using Azure OpenAI.

In customer support scenarios, agents often need to compose responses to inquiries quickly while maintaining accuracy. With AI reply drafting, the agent selects a specific customer message within the conversation and taps **Draft Reply**. The application builds a prompt using the selected message and preceding conversation context, requests a draft from Azure OpenAI, and populates the response directly into the `SfChat` composer for review. The agent can edit, regenerate, discard, or send the reply. The AI assists the agent but never sends messages automatically.

![Support Reply AI Drafting in .NET MAUI Chat](images/support-reply-ai-draft.gif)

## Prerequisites

Before implementing support reply drafting, ensure you have:

1. Followed the shared [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites) to configure Azure OpenAI.
2. Completed the [SfChat getting started](/maui/chat/getting-started) guide.
3. Installed the required NuGet packages:
   * `Syncfusion.Maui.Chat`
   * `Syncfusion.Maui.Core`
   * `Azure.AI.OpenAI`
   * `CommunityToolkit.Mvvm`

## Implementing Support Reply AI Drafting

### Step 1: Define the Request and Response Models

Create records to encapsulate the input data passed to the AI service and the structured validation response.

{% tabs %}
{% highlight c# %}
namespace SupportReplyAIDraft.Models;

public sealed record SupportReplyRequest(
    string SelectedMessageText,
    IReadOnlyList<string> RecentConversationContext);

public sealed record SupportReplyResponse(
    string Reply,
    bool RequiresMoreInformation,
    IReadOnlyList<string> RequestedInformation,
    IReadOnlyList<string> Warnings);

public sealed record SupportReplyValidationResult(
    bool IsValid,
    string? ErrorMessage,
    SupportReplyResponse? Response)
{
    public static SupportReplyValidationResult Success(SupportReplyResponse response)
        => new(true, null, response);

    public static SupportReplyValidationResult Failure(string message)
        => new(false, message, null);
}
{% endhighlight %}
{% endtabs %}

### Step 2: Create the Conversation Service

Create a service to manage the conversation history, identify customer messages, and build chronological context for the AI prompt:

{% tabs %}
{% highlight c# %}
using System.Collections.ObjectModel;
using Syncfusion.Maui.Chat;

namespace SupportReplyAIDraft.Services;

public sealed class ConversationService
{
    private readonly Author _customerAuthor = new() { Name = "Alex Morgan" };
    private readonly Author _supportAuthor = new() { Name = "Jordan Lee" };

    public Author SupportAuthor => _supportAuthor;

    public ObservableCollection<object> CreateConversation()
    {
        return new ObservableCollection<object>
        {
            new TextMessage { Author = _customerAuthor, DateTime = DateTime.Today.AddHours(9).AddMinutes(12), Text = "Hello, I renewed my subscription yesterday, but the app still shows my license has expired." },
            new TextMessage { Author = _supportAuthor, DateTime = DateTime.Today.AddHours(9).AddMinutes(15), Text = "Thanks for contacting support. Did the renewal complete successfully in your account?" },
            new TextMessage { Author = _customerAuthor, DateTime = DateTime.Today.AddHours(9).AddMinutes(17), Text = "Yes, the renewal was successful and I received a confirmation email." },
            new TextMessage { Author = _customerAuthor, DateTime = DateTime.Today.AddHours(9).AddMinutes(18), Text = "I restarted the application, but the expired-license message is still displayed. What should I do next?" }
        };
    }

    public bool IsCustomerMessage(TextMessage message) =>
        message.Author?.Name == _customerAuthor.Name;

    public IReadOnlyList<string> BuildRecentContext(IEnumerable<object> conversation, TextMessage selectedMessage)
    {
        var list = conversation.OfType<TextMessage>().ToList();
        var index = list.FindIndex(item => ReferenceEquals(item, selectedMessage));
        if (index < 0) return Array.Empty<string>();

        return list.Take(index + 1)
            .Select(item => $"{item.Author?.Name ?? "User"} ({item.DateTime:h:mm tt}): {item.Text}")
            .ToList();
    }
}
{% endhighlight %}
{% endtabs %}

### Step 3: Implement the AI Support Reply Service and Validator

Create `ISupportReplyService` to request draft replies from Azure OpenAI using structured system instructions and context guardrails, and `SupportReplyValidator` to verify length and content safety:

{% tabs %}
{% highlight c# %}
using Azure.AI.OpenAI;
using OpenAI.Chat;
using SupportReplyAIDraft.Models;

namespace SupportReplyAIDraft.Services;

public interface ISupportReplyService
{
    Task<SupportReplyValidationResult> DraftReplyAsync(SupportReplyRequest request, CancellationToken cancellationToken);
}

public sealed class SupportReplyService : ISupportReplyService
{
    private const string SystemPrompt = """
        You are a senior customer-support specialist drafting the next response for a human agent to review, edit, and send.
        - Write a natural, concise, professional reply to the selected customer message.
        - Use only facts from the conversation context. Do not repeat troubleshooting steps already completed.
        - Never invent product menus, URLs, account statuses, policies, or guarantees.
        - Keep the reply under 1000 characters. Return only plain text.
        """;

    private readonly ChatClient _chatClient;
    private readonly SupportReplyValidator _validator;

    public SupportReplyService(ChatClient chatClient, SupportReplyValidator validator)
    {
        _chatClient = chatClient;
        _validator = validator;
    }

    public async Task<SupportReplyValidationResult> DraftReplyAsync(SupportReplyRequest request, CancellationToken cancellationToken)
    {
        var messages = new List<ChatMessage>
        {
            new SystemChatMessage(SystemPrompt),
            new UserChatMessage(BuildPrompt(request))
        };

        try
        {
            var completion = await _chatClient.CompleteChatAsync(messages, cancellationToken: cancellationToken);
            var reply = completion.Value.Content[0].Text.Trim();
            return _validator.Validate(reply);
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            throw;
        }
        catch (Exception)
        {
            return SupportReplyValidationResult.Failure("The AI service is currently unavailable.");
        }
    }

    private static string BuildPrompt(SupportReplyRequest request)
    {
        var context = request.RecentConversationContext.Count == 0
            ? "(No previous context)"
            : string.Join(Environment.NewLine, request.RecentConversationContext);

        return $"""
            SELECTED CUSTOMER MESSAGE:
            {request.SelectedMessageText}

            CONVERSATION CONTEXT:
            {context}

            Draft a clear, actionable support reply for the agent to review.
            """;
    }
}

public sealed class SupportReplyValidator
{
    private const int MaxCharacterLimit = 1000;

    public SupportReplyValidationResult Validate(string? replyText)
    {
        if (string.IsNullOrWhiteSpace(replyText))
            return SupportReplyValidationResult.Failure("The AI service returned an empty response.");

        var text = replyText.Trim();
        if (text.Length > MaxCharacterLimit)
            return SupportReplyValidationResult.Failure($"The generated reply exceeds the {MaxCharacterLimit}-character limit.");

        return SupportReplyValidationResult.Success(new SupportReplyResponse(text, false, Array.Empty<string>(), Array.Empty<string>()));
    }
}
{% endhighlight %}
{% endtabs %}

### Step 4: Configure the Chat Suggestion Service

Create `ChatSuggestionService` to build suggestion chips (**Regenerate**, **Discard**, **Retry**) displayed in `SfChat.Suggestions`:

{% tabs %}
{% highlight c# %}
using System.Collections.ObjectModel;
using Syncfusion.Maui.Chat;

namespace SupportReplyAIDraft.Services;

public interface IChatSuggestionService
{
    ChatSuggestions Create(params string[] items);
}

public sealed class ChatSuggestionService : IChatSuggestionService
{
    public ChatSuggestions Create(params string[] items)
    {
        return new ChatSuggestions
        {
            Items = new ObservableCollection<ISuggestion>(
                items.Select(item => new Suggestion(item)))
        };
    }
}
{% endhighlight %}
{% endtabs %}

### Step 5: Implement the ViewModel

The `SupportChatViewModel` coordinates message selection, AI drafting, state transitions, suggestion chips, and message submission:

{% tabs %}
{% highlight c# %}
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Syncfusion.Maui.Chat;
using SupportReplyAIDraft.Models;
using SupportReplyAIDraft.Services;

namespace SupportReplyAIDraft.ViewModels;

public sealed partial class SupportChatViewModel : ObservableObject
{
    private readonly ConversationService _conversationService;
    private readonly ISupportReplyService _replyService;
    private readonly IChatSuggestionService _suggestionService;
    private CancellationTokenSource? _generationCts;
    private WorkflowState _workflowState = WorkflowState.Initial;

    public SupportChatViewModel(
        ConversationService conversationService,
        ISupportReplyService replyService,
        IChatSuggestionService suggestionService)
    {
        _conversationService = conversationService;
        _replyService = replyService;
        _suggestionService = suggestionService;

        CurrentUser = _conversationService.SupportAuthor;
        Messages = _conversationService.CreateConversation();
        NativeSendCommand = new Command<object?>(SendNativeMessage);

        TransitionTo(WorkflowState.Initial);
    }

    public ObservableCollection<object> Messages { get; }
    public Author CurrentUser { get; }
    public ICommand NativeSendCommand { get; }

    [ObservableProperty] public partial TextMessage? SelectedMessage { get; set; }
    [ObservableProperty] public partial ChatSuggestions? ChatSuggestions { get; set; }
    [ObservableProperty] public partial string EditorText { get; set; } = string.Empty;
    [ObservableProperty] public partial string ComposerPlaceholder { get; set; } = "Select a customer message to begin.";
    [ObservableProperty] public partial bool IsComposerEnabled { get; set; }
    [ObservableProperty] public partial bool IsComposerReadOnly { get; set; } = true;
    [ObservableProperty] public partial bool IsDrafting { get; set; }
    [ObservableProperty] public partial bool HasDraft { get; set; }
    [ObservableProperty] public partial bool ShowReviewHint { get; set; }
    [ObservableProperty] public partial bool ShowErrorMessage { get; set; }
    [ObservableProperty] public partial string InlineMessage { get; set; } = string.Empty;
    [ObservableProperty] public partial string ProgressMessage { get; set; } = string.Empty;

    public bool CanDraftReply => _workflowState == WorkflowState.Selected && SelectedMessage is not null;
    public bool IsDraftReplyVisible => CanDraftReply;

    public Func<Task<bool>>? ConfirmRegenerateAsync { get; set; }
    public Func<Task<bool>>? ConfirmSelectionChangeAsync { get; set; }
    public event Action<TextMessage>? OutgoingMessageSent;

    [RelayCommand]
    private async Task SelectMessageAsync(TextMessage? message)
    {
        if (message is null || !_conversationService.IsCustomerMessage(message) || IsDrafting)
            return;

        if (ReferenceEquals(SelectedMessage, message))
        {
            SelectedMessage = null;
            TransitionTo(WorkflowState.Initial);
            return;
        }

        if (HasDraft && ConfirmSelectionChangeAsync is not null)
        {
            if (!await ConfirmSelectionChangeAsync()) return;
        }

        SelectedMessage = message;
        TransitionTo(WorkflowState.Selected);
    }

    [RelayCommand(CanExecute = nameof(CanDraftReply))]
    private async Task DraftReplyAsync(TextMessage? message)
    {
        if (SelectedMessage is null || IsDrafting) return;
        await GenerateDraftAsync(WorkflowState.Drafting, preserveDraftOnFailure: false);
    }

    public async Task HandleSuggestionActionAsync(string? action)
    {
        if (string.IsNullOrWhiteSpace(action) || IsDrafting) return;

        switch (action.Trim())
        {
            case "Discard":
                _generationCts?.Cancel();
                SelectedMessage = null;
                TransitionTo(WorkflowState.Initial);
                break;

            case "Regenerate":
                if (SelectedMessage is null || !HasDraft) return;
                if (ConfirmRegenerateAsync is not null && !await ConfirmRegenerateAsync()) return;
                await GenerateDraftAsync(WorkflowState.Regenerating, preserveDraftOnFailure: true);
                break;

            case "Retry":
                if (SelectedMessage is not null)
                    await GenerateDraftAsync(HasDraft ? WorkflowState.Regenerating : WorkflowState.Retrying, preserveDraftOnFailure: HasDraft);
                break;
        }
    }

    private async Task GenerateDraftAsync(WorkflowState state, bool preserveDraftOnFailure)
    {
        var preservedDraft = preserveDraftOnFailure ? EditorText : string.Empty;
        _generationCts?.Cancel();
        _generationCts = new CancellationTokenSource();
        var token = _generationCts.Token;

        TransitionTo(state, preservedDraft: preservedDraft);

        var request = new SupportReplyRequest(
            SelectedMessage!.Text,
            _conversationService.BuildRecentContext(Messages, SelectedMessage));

        try
        {
            var result = await _replyService.DraftReplyAsync(request, token);

            if (result.IsValid && result.Response is not null)
            {
                TransitionTo(WorkflowState.Generated, generatedReply: result.Response.Reply);
            }
            else
            {
                TransitionTo(WorkflowState.Error, preserveDraft: preserveDraftOnFailure, preservedDraft: preservedDraft, errorMessage: result.ErrorMessage);
            }
        }
        catch (OperationCanceledException) when (token.IsCancellationRequested) { }
        catch
        {
            TransitionTo(WorkflowState.Error, preserveDraft: preserveDraftOnFailure, preservedDraft: preservedDraft, errorMessage: "Generation failed. Please try again.");
        }
    }

    private void TransitionTo(WorkflowState state, string? generatedReply = null, bool preserveDraft = false, string preservedDraft = "", string? errorMessage = null)
    {
        _workflowState = state;

        switch (state)
        {
            case WorkflowState.Initial:
            case WorkflowState.Selected:
            case WorkflowState.Sent:
                IsDrafting = false;
                HasDraft = false;
                ShowReviewHint = false;
                ShowErrorMessage = false;
                ChatSuggestions = null;
                IsComposerEnabled = false;
                IsComposerReadOnly = true;
                ComposerPlaceholder = "Select a customer message to begin.";
                EditorText = string.Empty;
                break;

            case WorkflowState.Drafting:
            case WorkflowState.Retrying:
                IsDrafting = true;
                ProgressMessage = state == WorkflowState.Drafting ? "Drafting reply..." : "Retrying draft...";
                ChatSuggestions = null;
                IsComposerEnabled = false;
                IsComposerReadOnly = true;
                EditorText = string.Empty;
                break;

            case WorkflowState.Regenerating:
                IsDrafting = true;
                ProgressMessage = "Regenerating reply...";
                ChatSuggestions = null;
                IsComposerEnabled = true;
                IsComposerReadOnly = true;
                EditorText = preservedDraft;
                break;

            case WorkflowState.Generated:
                IsDrafting = false;
                HasDraft = true;
                ShowReviewHint = true;
                ShowErrorMessage = false;
                InlineMessage = "Review and edit before sending.";
                ChatSuggestions = _suggestionService.Create("Regenerate", "Discard");
                IsComposerEnabled = true;
                IsComposerReadOnly = false;
                ComposerPlaceholder = string.Empty;
                EditorText = generatedReply ?? string.Empty;
                break;

            case WorkflowState.Error:
                IsDrafting = false;
                ShowErrorMessage = true;
                ShowReviewHint = false;
                InlineMessage = errorMessage ?? "Unable to draft reply.";

                if (preserveDraft && !string.IsNullOrWhiteSpace(preservedDraft))
                {
                    HasDraft = true;
                    ChatSuggestions = _suggestionService.Create("Regenerate", "Discard");
                    IsComposerEnabled = true;
                    IsComposerReadOnly = false;
                    EditorText = preservedDraft;
                }
                else
                {
                    HasDraft = false;
                    ChatSuggestions = _suggestionService.Create("Retry");
                    IsComposerEnabled = false;
                    IsComposerReadOnly = true;
                    ComposerPlaceholder = "Unable to generate reply.";
                    EditorText = string.Empty;
                }
                break;
        }

        DraftReplyCommand.NotifyCanExecuteChanged();
        OnPropertyChanged(nameof(CanDraftReply));
        OnPropertyChanged(nameof(IsDraftReplyVisible));
    }

    private void SendNativeMessage(object? args)
    {
        if (args is not SendMessageEventArgs sendArgs) return;
        sendArgs.Handled = true;

        if (IsDrafting || !IsComposerEnabled || IsComposerReadOnly) return;
        var text = sendArgs.Message?.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrEmpty(text) || text != EditorText.Trim()) return;

        var message = new TextMessage
        {
            Author = _conversationService.SupportAuthor,
            DateTime = DateTime.Now,
            Text = text
        };

        Messages.Add(message);
        OutgoingMessageSent?.Invoke(message);
        SelectedMessage = null;
        TransitionTo(WorkflowState.Sent);
    }

    private enum WorkflowState { Initial, Selected, Drafting, Retrying, Regenerating, Generated, Error, Sent }
}
{% endhighlight %}
{% endtabs %}

### Step 6: Create the Message Templates and Selector

Create a multi-value converter to identify the currently selected message:

{% tabs %}
{% highlight c# %}
using System.Globalization;

namespace SupportReplyAIDraft.Converters;

public sealed class SelectedMessageMatchConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        return values.Length >= 2 && ReferenceEquals(values[0], values[1]);
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
{% endhighlight %}
{% endtabs %}

Define `CustomerMessageTemplateView.xaml` to display the customer message with selection highlight, the **Draft Reply** button, and progress indicators:

{% tabs %}
{% highlight xaml %}
<ContentView xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:chat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
             xmlns:views="clr-namespace:SupportReplyAIDraft.Views"
             x:Class="SupportReplyAIDraft.Views.MessageTemplates.CustomerMessageTemplateView"
             x:DataType="chat:TextMessage">

    <VerticalStackLayout Spacing="4" Margin="0,0,0,8" HorizontalOptions="Start">
        <HorizontalStackLayout Spacing="8">
            <Label Text="{Binding Author.Name}" FontAttributes="Bold" />
            <Label Text="{Binding DateTime, StringFormat='{0:h:mm tt}'}" />
        </HorizontalStackLayout>

        <Border Padding="12" StrokeThickness="1" StrokeShape="RoundRectangle 8">
            <Border.Triggers>
                <DataTrigger TargetType="Border" Value="True">
                    <DataTrigger.Binding>
                        <MultiBinding Converter="{StaticResource SelectedMessageMatchConverter}">
                            <Binding Path="." />
                            <Binding Path="ViewModel.SelectedMessage"
                                     Source="{RelativeSource AncestorType={x:Type views:SupportChatPage}}"
                                     x:DataType="views:SupportChatPage" />
                        </MultiBinding>
                    </DataTrigger.Binding>
                    <Setter Property="Stroke" Value="#0066CC" />
                    <Setter Property="StrokeThickness" Value="2" />
                </DataTrigger>
            </Border.Triggers>

            <VerticalStackLayout Spacing="8">
                <!-- Message Text -->
                <Label Text="{Binding Text}">
                    <Label.GestureRecognizers>
                        <TapGestureRecognizer
                            Command="{Binding Source={RelativeSource AncestorType={x:Type views:SupportChatPage}}, Path=SelectMessageCommand, x:DataType=views:SupportChatPage}"
                            CommandParameter="{Binding .}" />
                    </Label.GestureRecognizers>
                </Label>

                <!-- Draft Reply Button -->
                <Button Text="✦ Draft Reply"
                        IsEnabled="{Binding Source={RelativeSource AncestorType={x:Type views:SupportChatPage}}, Path=ViewModel.CanDraftReply, x:DataType=views:SupportChatPage}"
                        Command="{Binding Source={RelativeSource AncestorType={x:Type views:SupportChatPage}}, Path=DraftReplyCommand, x:DataType=views:SupportChatPage}"
                        CommandParameter="{Binding .}"
                        IsVisible="False"
                        BackgroundColor="Transparent"
                        TextColor="#0066CC"
                        FontAttributes="Bold"
                        HorizontalOptions="Start">
                    <Button.Triggers>
                        <DataTrigger TargetType="Button" Value="True">
                            <DataTrigger.Binding>
                                <MultiBinding Converter="{StaticResource SelectedMessageMatchConverter}">
                                    <Binding Path="." />
                                    <Binding Path="ViewModel.SelectedMessage"
                                             Source="{RelativeSource AncestorType={x:Type views:SupportChatPage}}"
                                             x:DataType="views:SupportChatPage" />
                                </MultiBinding>
                            </DataTrigger.Binding>
                            <Setter Property="IsVisible" Value="True" />
                        </DataTrigger>
                    </Button.Triggers>
                </Button>

                <!-- Progress Indicator -->
                <HorizontalStackLayout Spacing="8"
                                       IsVisible="{Binding Source={RelativeSource AncestorType={x:Type views:SupportChatPage}}, Path=ViewModel.IsDrafting, x:DataType=views:SupportChatPage}">
                    <ActivityIndicator IsRunning="True" WidthRequest="16" HeightRequest="16" Color="#0066CC" />
                    <Label Text="{Binding Source={RelativeSource AncestorType={x:Type views:SupportChatPage}}, Path=ViewModel.ProgressMessage, x:DataType=views:SupportChatPage}"
                           FontSize="12" TextColor="#0066CC" />
                </HorizontalStackLayout>
            </VerticalStackLayout>
        </Border>
    </VerticalStackLayout>
</ContentView>
{% endhighlight %}
{% endtabs %}

Create `SupportChatMessageTemplateSelector.cs` to apply `CustomerMessageTemplateView` for incoming customer messages and standard styling for agent messages:

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Chat;

namespace SupportReplyAIDraft.Views.MessageTemplates;

public sealed class SupportChatMessageTemplateSelector : ChatMessageTemplateSelector
{
    private readonly SfChat _chat;
    private readonly DataTemplate _customerTemplate;
    private readonly DataTemplate _agentTemplate;

    public SupportChatMessageTemplateSelector(SfChat chat) : base(chat)
    {
        _chat = chat;
        _customerTemplate = new DataTemplate(typeof(CustomerMessageTemplateView));
        _agentTemplate = new DataTemplate(typeof(AgentMessageTemplateView));
    }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is not TextMessage message) return _customerTemplate;

        var isAgent = ReferenceEquals(message.Author, _chat.CurrentUser)
            || string.Equals(message.Author?.Name, _chat.CurrentUser?.Name, StringComparison.Ordinal);

        return isAgent ? _agentTemplate : _customerTemplate;
    }
}
{% endhighlight %}
{% endtabs %}

### Step 7: Build the Chat Page UI

In `SupportChatPage.xaml`, configure the `SfChat` control with message bindings, suggestions, and send command:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:chat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
             xmlns:viewModels="clr-namespace:SupportReplyAIDraft.ViewModels"
             x:Class="SupportReplyAIDraft.Views.SupportChatPage"
             x:DataType="viewModels:SupportChatViewModel"
             Title="Support Reply AI Draft">

    <chat:SfChat x:Name="ConversationChat"
                 Messages="{Binding Messages}"
                 CurrentUser="{Binding CurrentUser}"
                 Suggestions="{Binding ChatSuggestions}"
                 SuggestionItemSelected="OnSuggestionItemSelected"
                 SendMessageCommand="{Binding NativeSendCommand}"
                 ShowMessageInputView="True"
                 AllowMultilineInput="True"
                 MessageSpacing="8" />
</ContentPage>
{% endhighlight %}
{% highlight c# %}
using System.ComponentModel;
using System.Windows.Input;
using Syncfusion.Maui.Chat;
using SupportReplyAIDraft.ViewModels;
using SupportReplyAIDraft.Views.MessageTemplates;

namespace SupportReplyAIDraft.Views;

public partial class SupportChatPage : ContentPage
{
    private bool _isUpdatingEditorText;

    public SupportChatViewModel ViewModel { get; }

    public ICommand SelectMessageCommand => ViewModel.SelectMessageCommand;
    public ICommand DraftReplyCommand => ViewModel.DraftReplyCommand;

    public SupportChatPage(SupportChatViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        BindingContext = ViewModel;

        ConversationChat.MessageTemplate = new SupportChatMessageTemplateSelector(ConversationChat);

        ViewModel.ConfirmRegenerateAsync = () => DisplayAlertAsync(
            "Replace draft?", "Regenerating will replace the current draft.", "Regenerate", "Cancel");

        ViewModel.ConfirmSelectionChangeAsync = () => DisplayAlertAsync(
            "Discard draft?", "Selecting another message will discard the current draft.", "Discard", "Cancel");

        ViewModel.PropertyChanged += OnViewModelPropertyChanged;
        ViewModel.OutgoingMessageSent += message => ConversationChat.ScrollToMessage(message);

        Loaded += (_, _) =>
        {
            ConversationChat.Editor.TextChanged += OnEditorTextChanged;
            UpdateComposerState();
        };
    }

    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName is nameof(SupportChatViewModel.ComposerPlaceholder)
            or nameof(SupportChatViewModel.IsComposerEnabled)
            or nameof(SupportChatViewModel.IsComposerReadOnly)
            or nameof(SupportChatViewModel.EditorText))
        {
            UpdateComposerState();
        }
    }

    private void UpdateComposerState()
    {
        if (ConversationChat.Editor is null) return;

        _isUpdatingEditorText = true;
        try
        {
            ConversationChat.Editor.IsEnabled = ViewModel.IsComposerEnabled;
            ConversationChat.Editor.IsReadOnly = ViewModel.IsComposerReadOnly;
            ConversationChat.Editor.Placeholder = ViewModel.ComposerPlaceholder;

            if (ConversationChat.Editor.Text != ViewModel.EditorText)
                ConversationChat.Editor.Text = ViewModel.EditorText;
        }
        finally
        {
            _isUpdatingEditorText = false;
        }
    }

    private void OnEditorTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (!_isUpdatingEditorText)
            ViewModel.EditorText = e.NewTextValue ?? string.Empty;
    }

    private async void OnSuggestionItemSelected(object? sender, SuggestionItemSelectedEventArgs e)
    {
        e.CancelSendMessage = true;
        e.HideAfterSelection = false;
        await ViewModel.HandleSuggestionActionAsync((e.SelectedItem as Suggestion)?.Text);
    }
}
{% endhighlight %}
{% endtabs %}

### Step 8: Register Services in MauiProgram

Register the services, ViewModel, and view in `MauiProgram.cs`:

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
using SupportReplyAIDraft.Services;
using SupportReplyAIDraft.ViewModels;
using SupportReplyAIDraft.Views;

namespace SupportReplyAIDraft;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore();

        builder.Services.AddSingleton<ConversationService>();
        builder.Services.AddSingleton<IChatSuggestionService, ChatSuggestionService>();
        builder.Services.AddSingleton<SupportReplyValidator>();
        builder.Services.AddSingleton<ISupportReplyService, SupportReplyService>();
        builder.Services.AddTransient<SupportChatViewModel>();
        builder.Services.AddTransient<SupportChatPage>();

        return builder.Build();
    }
}
{% endhighlight %}
{% endtabs %}

N> Register the `ChatClient` configured with your Azure OpenAI credentials in dependency injection as described in the [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites).

## How It Works

1. **Message Selection**: The agent taps a customer message. `SelectMessageCommand` updates `SelectedMessage`, highlights the message bubble, and reveals the **Draft Reply** button.
2. **Contextual AI Generation**: Tapping **Draft Reply** gathers the selected customer message and preceding conversation history into `SupportReplyRequest`. The AI service generates a draft using system prompt safety constraints.
3. **Response Validation**: `SupportReplyValidator` verifies the reply is under 1000 characters and valid before displaying it.
4. **Composer Integration**: The validated draft is placed into the `SfChat.Editor`, enabling the composer for agent review and manual edits.
5. **Suggestion Actions**: Contextual chips appear above the composer:
   * **Regenerate**: Generates a new draft after confirmation. If generation fails, the previous draft is preserved.
   * **Discard**: Clears the current draft, composer, and selected message.
   * **Retry**: Appears when a first draft fails, allowing the agent to re-attempt generation.
6. **Human Verification & Sending**: The agent reviews the text and taps the native Send button. `SfChat.SendMessageCommand` posts the message to the conversation. The AI never sends a reply automatically.

## Output

The following illustration demonstrates the interactive AI reply drafting workflow in the .NET MAUI Chat control:

![Support reply AI draft demonstration](images/support-reply-ai-draft.gif)

You can download the complete working sample from [GitHub](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master/AI%20Solutions/Chat/SupportReplyAIDraft).

## See Also

* [SfChat Overview](/maui/chat/overview)
* [SfChat Getting Started](/maui/chat/getting-started)
* [SfChat Message Customization](/maui/chat/messages)
* [SfChat Suggestion Chips](/maui/chat/suggestions)
* [Azure OpenAI Integration Prerequisites](/maui/SmartAISolutions/Prerequisites)
