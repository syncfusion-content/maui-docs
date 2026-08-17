---
layout: post
title: AI-Powered File Search in .NET MAUI TreeView | Syncfusion®
description: Learn how to implement AI-powered natural language file search in Syncfusion® .NET MAUI TreeView using Azure OpenAI for intelligent file discovery across hierarchical folders.
platform: MAUI
control: SfTreeView
documentation: ug
---

# AI-Powered Natural Language File Search in .NET MAUI TreeView

This document demonstrates how to implement an intelligent file search feature in the Syncfusion [.NET MAUI TreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html) control using **Azure OpenAI**. This integration enables users to discover files through natural language queries without relying on exact keyword matching.

The TreeView used in this sample contains a collection of Wi-Fi/internet invoices, network-related documents, technical reports, project artifacts, reference materials, and miscellaneous files. The data is intentionally organized in a broad folder structure to demonstrate AI-powered natural language file search across different file locations.

## Prerequisites

Before you begin, ensure you have the following:

- A working .NET MAUI application with the `Syncfusion.Maui.TreeView` package installed. For step-by-step setup, refer to the [.NET MAUI TreeView Getting Started](https://help.syncfusion.com/maui/treeview/getting-started) documentation.
- An active Azure subscription with access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and a deployed model. If you don't have access, refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide to set up a new account. Note down the deployment name, endpoint URL, and API key.
- The [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package. Install it by running the following command in the Visual Studio Package Manager Console:

    ```powershell
    Install-Package Azure.AI.OpenAI
    ```

    Or using the .NET CLI:

    ```bash
    dotnet add package Azure.AI.OpenAI
    ```

## Integrating Azure OpenAI with your .NET MAUI App

First, ensure you have access to [Azure OpenAI](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/overview) and have created a deployment in the Azure portal. Refer to the [create and deploy Azure OpenAI service](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/how-to/create-resource?pivots=web-portal) guide.

Use the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package. Before getting started, install the Azure.AI.OpenAI NuGet package in your .NET MAUI app.

In your base service class (`AzureBaseService`), initialize the `AzureOpenAIClient`. Replace the `Endpoint`, `DeploymentName`, and `Key` with actual values from your Azure OpenAI resource.

This creates a chat client using your endpoint, API key, and deployment name. It is stored in the `Client` property for use in other methods.

`AzureAIService` uses this `Client` to send prompts and receive completions across the file search pipeline.

In the `GetCompletion` method, construct the prompt and send it to the Azure OpenAI Service. The completion is returned as text that is then parsed into matching file paths.

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
        /// Initializes the Azure OpenAI chat client using the configured endpoint,
        /// deployment name, and API key.
        /// </summary>
        private void GetAzureOpenAIKernel()
        {
            try
            {
                var client = new AzureOpenAIClient(new Uri(Endpoint), new AzureKeyCredential(Key))
                                            .GetChatClient(modelId: DeploymentName);
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
{% highlight %}

public class AzureAIService : AzureBaseService
{
    /// <summary>
    /// Gets a completion response from the Azure AI service based on the provided prompt.
    /// </summary>
    /// <param name="prompt">Prompt to send to the model.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Raw completion text returned by the model.</returns>
    public async Task<string> GetCompletion(string prompt, CancellationToken cancellationToken)
    {
        try
        {
            if (Client != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var chatResponse = await Client.CompleteChatAsync(prompt, cancellationToken: cancellationToken);
                return chatResponse.Value.Content[0].Text;
            }
        }
        catch (RequestFailedException ex)
        {
            Debug.WriteLine($"Request failed: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }

        return string.Empty;
    }
}

{% endhighlight %}
{% endtabs %}

## Implementing AI Natural Language File Search in .NET MAUI TreeView

### Step 1: Define the ViewModel and File Data Structure

Define a file node model that represents each entry in the hierarchy. The model exposes AI-search-friendly metadata such as `Keywords`, `FileType`, and a full `SearchPath` that together describe what the file is about. The TreeView in this sample is intentionally populated with Wi-Fi and internet invoices, network-related documents, technical reports, project artifacts, reference materials, and miscellaneous files spread across broad folder roots (Downloads, Documents, Shared Files, and Miscellaneous) so users can experience natural language search across different file locations.

{% tabs %}
{% highlight c# %}

public class SalesFileNode : FileManager
{
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string FileType { get; set; }            // Invoice, Report, Document, Contract, Summary
    public string[] Keywords { get; set; }          // Topic words used by the AI for matching
    public string[] ClientNames { get; set; }
    public string Quarter { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public bool IsMatched { get; set; }             // Marks the final matched file
    public bool IsHighlighted { get; set; }         // Visual highlight in the UI
    public bool IsExpanded { get; set; }            // TreeView expansion state
    public double MatchConfidenceScore { get; set; }
    public string SearchPath { get; set; }          // Full hierarchical path (e.g. /Downloads/Foo.pdf)
}

{% endhighlight %}
{% endtabs %}

The view model constructs the hierarchical file data, exposes the search state to the UI, and performs the AI-powered natural language search through the injected `IAzureOpenAISearchService`.

{% tabs %}
{% highlight c# %}

public class SalesFileViewModel : INotifyPropertyChanged
{
    public ObservableCollection<SalesFileNode> SalesFileNodes { get; set; }
    public int MatchCount { get; set; }
    public bool IsSearching { get; set; }
    public string MatchCountLabel { get; set; } = string.Empty;

    public IAzureOpenAISearchService SearchService { get; }

    public SalesFileViewModel(IAzureOpenAISearchService searchService)
    {
        SearchService = searchService;
        SalesFileNodes = BuildFileHierarchy();
    }

    /// <summary>
    /// Performs an AI-powered natural language search, highlights matches, and
    /// auto-expands the parent folders of the matched files.
    /// </summary>
    public async Task<SearchResult> PerformNaturalLanguageSearchAsync(string query, CancellationToken cancellationToken = default)
    {
        IsSearching = true;
        try
        {
            // Reset previous highlights and clear the tree before a new search.
            ResetAllHighlights();

            if (string.IsNullOrWhiteSpace(query))
            {
                MatchCount = 0;
                MatchCountLabel = string.Empty;
                return new SearchResult();
            }

            var fileRepository = BuildFileMetadataList();
            var matchedPaths = await SearchService.GetMatchingFilesAsync(query, fileRepository, cancellationToken);

            ApplyHighlights(matchedPaths);

            MatchCount = matchedPaths.Count;
            MatchCountLabel = MatchCount > 0
                ? $"Found {MatchCount} match{(MatchCount != 1 ? "es" : "")}."
                : "No matches found.";

            return new SearchResult { TotalMatches = MatchCount, MatchedPaths = matchedPaths };
        }
        finally
        {
            IsSearching = false;
        }
    }

    /// <summary>
    /// Builds a broad TreeView hierarchy that contains Wi-Fi/internet invoices,
    /// network-related documents, technical reports, project artifacts,
    /// reference materials, and miscellaneous files.
    /// </summary>
    private ObservableCollection<SalesFileNode> BuildFileHierarchy()
    {
        var root = new ObservableCollection<SalesFileNode>();

        // /Downloads — Wi-Fi, internet, broadband, and connectivity invoices.
        root.Add(NewFolder("Downloads"));
        // (Example files: Wi-Fi monthly statements, internet bills, wireless
        //  service invoices, broadband summaries, connection renewal records.)
        // Add files inside /Downloads that include invoice amounts, keywords
        // such as "wifi", "wireless", "network", "internet", and "connectivity",
        // and CreatedDate values across several months.

        // /Documents — Generic project artifacts and network-related documents.
        root.Add(NewFolder("Documents"));
        // (Example files: project status reports, network design documents,
        //  user guides, budget plans, requirement documents, policy documents.)

        // /Shared Files — Team-shared network and infrastructure documents.
        root.Add(NewFolder("Shared Files"));
        // (Example files: coverage test reports, infrastructure notes, network
        //  upgrade plans, firewall settings, wireless survey reports.)

        // /Miscellaneous — Reference materials, drafts, and uncategorized files.
        root.Add(NewFolder("Miscellaneous"));
        // (Example files: random notes, old reports, draft documents, test data,
        //  equipment details, reference documents, general notes.)

        return root;
    }

    private static SalesFileNode NewFolder(string name) => new SalesFileNode
    {
        ItemName = name,
        ImageIcon = "treeview_folder.png",
        SearchPath = "/" + name,
        FileType = "Folder",
        Keywords = Array.Empty<string>()
    };

    public event PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

{% endhighlight %}
{% endtabs %}

### Step 2: Connect the AI File Search to Azure OpenAI

Create a custom search service that builds a metadata snapshot of every file and forwards the user's natural language query to Azure OpenAI. The service also provides a deterministic fallback that performs a local natural language match when Azure credentials are unavailable so the search still works offline.

{% tabs %}
{% highlight c# %}

public class AzureOpenAISearchService : IAzureOpenAISearchService
{
    private const string SystemPrompt =
        @"You are an AI search assistant for a file explorer TreeView.
          Analyze the user's natural language query and return the file paths
          that best match from the provided repository. Return FILE PATHS ONLY,
          one per line. Repository structure:
            /Downloads         -> Wi-Fi and internet bills, statements, invoices, summaries.
            /Documents         -> Project artifacts, network designs, user guides.
            /Shared Files      -> Coverage reports, infrastructure notes, upgrade plans.
            /Miscellaneous     -> Drafts, reference documents, old reports.";

    private readonly ChatClient _chatClient;
    private readonly bool _isCredentialValid;

    public bool IsCredentialValid => _isCredentialValid;

    public AzureOpenAISearchService(AzureBaseService azureBaseService)
    {
        if (azureBaseService == null)
        {
            _isCredentialValid = false;
            return;
        }

        _chatClient = azureBaseService.Client;
        _isCredentialValid = _chatClient != null;
    }

    /// <summary>
    /// Sends the natural language query and file metadata to Azure OpenAI and
    /// parses the response into a list of file paths that should be highlighted
    /// in the TreeView. Falls back to a local matching strategy on failure.
    /// </summary>
    public async Task<List<string>> GetMatchingFilesAsync(
        string query,
        List<FileMetadataContext> fileRepository,
        CancellationToken cancellationToken = default)
    {
        if (!_isCredentialValid || _chatClient == null)
            return LocalNaturalLanguageMatch(query, fileRepository);

        try
        {
            var fileList = string.Join("\n", fileRepository.Select(f => f.FullPath));
            var prompt = $"Current Date: {DateTime.Now:yyyy-MM-dd}\nQuery: \"{query}\"\nFiles:\n{fileList}";

            var completion = await _chatClient.CompleteChatAsync(
                new SystemChatMessage(SystemPrompt),
                new UserChatMessage(prompt),
                cancellationToken: cancellationToken);

            var responseText = completion.Value.Content[0].Text;
            return ParseMatchedPaths(responseText, fileRepository);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"AI search error: {ex.Message}");
            return LocalNaturalLanguageMatch(query, fileRepository);
        }
    }

    /// <summary>
    /// Offline fallback that scores each file by topic, keyword, and temporal
    /// relevance using simple token matching against the file metadata.
    /// </summary>
    private List<string> LocalNaturalLanguageMatch(string query, List<FileMetadataContext> files)
    {
        var queryTokens = query.ToLowerInvariant()
            .Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

        return files
            .Where(file => file.Keywords.Any(k => queryTokens.Any(t => k.Contains(t))))
            .Select(f => f.FullPath)
            .Take(50)
            .ToList();
    }
}

{% endhighlight %}
{% endtabs %}

### Step 3: Apply AI File Search to the TreeView

Wire the search entry to the view model, hand off each natural language query to Azure OpenAI, and update the TreeView by highlighting matched files and auto-expanding the folders that contain them.

{% tabs %}
{% highlight xaml %}

<Grid RowDefinitions="Auto,*" Padding="10">
    <Entry x:Name="searchEntry"
           Placeholder="Search files with natural language..."
           TextChanged="OnSearchEntryTextChanged"/>

    <StackLayout Grid.Row="1" Spacing="10">
        <ActivityIndicator IsVisible="{Binding IsSearching}" IsRunning="{Binding IsSearching}"/>
        <Label Text="{Binding MatchCountLabel}" FontAttributes="Bold"/>

        <syncfusion:SfTreeView x:Name="treeView"
                               ChildPropertyName="SubFiles"
                               ItemsSource="{Binding SalesFileNodes}"
                               AutoExpandMode="None">
            <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                    <Grid ColumnDefinitions="40,*,20">
                        <Image Grid.Column="0" Source="{Binding Content.ImageIcon}" WidthRequest="30"/>
                        <Label Grid.Column="1"
                               Text="{Binding Content.ItemName}"
                               FontAttributes="{Binding Content.IsHighlighted, Converter={StaticResource BoolToFontAttributesConverter}}"
                               TextColor="{Binding Content.IsHighlighted, Converter={StaticResource BoolToTextColorConverter}}"/>
                        <Label Grid.Column="2"
                               Text="✓"
                               IsVisible="{Binding Content.IsHighlighted}"
                               TextColor="#10b981"/>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
        </syncfusion:SfTreeView>
    </StackLayout>
</Grid>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

public partial class MainPage : ContentPage
{
    private readonly SalesFileViewModel _viewModel;

    public MainPage()
    {
        InitializeComponent();
        _viewModel = ServiceHelper.GetService<SalesFileViewModel>();
        BindingContext = _viewModel;
    }

    /// <summary>
    /// Debounces user input and triggers the AI natural language search.
    /// </summary>
    private async void OnSearchEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        var query = e.NewTextValue?.Trim() ?? string.Empty;
        await Task.Delay(350); // Debounce

        await _viewModel.PerformNaturalLanguageSearchAsync(query, default);
    }
}

{% endhighlight %}
{% endtabs %}

Finally, register the base service, search service, view model, and main page in `MauiProgram`:

{% tabs %}
{% highlight c# %}

// MauiProgram.cs
builder.Services.AddSingleton<AzureBaseService>();
builder.Services.AddSingleton<IAzureOpenAISearchService, AzureOpenAISearchService>();
builder.Services.AddSingleton<SalesFileViewModel>();
builder.Services.AddSingleton<MainPage>();

{% endhighlight %}
{% endtabs %}

## Output

The following image illustrates the AI-powered natural language file search in the .NET MAUI TreeView.

![AI-Powered Natural Language File Search in .NET MAUI TreeView](Images/ai-search-treeview.gif)

You can find the complete sample from this [GitHub link](https://github.com/SyncfusionExamples/ai-powered-natural-language-file-search-net-maui-treeview).
