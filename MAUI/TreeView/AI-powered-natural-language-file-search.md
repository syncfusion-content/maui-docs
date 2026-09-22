---
layout: post
title: AI-Powered File Search in .NET MAUI TreeView | Syncfusion®
description: Learn to implement AI-powered natural language file search in Syncfusion® .NET MAUI TreeView using Azure OpenAI for file discovery.
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

Use the [Azure.AI.OpenAI](https://www.nuget.org/packages/Azure.AI.OpenAI) NuGet package. Keep the endpoint, deployment name, and API key in environment variables or secure application configuration; do not place secrets in source code.

Initialize the Azure client and send the natural-language search prompt through the deployment's chat client:

```csharp
var endpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
var deploymentName = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENT_NAME");
var apiKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY");

var azureClient = new AzureOpenAIClient(
    new Uri(endpoint!),
    new ApiKeyCredential(apiKey!));

var chatClient = azureClient.GetChatClient(deploymentName);
var messages = new List<ChatMessage>
{
    new SystemChatMessage(systemPrompt),
    new UserChatMessage(userPrompt)
};

var response = await chatClient.CompleteChatAsync(
    messages,
    cancellationToken: cancellationToken);

var responseText = string.Join(
    Environment.NewLine,
    response.Value.Content
        .Select(content => content.Text)
        .Where(text => !string.IsNullOrWhiteSpace(text)));
```

The `userPrompt` contains the user's natural-language query and the current TreeView file metadata. The returned text is parsed as candidate paths and validated against the metadata before any file is displayed.

## Implementing AI Natural Language File Search in .NET MAUI TreeView

### Step 1: Define the TreeView Data and Search Metadata

Create the hierarchical TreeView data first. Each folder contains its child files, and each file has a stable full path that identifies its position in the hierarchy. The file metadata used for search should include the display name, full path, keywords, file type, and any other descriptive values that help explain the file's meaning. Dates and business fields can also be included when they are part of the search requirements.

The folder hierarchy remains the source of truth. The search layer should not create files or folders; it should only identify files that already exist in this data. Folder paths provide context, while only leaf-file records are eligible search results.

The view model owns the current TreeView data and exposes search state such as loading status, match count, and the current filtered result. It projects the current file nodes into search metadata before each request so the prompt always reflects the data currently displayed by the TreeView.

The metadata projection should include leaf files while retaining the full path so the AI can understand the folder context:

```csharp
var fileMetadata = treeNodes
    .Where(node => node.FileType != "Folder")
    .Select(node => new FileMetadataContext
    {
        FullPath = node.SearchPath,
        FileName = node.ItemName,
        FileType = node.FileType,
        Keywords = node.Keywords,
        CreatedDate = node.CreatedDate,
        ModifiedDate = node.ModifiedDate
    })
    .ToList();
```

### Step 2: Build One Natural-Language Search Prompt

The search service sends two pieces of information to Azure OpenAI:

- The complete query entered by the user.
- A dynamically generated snapshot of the current TreeView file records.

Each record should provide the exact file path, file name, folder context, keywords, file type, and relevant metadata. The prompt should ask the model to compare the complete meaning of the query with all supplied records. It should allow reasonable natural-language relationships and synonyms, while avoiding matches based only on one broad or unrelated word.

The prompt should define a strict output contract: return only exact leaf-file paths that appear in the supplied records, one per line. The model must not return explanations, folder paths, markdown, or invented paths. This keeps semantic interpretation in the AI prompt while keeping the application responsible for data integrity.

The prompt should remain generic. It should describe how to evaluate natural-language intent rather than hardcoding one topic, one folder, or one example query. This allows the same flow to handle searches for connectivity, reports, invoices, designs, policies, project material, or other concepts represented in the current metadata.

The user prompt is built from the live query and the current metadata snapshot:

```csharp
var prompt = $"""
    User query:
    {query}

    Files in the current TreeView:
    {string.Join("\n", fileMetadata.Select(file =>
        $"Path: {file.FullPath} | Name: {file.FileName} | " +
        $"Type: {file.FileType} | Keywords: {string.Join(", ", file.Keywords)}"))}
    """;
```

### Step 3: Process and Validate the AI Result

When the user enters text, the page debounces rapid changes and passes the latest query to the view model. The view model creates a fresh metadata snapshot and sends it to the search service with the cancellation token for that request. If a newer query arrives, the previous request is cancelled so an older response cannot replace the latest result.

After Azure OpenAI responds, the service parses the response as candidate paths and validates every candidate against the current metadata snapshot. Invalid paths, hallucinated paths, folder paths, explanations, and duplicates are discarded. The service returns canonical paths from the TreeView data rather than trusting arbitrary text or casing returned by the model.

This validation step is required even when the prompt instructs the model to use supplied paths. The model decides which files are semantically relevant, but the application decides which records are allowed to reach the TreeView.

The validation boundary keeps only paths that exist in the current metadata and returns the canonical path stored by the application:

```csharp
var validPaths = aiPaths
    .Select(path => fileMetadata.FirstOrDefault(file =>
        string.Equals(file.FullPath, path, StringComparison.OrdinalIgnoreCase)))
    .Where(file => file != null)
    .Select(file => file!.FullPath)
    .Distinct(StringComparer.OrdinalIgnoreCase)
    .ToList();
```

### Step 4: Filter the TreeView and Expand Matching Folders

The view model converts the validated file paths into search results and builds a filtered tree from the original hierarchy. The filtered tree contains only matched leaf files and the ancestor folders required to reach them. Folders containing matches are marked expanded, while unrelated files and empty branches are omitted from the search view.

The complete source hierarchy remains available as the canonical data set. Clearing the query removes the filtered result, resets match state, and restores the full folder/file tree. This keeps the search operation presentation-focused without changing or losing the underlying TreeView data.

The filtered view is created by retaining a matched file or recursively retaining a folder when one of its descendants matches:

```csharp
SalesFileNode? BuildFilteredNode(SalesFileNode node, HashSet<string> matchedPaths)
{
    if (matchedPaths.Contains(node.SearchPath))
        return CloneNode(node);

    var children = node.SubFiles
        .OfType<SalesFileNode>()
        .Select(child => BuildFilteredNode(child, matchedPaths))
        .Where(child => child != null)
        .Cast<SalesFileNode>()
        .ToList();

    if (children.Count == 0)
        return null;

    var folder = CloneNode(node);
    folder.SubFiles = new ObservableCollection<FileManager>(children);
    folder.IsExpanded = true;
    return folder;
}
```

### Step 5: Handle Search State and Empty Results

The view model exposes the searching state so the application can show progress while Azure OpenAI is processing the request. It also reports the number of validated matches and an empty-result state when no supplied file satisfies the natural-language intent. Empty queries reset the search instead of sending unnecessary AI requests.

The overall flow is therefore:

1. Maintain the complete folder/file hierarchy.
2. Project the current leaf files into searchable metadata.
3. Combine the user's natural-language query and metadata in one AI prompt.
4. Receive candidate file paths from the model.
5. Validate candidates against the current TreeView data.
6. Build a filtered tree containing only valid matches and ancestor folders.
7. Expand matching folders and display the result.
8. Restore the complete hierarchy when the query is cleared.

## Output

The following image illustrates the AI-powered natural language file search in the .NET MAUI TreeView.

![AI-Powered Natural Language File Search in .NET MAUI TreeView](Images/ai-search-treeview.gif)

You can find the complete sample from this [GitHub link](https://github.com/SyncfusionExamples/ai-powered-natural-language-file-search-net-maui-treeview).
