---
layout: post
title: AI-Powered Smart Tag Generation in .NET MAUI ChipGroup | Syncfusion®
description: Learn how to implement AI-powered smart tag generation with the Syncfusion® .NET MAUI ChipGroup control and Azure OpenAI.
platform: maui
control: SfChipGroup
documentation: ug
---

# AI-Powered Smart Tag Generation in .NET MAUI ChipGroup

This article walks you through the implementation of an intelligent, AI-driven tag generation experience using the Syncfusion® .NET MAUI ChipGroup control. The user describes a feature, product requirement, or business scenario in natural language, and Azure OpenAI automatically analyzes the content and generates the most relevant tags.

For example:

* **Build a secure login system with biometric authentication and OTP verification**

Automatically generates:

* Login
* Authentication
* Security
* Biometric
* OTP
* MFA

**Expected Outcome:** Users simply describe their requirements in natural language, and AI automatically generates meaningful tags without requiring manual entry.

**One-line Value:** AI understands the intent, and the ChipGroup instantly displays relevant tags.

## Prerequisites

Before you begin, ensure you have the following:

* A working .NET MAUI application with the Syncfusion.Maui.Core package installed.
* An active Azure subscription with access to Azure OpenAI and a deployed model.
* Deployment name, endpoint URL, and API key from your Azure OpenAI resource.
* Azure.AI.OpenAI NuGet package or a REST-based Azure OpenAI integration.

Install the package:

```powershell
Install-Package Azure.AI.OpenAI -Version 2.1.0
```

Or using .NET CLI:

```bash
dotnet add package Azure.AI.OpenAI --version 2.1.0
```

---

## Integrating Azure OpenAI with your .NET MAUI App

First, ensure that you have access to Azure OpenAI and have created a deployment in the Azure portal.

The application uses Azure OpenAI to analyze a natural language description and determine which tags best represent the requested feature or functionality.

Create a service named `AzureOpenAITagService`.

The service:

* Sends the user description to Azure OpenAI.
* Restricts output to a predefined tag vocabulary.
* Returns only valid tags.
* Handles API errors and response validation.

### AzureOpenAITagService.cs

```csharp
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace SmartAITags.Services
{
    public sealed class AzureOpenAITagService
    {
        private const string BaseEndpoint =
            "YOUR_END_POINT";

        private const string DeploymentName =
            "YOUR_DEPLOYMENT_NAME";

        private const string ApiKey =
            "YOUR_API_KEY";

        public static readonly string[] TagVocabulary =
        {
            "Login","Logout","Authentication","Authorization","Biometric",
            "Fingerprint","FaceID","TouchID","Security","Encryption",
            "Password","OTP","MFA","TwoFactor","Session","Token",
            "OAuth","SSO","Captcha","PIN","Roles","Permissions",
            "Access","Audit","Compliance","GDPR","Privacy","RBAC",

            "UI","UX","Dashboard","Profile","Settings","Search",
            "Filter","Sorting","Navigation","Sidebar","Drawer",
            "Tabs","Modal","Carousel","Grid","List","Cards",
            "Accordion","Stepper","Wizard","Onboarding","Splash",
            "Theme","DarkMode","Localization","Accessibility",
            "Responsive","Animation","Transitions","Gestures",
            "Swipe","Tooltips","ContextMenu","Breadcrumbs",
            "Pagination","Snackbar","Badges","Forms",

            "Database","SQLite","Storage","Cache","CRUD",
            "Migration","Backup","Sync","Offline",
            "OfflineFirst","Export","Import",
            "Repository","Validation","Entities",

            "Chat","Messaging","Email","Notifications",
            "Push","SMS","Comments","Feedback","Contacts",

            "Upload","Download","Gallery","Camera",
            "Video","Audio","Image","Player",
            "Streaming","Recorder","Files",
            "Documents","Scanner","QRCode",

            "Payment","Cart","Checkout",
            "Subscription","Invoices",
            "Wallet","Refund","Pricing",
            "Billing","Taxes",

            "Maps","Geolocation","Location",
            "Tracking","Routing","Geofencing",

            "Sharing","Likes","Follow",
            "Reviews","Ratings","Posts","Feed",

            "Analytics","Reports","Charts",
            "Metrics","Insights","Telemetry",

            "Realtime","WebSocket","Live",

            "API","REST","GraphQL","Webhook",
            "Integration","ThirdParty","SDK",
            "CI","CD",

            "Wishlist","Bookings","Calendar",
            "Scheduler","Tasks","Todos",
            "Reminder","Survey","Quiz","FAQ",
            "Help","Support","Tickets",
            "Loyalty","Rewards","Coupons",
            "Bluetooth","NFC","Sensors",
            "VoIP","Calls","Favorites",
            "History","Bookmarks"
        };

        private static readonly string SystemPrompt =
            "You are an AI tag-classification assistant. " +
            "Return ONLY tags from the provided vocabulary. " +
            "Return one tag per line. " +
            "No explanations. " +
            "If no tag applies return Empty.";

        private static readonly HttpClient Http = new()
        {
            Timeout = TimeSpan.FromSeconds(60)
        };

        public string? LastError { get; private set; }

        public string LastRawResponse { get; private set; } = string.Empty;

        public async Task<string> GetCompletion(
            string prompt,
            CancellationToken cancellationToken = default)
        {
            LastError = null;

            try
            {
                var requestBody = new
                {
                    model = DeploymentName,
                    messages = new object[]
                    {
                        new
                        {
                            role = "system",
                            content = SystemPrompt
                        },
                        new
                        {
                            role = "user",
                            content = prompt
                        }
                    },
                    max_completion_tokens = 1024,
                    reasoning_effort = "minimal"
                };

                var url = $"{BaseEndpoint}/chat/completions";

                using var request =
                    new HttpRequestMessage(HttpMethod.Post, url);

                request.Headers.Add("api-key", ApiKey);

                request.Content = new StringContent(
                    JsonSerializer.Serialize(requestBody),
                    Encoding.UTF8,
                    "application/json");

                var response =
                    await Http.SendAsync(request, cancellationToken);

                var raw =
                    await response.Content.ReadAsStringAsync(cancellationToken);

                LastRawResponse = raw;

                if (!response.IsSuccessStatusCode)
                {
                    LastError =
                        $"HTTP {(int)response.StatusCode}\n\n{raw}";
                    return LastError;
                }

                using var document = JsonDocument.Parse(raw);

                return document.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString()?
                    .Trim() ?? string.Empty;
            }
            catch (Exception ex)
            {
                LastError = ex.ToString();
                return LastError;
            }
        }
    }
}
```

