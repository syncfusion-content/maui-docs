---
layout: post
title: AI-Powered File Search in .NET MAUI TreeView | Syncfusion
description: Learn how to implement AI-powered natural language file search in Syncfusion .NET MAUI TreeView using Azure OpenAI for intelligent file discovery.
platform: MAUI
control: SfTreeView
documentation: ug
---

# AI-Powered Natural Language File Search in .NET MAUI TreeView

This document demonstrates how to implement an intelligent file search feature in the Syncfusion [.NET MAUI TreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html) control using **Azure OpenAI**. This integration enables users to discover files and folders through natural language queries with semantic understanding, eliminating the need for exact keyword matching.

N> **Prerequisite:** Ensure that the required NuGet packages are installed, the necessary namespaces are imported, and the **.NET MAUI TreeView** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[.NET MAUI TreeView Getting Started](https://help.syncfusion.com/maui/treeview/getting-started)** guide.

## Integrating Azure OpenAI with .NET MAUI TreeView

### Step 1: Create the Semantic Search Service

Create a service class to handle communication with Azure OpenAI. This service analyzes natural language queries and identifies matching files in your hierarchical structure.

{% tabs %}

{% highlight c# %}

public class SemanticSearchService : ISemanticSearchService
{
    private const string SystemPrompt = @"
You are an AI search assistant for a file explorer TreeView.
Analyze a user's natural language request and identify matching FILE NODES.
Return FILE PATHS ONLY (leaf nodes), one per line.";

    private AzureOpenAIClient? _client;
    private bool _isCredentialValid = false;

    public bool IsCredentialValid => _isCredentialValid;

    public SemanticSearchService()
    {
        InitializeCredentials();
    }

    private void InitializeCredentials()
    {
        var endpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
        var deploymentName = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENT_NAME");
        var apiKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY");

        if (string.IsNullOrWhiteSpace(endpoint) || string.IsNullOrWhiteSpace(apiKey))
        {
            _isCredentialValid = false;
            return;
        }

        try
        {
            var credential = new ApiKeyCredential(apiKey);
            _client = new AzureOpenAIClient(new Uri(endpoint), credential);
            _isCredentialValid = true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"❌ Failed to initialize Azure OpenAI: {ex.Message}");
            _isCredentialValid = false;
        }
    }

    public async Task<List<string>> GetMatchingFilesAsync(
        string query,
        List<string> fileRepository,
        CancellationToken cancellationToken = default)
    {
        if (!_isCredentialValid || _client == null)
            return LocalSemanticMatcher(query, fileRepository);

        try
        {
            var prompt = $"Current Date: {DateTime.Now:yyyy-MM-dd}\nQuery: \"{query}\"\nFiles: {string.Join(",", fileRepository.Take(100))}";
            var messages = new List<ChatMessage>
            {
                new SystemChatMessage(SystemPrompt),
                new UserChatMessage(prompt)
            };

            var response = await _client.GetChatCompletionAsync(messages, cancellationToken: cancellationToken);
            var content = response.Value.Content[0].Text;
            
            return ParseAIResponse(content, fileRepository);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"❌ AI search error: {ex.Message}");
            return LocalSemanticMatcher(query, fileRepository);
        }
    }

    private List<string> ParseAIResponse(string content, List<string> fileRepository)
    {
        var matches = new List<string>();
        foreach (var line in content.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
        {
            var match = fileRepository.FirstOrDefault(f => 
                f.Equals(line.Trim(), StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(match))
                matches.Add(match);
        }
        return matches;
    }

    private List<string> LocalSemanticMatcher(string query, List<string> fileRepository)
    {
        var queryTokens = query.ToLowerInvariant().Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
        return fileRepository.Where(file =>
        {
            var fileTokens = file.ToLowerInvariant().Split(new[] { '/', '\\', '-', '_', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var matchCount = queryTokens.Count(qt => fileTokens.Any(ft => ft.Contains(qt)));
            return matchCount >= Math.Ceiling(queryTokens.Length * 0.5);
        }).ToList();
    }
}

{% endhighlight %}

{% endtabs %}

## Implementing AI-Powered File Search

### Step 1: Create the File Node Model

Create a data model to represent files in your hierarchical structure with AI search metadata:

{% tabs %}

{% highlight c# %}

public record SalesFileNode : FileManager
{
    private bool isMatched;
    private bool isHighlighted;
    private bool isExpanded;
    private string[]? keywords;
    private string? fileType;

    public bool IsMatched
    {
        get => isMatched;
        set { isMatched = value; RaisedOnPropertyChanged(nameof(IsMatched)); }
    }

    public bool IsHighlighted
    {
        get => isHighlighted;
        set { isHighlighted = value; RaisedOnPropertyChanged(nameof(IsHighlighted)); }
    }

    public bool IsExpanded
    {
        get => isExpanded;
        set { isExpanded = value; RaisedOnPropertyChanged(nameof(IsExpanded)); }
    }

    public string[]? Keywords
    {
        get => keywords;
        set { keywords = value; RaisedOnPropertyChanged(nameof(Keywords)); }
    }

    public string? FileType
    {
        get => fileType;
        set { fileType = value; RaisedOnPropertyChanged(nameof(FileType)); }
    }
}

{% endhighlight %}

{% endtabs %}

### Step 2: Create the ViewModel with Search Logic

Build a ViewModel that manages the TreeView data and performs AI-powered semantic searches:

{% tabs %}

{% highlight c# %}

public class SalesFileViewModel : INotifyPropertyChanged
{
    private ObservableCollection<SalesFileNode> salesFileNodes = new();
    private int matchCount;
    private bool isSearching;
    private string matchCountLabel = string.Empty;
    private readonly ISemanticSearchService _semanticSearchService;
    private readonly Stopwatch _searchStopwatch = new Stopwatch();

    public ObservableCollection<SalesFileNode> SalesFileNodes { get; set; }
    public int MatchCount { get; set; }
    public bool IsSearching { get; set; }
    public string MatchCountLabel { get; set; }

    public SalesFileViewModel(ISemanticSearchService semanticSearchService)
    {
        _semanticSearchService = semanticSearchService;
        SalesFileNodes = GenerateSalesFileStructure();
    }

    public async Task<SearchResult> PerformSemanticSearch(string query, CancellationToken cancellationToken)
    {
        _searchStopwatch.Restart();
        IsSearching = true;

        try
        {
            ResetAllHighlights();

            if (string.IsNullOrWhiteSpace(query))
            {
                IsSearching = false;
                MatchCountLabel = string.Empty;
                MatchCount = 0;
                return new SearchResult { TotalMatches = 0 };
            }

            var fileRepository = ExtractFilePaths(SalesFileNodes);
            var matchedPaths = await _semanticSearchService.GetMatchingFilesAsync(
                query, fileRepository, cancellationToken);

            int highlightedCount = HighlightMatchedFiles(matchedPaths);

            _searchStopwatch.Stop();
            MatchCount = highlightedCount;
            MatchCountLabel = highlightedCount > 0 
                ? $"Found {highlightedCount} match{(highlightedCount != 1 ? "es" : "")} in {_searchStopwatch.ElapsedMilliseconds}ms"
                : "No matches found";

            return new SearchResult 
            { 
                Query = query,
                TotalMatches = highlightedCount,
                MatchedPaths = matchedPaths,
                ExecutionTimeMs = _searchStopwatch.ElapsedMilliseconds
            };
        }
        finally
        {
            IsSearching = false;
        }
    }

    private List<string> ExtractFilePaths(ObservableCollection<SalesFileNode> nodes, string parentPath = "")
    {
        var paths = new List<string>();
        foreach (var node in nodes)
        {
            var currentPath = string.IsNullOrEmpty(parentPath) ? $"/{node.ItemName}" : $"{parentPath}/{node.ItemName}";
            
            if (node.SubFiles?.Count == 0)
                paths.Add(currentPath);
            else
                paths.AddRange(ExtractFilePaths(
                    new ObservableCollection<SalesFileNode>(node.SubFiles?.Cast<SalesFileNode>() ?? Enumerable.Empty<SalesFileNode>()),
                    currentPath));
        }
        return paths;
    }

    private int HighlightMatchedFiles(List<string> matchedPaths)
    {
        int count = 0;
        foreach (var path in matchedPaths)
            if (HighlightNodeByPath(SalesFileNodes, path))
                count++;
        return count;
    }

    private bool HighlightNodeByPath(ObservableCollection<SalesFileNode> nodes, string path)
    {
        var segments = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        if (segments.Length == 0) return false;

        foreach (var node in nodes)
        {
            if (node.ItemName.Equals(segments[0], StringComparison.OrdinalIgnoreCase))
            {
                if (segments.Length == 1)
                {
                    node.IsHighlighted = true;
                    node.IsMatched = true;
                    return true;
                }
                else if (node.SubFiles?.Count > 0)
                {
                    var found = HighlightNodeByPath(
                        new ObservableCollection<SalesFileNode>(node.SubFiles.Cast<SalesFileNode>()),
                        string.Join("/", segments.Skip(1)));
                    if (found) node.IsMatched = true;
                    return found;
                }
            }
        }
        return false;
    }

    private void ResetAllHighlights()
    {
        foreach (var node in SalesFileNodes)
            ResetHighlightsRecursive(new[] { node });
    }

    private void ResetHighlightsRecursive(IEnumerable<SalesFileNode> nodes)
    {
        foreach (var node in nodes)
        {
            node.IsHighlighted = false;
            node.IsMatched = false;
            if (node.SubFiles?.Count > 0)
                ResetHighlightsRecursive(node.SubFiles.Cast<SalesFileNode>());
        }
    }

    private ObservableCollection<SalesFileNode> GenerateSalesFileStructure()
    {
        var documentsNode = new SalesFileNode
        {
            ItemName = "Documents",
            ImageIcon = "treeview_folder.png",
            FileType = "Folder"
        };

        var invoicesFolder = new SalesFileNode { ItemName = "Invoices", FileType = "Folder" };
        var invoiceFiles = new ObservableCollection<SalesFileNode>();

        for (int i = 1; i <= 13; i++)
        {
            var date = new DateTime(2025 + (i > 6 ? 1 : 0), ((i - 1) % 12) + 1, 1);
            invoiceFiles.Add(new SalesFileNode
            {
                ItemName = $"Invoice_{date:MMMyyyy}_AUTO_{i:D3}.pdf",
                ImageIcon = "treeview_pdf.png",
                FileType = "Invoice",
                Keywords = new[] { "invoice", "automobile", date.ToString("MMM").ToLower(), date.Year.ToString() }
            });
        }

        invoicesFolder.SubFiles = new ObservableCollection<FileManager>(invoiceFiles.Cast<FileManager>());
        documentsNode.SubFiles.Add(invoicesFolder);

        return new ObservableCollection<SalesFileNode> { documentsNode };
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void RaisedOnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

public class SearchResult
{
    public string Query { get; set; } = string.Empty;
    public int TotalMatches { get; set; }
    public List<string> MatchedPaths { get; set; } = new();
    public long ExecutionTimeMs { get; set; }
}

{% endhighlight %}

{% endtabs %}

### Step 3: Design the TreeView UI

{% tabs %}

{% highlight xaml %}

<Grid RowDefinitions="Auto,*" Padding="10">
    <Grid Grid.Row="0" ColumnDefinitions="*,Auto">
        <Entry x:Name="searchEntry" Placeholder="Search files..."/>
        <Button Grid.Column="1" Text="✕" Clicked="OnClearSearch"/>
        <ActivityIndicator Grid.Row="1" IsVisible="{Binding IsSearching}" IsRunning="{Binding IsSearching}"/>
    </Grid>

    <StackLayout Grid.Row="1" Spacing="10">
        <Label Text="{Binding MatchCountLabel}" FontAttributes="Bold"/>
        <syncfusion:SfTreeView x:Name="treeView" ChildPropertyName="SubFiles" 
                               ItemsSource="{Binding SalesFileNodes}" AutoExpandMode="None">
            <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                    <Grid ColumnDefinitions="40,*,20">
                        <Image Grid.Column="0" Source="{Binding Content.ImageIcon}" WidthRequest="30"/>
                        <Label Grid.Column="1" Text="{Binding Content.ItemName}" 
                               FontAttributes="{Binding Content.IsHighlighted, Converter={StaticResource BoolToFontAttributesConverter}}"
                               TextColor="{Binding Content.IsHighlighted, Converter={StaticResource BoolToTextColorConverter}}"/>
                        <Label Grid.Column="2" Text="✓" IsVisible="{Binding Content.IsHighlighted}" TextColor="#10b981"/>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
        </syncfusion:SfTreeView>
    </StackLayout>
</Grid>

{% endhighlight %}

{% endtabs %}

### Step 4: Implement the Code-Behind

Handle search events and TreeView interactions in the code-behind:

{% tabs %}

{% highlight c# %}

public partial class MainPage : ContentPage
{
    private SalesFileViewModel? _viewModel;
    private CancellationTokenSource? _searchCancellationTokenSource;
    private int _searchRequestVersion;

    public MainPage()
    {
        InitializeComponent();
        _viewModel = ServiceHelper.Services.GetRequiredService<SalesFileViewModel>();
        this.BindingContext = _viewModel;
        searchEntry.TextChanged += OnSearchEntryTextChanged;
    }

    private async void OnSearchEntryTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (_viewModel == null) return;

        string searchText = e.NewTextValue?.Trim() ?? "";
        _searchRequestVersion++;
        var requestVersion = _searchRequestVersion;

        _searchCancellationTokenSource?.Cancel();
        _searchCancellationTokenSource = new CancellationTokenSource();
        var token = _searchCancellationTokenSource.Token;

        if (string.IsNullOrWhiteSpace(searchText))
        {
            _viewModel.IsSearching = false;
            CollapseAllNodes();
            return;
        }

        try
        {
            _viewModel.IsSearching = true;
            await Task.Delay(350, token); // Debounce

            var result = await _viewModel.PerformSemanticSearch(searchText, token);
            if (requestVersion == _searchRequestVersion)
                ExpandAllMatchedNodes(result);
        }
        catch (OperationCanceledException) { }
        finally
        {
            _viewModel.IsSearching = false;
        }
    }

    private void ExpandAllMatchedNodes(SearchResult result)
    {
        foreach (var path in result.MatchedPaths)
            ExpandPathInTree(path);
    }

    private void ExpandPathInTree(string path)
    {
        var segments = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        ExpandNodeRecursive(_viewModel?.SalesFileNodes!, segments, 0);
    }

    private void ExpandNodeRecursive(ObservableCollection<SalesFileNode> nodes, string[] segments, int depth)
    {
        if (depth >= segments.Length) return;
        var node = nodes.FirstOrDefault(n => n.ItemName.Equals(segments[depth], StringComparison.OrdinalIgnoreCase));
        if (node != null)
        {
            node.IsExpanded = true;
            if (depth < segments.Length - 1 && node.SubFiles?.Count > 0)
                ExpandNodeRecursive(new ObservableCollection<SalesFileNode>(node.SubFiles.Cast<SalesFileNode>()), segments, depth + 1);
        }
    }

    private void CollapseAllNodes()
    {
        foreach (var node in _viewModel?.SalesFileNodes ?? Enumerable.Empty<SalesFileNode>())
            CollapseNodesRecursive(new[] { node });
    }

    private void CollapseNodesRecursive(IEnumerable<SalesFileNode> nodes)
    {
        foreach (var node in nodes)
        {
            node.IsExpanded = false;
            if (node.SubFiles?.Count > 0)
                CollapseNodesRecursive(node.SubFiles.Cast<SalesFileNode>());
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Step 5: Register Services in MauiProgram

{% tabs %}

{% highlight c# %}

builder.Services.AddSingleton<ISemanticSearchService, SemanticSearchService>();
builder.Services.AddSingleton<SalesFileViewModel>();
builder.Services.AddSingleton<MainPage>();

var app = builder.Build();
ServiceHelper.InitializeServices(app.Services);

{% endhighlight %}

{% endtabs %}

## Key Features

- **Natural Language Search**: Colloquial queries like "last month invoices" 
- **Semantic Matching**: Azure OpenAI finds relevant files beyond exact keyword matching
- **Hierarchical Highlighting**: Matched files highlighted with automatic parent expansion
- **Fallback Support**: Local fuzzy matching if Azure OpenAI unavailable
- **Search Debounce**: Optimized API calls during typing
- **Cancellation Support**: Users can cancel ongoing searches

## Example Queries

- "Show me invoices from last month"
- "Q1 sales reports for 2026"
- "January 2026 billing documents"

The Syncfusion TreeView with Azure OpenAI provides intelligent file discovery beyond traditional browsing.

![AI-Powered Natural Language File Search in .NET MAUI TreeView](Images/ai-search-treeview.gif)

For the complete sample, visit this [GitHub link](https://github.com/SyncfusionExamples/ai-powered-natural-language-file-search-net-maui-treeview).
