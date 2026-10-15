---
layout: post
title: AI-Powered Smart Tag Generation in .NET MAUI ChipGroup | Syncfusion®
description: Learn how to generate relevant tags from a text description with Azure OpenAI and the Syncfusion® .NET MAUI ChipGroup control.
platform: maui
control: SfChip
documentation: ug
---

# AI-Powered Smart Tag Generation in .NET MAUI ChipGroup

This article demonstrates how to build an AI-powered tag generator with the Syncfusion® [.NET MAUI ChipGroup](https://help.syncfusion.com/maui/chips/overview) control and Azure OpenAI. The user enters a software feature description, Azure OpenAI proposes relevant tags from a curated vocabulary, and the app displays validated results as wrapping chips.

The sample uses the Azure OpenAI .NET SDK, dependency injection (DI), and a ViewModel that owns the query, results, loading state, and errors. The page appends generated tags one at a time to create a staggered appearance.

## Integrating Azure OpenAI with the .NET MAUI App

Before implementing tag generation, complete the shared [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites) to configure Azure OpenAI and your .NET MAUI application. Also complete the [ChipGroup getting started](https://help.syncfusion.com/maui/chips/getting-started) steps.

## Implementing AI-Powered Smart Tag Generation

**Step 1: Install the required packages**

The sample uses `Syncfusion.Maui.Core` for `SfChipGroup` and `Azure.AI.OpenAI` to connect to Azure OpenAI. Install the Azure OpenAI SDK version used by the sample:

{% tabs %}
{% highlight powershell %}
Install-Package Azure.AI.OpenAI -Version 2.1.0
{% endhighlight %}
{% highlight bash %}
dotnet add package Azure.AI.OpenAI --version 2.1.0
{% endhighlight %}
{% endtabs %}

**Step 2: Define the tag service contract**

Keep the Azure OpenAI call behind an interface so the ViewModel can be tested with a substitute service.

{% tabs %}
{% highlight c# %}
namespace SmartAITags;

public interface IAzureTagService
{
    Task<string> GetCompletionAsync(
        string prompt,
        CancellationToken cancellationToken = default);
}
{% endhighlight %}
{% endtabs %}

**Step 3: Create the Azure OpenAI service**

The service uses `AzureOpenAIClient` and `ChatClient` from `Azure.AI.OpenAI`. Configure the endpoint, deployment name, and API key for your Azure OpenAI resource. The system prompt includes the curated tag vocabulary and requests one applicable tag per line. The ViewModel validates the response against that vocabulary before displaying results.

{% tabs %}
{% highlight c# %}
using System.ClientModel;
using Azure;
using Azure.AI.OpenAI;
using OpenAI.Chat;

namespace SmartAITags;

public sealed class AzureOpenAITagService : IAzureTagService
{
    private const string Endpoint = "YOUR_ENDPOINT";
    private const string DeploymentName = "YOUR_DEPLOYMENT_NAME";
    private const string ApiKey = "YOUR_API_KEY";

    public static readonly string[] TagVocabulary =
    {
        "Login", "Logout", "Authentication", "Authorization", "Biometric",
        "Fingerprint", "FaceID", "TouchID", "Security", "Encryption",
        "Password", "OTP", "MFA", "TwoFactor", "Session", "Token",
        "OAuth", "SSO", "Captcha", "PIN", "Roles", "Permissions", "Access",
        "Audit", "Compliance", "GDPR", "Privacy", "RBAC", "UI", "UX",
        "Dashboard", "Profile", "Settings", "Search", "Filter", "Sorting",
        "Navigation", "Sidebar", "Drawer", "Tabs", "Modal", "Carousel",
        "Grid", "List", "Cards", "Accordion", "Stepper", "Wizard", "Onboarding",
        "Splash", "Theme", "DarkMode", "Localization", "Accessibility", "Responsive",
        "Animation", "Transitions", "Gestures", "Swipe", "Tooltips", "ContextMenu",
        "Breadcrumbs", "Pagination", "Snackbar", "Badges", "Forms", "Database",
        "SQLite", "Storage", "Cache", "CRUD", "Migration", "Backup", "Sync",
        "Offline", "OfflineFirst", "Export", "Import", "Repository", "Validation",
        "Entities", "Chat", "Messaging", "Email", "Notifications", "Push", "SMS",
        "Comments", "Feedback", "Contacts", "Upload", "Download", "Gallery", "Camera",
        "Video", "Audio", "Image", "Player", "Streaming", "Recorder", "Files",
        "Documents", "Scanner", "QRCode", "Payment", "Cart", "Checkout", "Subscription",
        "Invoices", "Wallet", "Refund", "Pricing", "Billing", "Taxes", "Maps",
        "Geolocation", "Location", "Tracking", "Routing", "Geofencing", "Sharing",
        "Likes", "Follow", "Reviews", "Ratings", "Posts", "Feed", "Analytics",
        "Reports", "Charts", "Metrics", "Insights", "Telemetry", "Realtime", "WebSocket",
        "Live", "API", "REST", "GraphQL", "Webhook", "Integration", "ThirdParty", "SDK",
        "CI", "CD", "Wishlist", "Bookings", "Calendar", "Scheduler", "Tasks", "Todos",
        "Reminder", "Survey", "Quiz", "FAQ", "Help", "Support", "Tickets", "Loyalty",
        "Rewards", "Coupons", "Bluetooth", "NFC", "Sensors", "VoIP", "Calls", "Favorites",
        "History", "Bookmarks"
    };

    private static readonly string SystemPrompt =
        "Analyze the meaning and intent of the software feature description. " +
        "Return only relevant tags from the provided vocabulary, one per line, in its exact casing. " +
        "Return all applicable tags without bullets or explanations. " +
        "If no vocabulary tag applies, return Empty.\nVocabulary: " +
        string.Join(", ", TagVocabulary);

    public async Task<string> GetCompletionAsync(
        string prompt,
        CancellationToken cancellationToken = default)
    {
        var client = new AzureOpenAIClient(
            new Uri(Endpoint),
            new AzureKeyCredential(ApiKey));
        var chatClient = client.GetChatClient(DeploymentName);
        var messages = new List<ChatMessage>
        {
            new SystemChatMessage(SystemPrompt),
            new UserChatMessage(prompt)
        };

        ChatCompletion completion;
        try
        {
            completion = await chatClient.CompleteChatAsync(
                messages,
                cancellationToken: cancellationToken);
        }
        catch (ClientResultException ex) when (ex.Status == 401)
        {
            throw new InvalidOperationException(
                "Azure OpenAI returned 401. Verify the API key for the configured endpoint.", ex);
        }
        catch (ClientResultException ex) when (ex.Status == 404)
        {
            throw new InvalidOperationException(
                $"Azure OpenAI returned 404. Verify that deployment '{DeploymentName}' exists.", ex);
        }

        var content = string.Concat(completion.Content.Select(part => part.Text));
        if (string.IsNullOrWhiteSpace(content))
            throw new InvalidOperationException("Azure OpenAI returned empty content.");

        return content.Trim();
    }
}
{% endhighlight %}
{% endtabs %}

The service throws request failures instead of returning error text as a tag. The ViewModel catches these exceptions and exposes a user-facing message through `ErrorMessage`.

N> Never store a production API key in source code. The placeholders above are for illustration; load credentials from a secure configuration provider or secret store at runtime.

**Step 4: Create the tag model**

The `TagModel` exposes a `Name` property that the ChipGroup uses to display each generated tag.

{% tabs %}
{% highlight c# %}
using System.ComponentModel;

namespace SmartAITags;

public class TagModel : INotifyPropertyChanged
{
    private string? _name;

    public string? Name
    {
        get => _name;
        set
        {
            if (_name == value) return;
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    public override string ToString() => Name ?? string.Empty;

    public event PropertyChangedEventHandler? PropertyChanged;
}
{% endhighlight %}
{% endtabs %}

**Step 5: Create the tag-generation ViewModel**

The ViewModel receives `IAzureTagService` through its constructor. It clears old chips before a new request, supports cancellation, validates returned values against `AzureOpenAITagService.TagVocabulary`, removes duplicates, and limits the results to 12 tags. It raises `TagsReady` with canonical tag names; the page appends those names to the observable collection for the staggered display.

The ViewModel exposes `UserQuery`, `IsBusy`, `IsLoading`, `HasTags`, `ShowEmptyState`, `CanGenerate`, and `HasError`. The page binds the query, loading, empty, and error states to its controls. Its generation flow is:

{% tabs %}
{% highlight c# %}
public event EventHandler<IReadOnlyList<string>>? TagsReady;

public async Task GenerateTagsAsync(string? query)
{
    if (string.IsNullOrWhiteSpace(query) || IsBusy) return;

    UserQuery = query;
    Tags.Clear();
    ErrorMessage = null;
    IsBusy = true;

    _cts?.Cancel();
    _cts = new CancellationTokenSource();
    var token = _cts.Token;

    try
    {
        var completion = await _aiService.GetCompletionAsync(query, token);
        token.ThrowIfCancellationRequested();
        TagsReady?.Invoke(this, ParseAndFilterTags(completion));
    }
    catch (OperationCanceledException)
    {
        // A newer request superseded this one.
    }
    catch (Exception ex)
    {
        ErrorMessage = $"AI request failed: {ex.Message}";
    }
    finally
    {
        IsBusy = false;
        HasSearched = true;
    }
}

private static List<string> ParseAndFilterTags(string completion)
{
    if (string.IsNullOrWhiteSpace(completion))
        return new List<string>();

    var results = new List<string>();
    var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    foreach (var raw in completion
        .Split('\n', '\r', StringSplitOptions.RemoveEmptyEntries)
        .Select(value => value.Trim())
        .Where(value => !string.IsNullOrWhiteSpace(value) &&
                        !value.Equals("Empty", StringComparison.OrdinalIgnoreCase) &&
                        !value.StartsWith("Here are", StringComparison.OrdinalIgnoreCase)))
    {
        var value = raw.Trim('•', '-', '*', '.', ')', '[', ']', ',', ';', ':', '\t').Trim();
        if (string.IsNullOrWhiteSpace(value) || value.Length > 40)
            continue;

        var canonical = AzureOpenAITagService.TagVocabulary.FirstOrDefault(
            tag => string.Equals(tag, value, StringComparison.OrdinalIgnoreCase));

        if (canonical is not null && seen.Add(canonical))
            results.Add(canonical);
        if (results.Count >= 12) break;
    }

    return results;
}
{% endhighlight %}
{% endtabs %}

**Step 6: Register the dependencies and build the page**

Register the service, ViewModel, and page in `MauiProgram.cs`. The app resolves the page from DI, and the page constructor sets the injected ViewModel as the `BindingContext`.

{% tabs %}
{% highlight c# %}
builder.Services.AddSingleton<IAzureTagService, AzureOpenAITagService>();
builder.Services.AddSingleton<TagViewModel>();
builder.Services.AddSingleton<TagGeneratorPage>();
{% endhighlight %}
{% endtabs %}

The page uses a multiline `Editor` inside `SfTextInputLayout`, a labeled **Generate tags** button, and a result panel. The panel shows an initial empty state, a loading indicator, generated chips, or an error banner with a dismiss command. A clear icon in the input's trailing view resets the query and results.

{% tabs %}
{% highlight xaml %}
<Editor x:Name="queryEditor"
        Text="{Binding UserQuery, Mode=TwoWay}"
        AutoSize="TextChanges"
        TextChanged="OnQueryTextChanged"
        Completed="OnQueryCompleted" />

<Button Text="Generate tags"
        Command="{Binding GenerateTagsCommand}" />

<Border IsVisible="{Binding HasError}">
    <Grid ColumnDefinitions="*,Auto">
        <Label Text="{Binding ErrorMessage}" />
        <Button Grid.Column="1"
                Text="Dismiss"
                Command="{Binding DismissErrorCommand}" />
    </Grid>
</Border>

<Label Text="Add a content description, then select Generate tags."
       IsVisible="{Binding ShowEmptyState}" />

<ActivityIndicator IsVisible="{Binding IsLoading}"
                   IsRunning="True" />

<syncfusion:SfChipGroup ItemsSource="{Binding Tags}"
                        DisplayMemberPath="Name"
                        ChipType="Action">
    <syncfusion:SfChipGroup.ChipLayout>
        <FlexLayout Direction="Row" Wrap="Wrap" />
    </syncfusion:SfChipGroup.ChipLayout>
</syncfusion:SfChipGroup>
{% endhighlight %}
{% endtabs %}

**Step 7: Display the generated tags**

The page subscribes to `TagsReady` and appends each item through `TagViewModel.AppendTag`. A short delay between items gives the chips their staggered appearance. The page does not directly clear or mutate the `Tags` collection.

{% tabs %}
{% highlight c# %}
private async void OnTagsReady(object? sender, IReadOnlyList<string> tags)
{
    _staggerCts?.Cancel();
    _staggerCts = new CancellationTokenSource();
    var token = _staggerCts.Token;

    try
    {
        foreach (var tag in tags)
        {
            token.ThrowIfCancellationRequested();
            _viewModel.AppendTag(tag);
            await Task.Delay(120, token);
        }
    }
    catch (OperationCanceledException)
    {
        // A newer result or clear action stopped this animation.
    }
}
{% endhighlight %}
{% endtabs %}

## How It Works

1. The user enters a software feature description and selects **Generate tags**.
2. The ViewModel sends the description to the injected Azure OpenAI service.
3. Azure OpenAI returns tag names; the ViewModel keeps only vocabulary matches, removes duplicates, and applies the 12-tag limit.
4. The page appends the validated tags to `SfChipGroup` with a short staggered delay.
5. The user can clear the input and results or dismiss a request error.

## Output

The generated tags appear as wrapping chips in the Syncfusion® .NET MAUI ChipGroup control.

![.NET MAUI Smart Tag generation with AI](images/SmartAITag.gif)

You can find the complete sample in the [MAUI AI use-case demos repository](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master/AI%20Solutions/Chips/SmartTags/SmartAITags).

## See Also

- [AI solution prerequisites](/maui/SmartAISolutions/Prerequisites)
- [ChipGroup getting started](https://help.syncfusion.com/maui/chips/getting-started)
- [ChipGroup overview](https://help.syncfusion.com/maui/chips/overview)
- [Azure OpenAI overview](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai#ProductOverview)