---

## Implementing AI-Powered Smart Tag Generation

The Syncfusion® .NET MAUI ChipGroup control can display tags generated dynamically by AI. The user enters a natural language description, Azure OpenAI analyzes the request, and the generated tags appear automatically as chips.

### Step 1: Create a Tag Model

Create a business model representing each generated tag.

### TagModel.cs

```csharp
using System.ComponentModel;

namespace SmartAITags.Model
{
    public class TagModel : INotifyPropertyChanged
    {
        private string? _name;

        public string? Name
        {
            get => _name;
            set
            {
                if (_name == value)
                    return;

                _name = value;

                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public override string ToString()
            => Name ?? string.Empty;

        public event PropertyChangedEventHandler?
            PropertyChanged;
    }
}
```

---

### Step 2: Create the ViewModel

The ViewModel:

* Maintains the generated tags.
* Stores the user's description.
* Calls Azure OpenAI.
* Parses the AI response.
* Raises an event when tags are generated.

### TagViewModel.cs

```csharp
public class TagViewModel : INotifyPropertyChanged
{
    private readonly AzureOpenAITagService _aiService = new();

    public ObservableCollection<TagModel> Tags { get; }

    public ICommand GenerateTagsCommand { get; }

    public event EventHandler<IEnumerable<string>>? TagsReceived;

    public TagViewModel()
    {
        Tags = new ObservableCollection<TagModel>();

        GenerateTagsCommand =
            new Command(async () =>
                await GenerateTagsAsync());
    }

    public async Task GenerateTagsAsync(string? query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return;

        string completion =
            await _aiService.GetCompletion(query);

        var tags = ParseAndFilterTags(completion);

        TagsReceived?.Invoke(this, tags);
    }

    private static List<string> ParseAndFilterTags(
        string completion)
    {
        return completion
            .Split('\n', '\r',
                StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public event PropertyChangedEventHandler?
        PropertyChanged;
}
```

---

### Step 3: Build the User Interface

Create a page containing:

* A natural language input editor.
* A Generate Tags button.
* A Syncfusion ChipGroup for displaying generated tags.
* A loading indicator.

### TagGeneratorPage.xaml

```xml
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    xmlns:viewModel="clr-namespace:SmartAITags.ViewModel">

    <ContentPage.BindingContext>
        <viewModel:TagViewModel />
    </ContentPage.BindingContext>

    <VerticalStackLayout Padding="20">

        <Label Text="AI-Powered Auto Tag Generator"
               FontAttributes="Bold"
               FontSize="22"
               HorizontalTextAlignment="Center"/>

        <Editor
            x:Name="queryEditor"
            Placeholder="Describe your requirements..." />

        <Button
            Text="Generate Tags"
            Command="{Binding GenerateTagsCommand}" />

        <syncfusion:SfChipGroup
            x:Name="chipsControl"
            ChipType="Action"
            DisplayMemberPath="Name"
            ItemsSource="{Binding Tags}" />

    </VerticalStackLayout>

</ContentPage>
```

---

### Step 4: Display Tags Generated by AI

Handle the ViewModel event and update the ChipGroup collection.

### TagGeneratorPage.xaml.cs

```csharp
public partial class TagGeneratorPage : ContentPage
{
    public TagGeneratorPage()
    {
        InitializeComponent();
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        if (BindingContext is TagViewModel vm)
        {
            vm.TagsReceived -= OnTagsReceived;
            vm.TagsReceived += OnTagsReceived;
        }
    }

    private void OnTagsReceived(
        object? sender,
        IEnumerable<string> tags)
    {
        if (BindingContext is not TagViewModel vm)
            return;

        MainThread.BeginInvokeOnMainThread(() =>
        {
            vm.Tags.Clear();

            foreach (var tag in tags)
            {
                vm.Tags.Add(new TagModel
                {
                    Name = tag
                });
            }
        });
    }
}
```

---

## How It Works

1. The user enters a feature or project description.
2. The application sends the description to Azure OpenAI.
3. Azure OpenAI analyzes the intent.
4. Relevant tags are selected from the predefined vocabulary.
5. The tags are returned to the application.
6. Syncfusion ChipGroup automatically displays the generated tags.

### Example

User request:

```text
Build a secure login system with biometric authentication and OTP verification.
```

AI-generated tags:

```text
Login
Authentication
Security
Biometric
OTP
MFA
Password
```

---

## Output

The following image demonstrates AI-powered tag generation inside the Syncfusion .NET MAUI ChipGroup control.

![.NET MAUI Tags generation With AI.](Images/AISearch/SmartAITag.gif)

---

## GitHub Sample

You can find the complete sample from this [link.](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master/AI-Solution-Samples)

---

## See Also

* https://help.syncfusion.com/maui/chip/getting-started
* https://help.syncfusion.com/maui/chipgroup/overview
* https://learn.microsoft.com/azure/ai-foundry/openai/overview