---
layout: post
title: AI-Powered File Search in .NET MAUI TreeView | Syncfusion®
description: Learn how to search file metadata with natural-language queries using Azure OpenAI and the .NET MAUI TreeView control.
platform: MAUI
control: SfTreeView
documentation: ug
---

# AI-Powered Natural Language File Search in .NET MAUI TreeView

This sample uses Azure OpenAI to match a natural-language query with files in a hierarchical data source and display the matching files in the Syncfusion [.NET MAUI TreeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html). The search considers each file's name, path, type, keywords, and dates rather than requiring an exact filename match.

## Prerequisites

- A .NET MAUI app with the Syncfusion [.NET MAUI TreeView](https://help.syncfusion.com/maui/treeview/overview) control.
- An Azure OpenAI resource with a deployed chat model.
- The [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package.

Configure your Azure OpenAI endpoint, deployment name, and API key as environment variables for the app.

## Integrating Azure OpenAI with the .NET MAUI App

The sample's `SemanticSearchService` creates an `AzureOpenAIClient` and uses the configured deployment to search the file metadata. Add the NuGet package to an app that does not already include it:

{% tabs %}
{% highlight bash %}

dotnet add package Azure.AI.OpenAI

{% endhighlight %}
{% endtabs %}

The service sends the user's query and a metadata listing to the chat deployment. Its system instruction asks the model to identify relevant files and return their exact paths, one path per line.

## Implementing AI-Powered Natural Language File Search

### Step 1: Display the Hierarchical File Data

Bind `SfTreeView` to the file-node collection and set `ChildPropertyName` to the property that contains each folder's children. In this sample, the full tree is stored in `SalesFileNodes`.

{% tabs %}
{% highlight xaml %}

<treeview:SfTreeView ItemsSource="{Binding SalesFileNodes}"
                     ChildPropertyName="SubFiles"
                     ItemTemplateContextType="Node"
                     AutoExpandMode="None"
                     ExpandActionTarget="Expander" />

{% endhighlight %}
{% endtabs %}

Each file node includes a stable search path and metadata. The view model walks the hierarchy and creates a search record for every non-folder node. Folder paths are included as context, but folders are not sent as eligible file results.

### Step 2: Build the Search Request

When a query is entered, the service combines it with the current file records. Each record sent to Azure OpenAI includes the file path, name, type, created date, modified date, and keywords when available.

The system instruction compares the complete query with the supplied metadata, accounts for semantic relationships and synonyms, and uses recency as a ranking factor when the query asks for recent or current files. It returns relevant leaf-file paths in relevance order without explanations or folder-only results.

The service formats one record per file and includes the complete query in the user message:

{% tabs %}
{% highlight c# %}

private static string BuildUserPrompt(string query, IEnumerable<FileMetadataContext> fileMetadata)
{
    var fileList = new StringBuilder();
    foreach (var file in fileMetadata)
    {
        var recordType = string.IsNullOrWhiteSpace(file.FileType) ? "File" : file.FileType;
        fileList.Append("- Path: ").Append(file.FullPath);
        fileList.Append(" | Name: ").Append(file.FileName);
        fileList.Append(" | Type: ").Append(recordType);
        fileList.Append(" | Created: ").Append(file.CreatedDate.ToString("yyyy-MM-dd"));
        fileList.Append(" | Modified: ").Append(file.ModifiedDate.ToString("yyyy-MM-dd"));

        if (file.Keywords?.Length > 0)
        {
            fileList.Append(" | Keywords: ").Append(string.Join(", ", file.Keywords));
        }

        fileList.AppendLine();
    }

    return $"""
        User query:
        {query.Trim()}

        Files in the current TreeView:
        {fileList}
        """;
}

{% endhighlight %}
{% endtabs %}

### Step 3: Debounce the Query and Handle New Searches

The page waits 350 milliseconds after the latest text change before starting a search. A new query cancels the previous request. A request-version check also ensures that a response from an older search cannot replace the latest results.

The view model passes the cancellation token and current file metadata to `SearchFilesSemanticAsync`. Empty input clears the search instead of sending a query to Azure OpenAI.

### Step 4: Validate the Returned Paths

Treat model output as candidate paths, not as trusted data. The service parses path-like lines, normalizes separators and casing, and retains only paths that match records in the current file metadata. It then returns the canonical paths from the app's data:

{% tabs %}
{% highlight c# %}

var canonicalPaths = fileMetadata
    .Where(file => !string.IsNullOrWhiteSpace(file.FullPath))
    .ToDictionary(
        file => NormalizePath(file.FullPath),
        file => file.FullPath,
        StringComparer.OrdinalIgnoreCase);

return returnedPaths
    .Where(path => canonicalPaths.ContainsKey(NormalizePath(path)))
    .Select(path => canonicalPaths[NormalizePath(path)])
    .Distinct(StringComparer.OrdinalIgnoreCase)
    .ToList();

{% endhighlight %}
{% endtabs %}

This validation prevents invented paths or folder paths from being used to create search results.

### Step 5: Display Matches and Clear the Search

The view model uses the validated paths to identify matching files and their ancestor folders. The page displays a filtered tree containing those files and folders, expands the matching branches, and highlights the results. A badge shows the number of matching files.

When the query is cleared, the app resets the match count and highlights, then restores the complete `SalesFileNodes` collection to the TreeView.

## Output

The following image shows natural-language file search in the .NET MAUI TreeView.

![AI-powered natural language file search in .NET MAUI TreeView](Images/ai-search-treeview.gif)

You can find the complete sample in the [AI use-case demos repository](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master/AI%20Solutions/TreeView/AIFileSearchTreeView).
