---
layout: post
title: Loading Markdown Content in .NET MAUI SfMarkdownViewer | Syncfusion
description: Learn how to load markdown content from strings, local files, embedded resources, and URLs in the Syncfusion .NET MAUI SfMarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
keywords: .net maui markdownviewer load markdown, syncfusion markdownviewer source maui, sfmarkdownviewer load from url maui, .net maui markdown embedded resource, .net maui markdownviewer local file, markdown viewer binding maui
---

# Loading Markdown Content in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control supports flexible input sources, allowing developers to load markdown content from strings, local files, embedded resources, and external URLs.

## Prerequisites

Before using the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.MarkdownViewer`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/markdownviewer/gettingstarted) documentation.

## Supported Source Types

| Source | Use Case | Loading Type |
|--------|----------|--------------|
| Inline string | Short, hard-coded content; quick prototyping. | Synchronous assignment. |
| Local file | On-device markdown files (e.g., sample docs shipped with the app). | Synchronous or asynchronous I/O. |
| Embedded resource | Markdown bundled with the app package. | Asynchronous I/O. |
| URL | Remote documentation, release notes, or dynamic content. | Asynchronous fetch (with manual download). |

N> The [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property accepts the markdown text itself; URLs and file paths must be read by the developer and the resulting string assigned to `Source`.

## From String

Assign a markdown-formatted string to the `Source` property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control to render markdown content directly within your application.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:markdown="clr-namespace:Syncfusion.Maui.MarkdownViewer;assembly=Syncfusion.Maui.MarkdownViewer">
    <markdown:SfMarkdownViewer>
        <markdown:SfMarkdownViewer.Source>
            <x:String>
                <![CDATA[
# What is the Markdown Viewer?
The Markdown Viewer is a UI control in .NET MAUI that allows developers to render markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

# Header 1
Used for the main title or top-level heading in a markdown document.

## Header 2
Used to define major sections within your markdown content.
                ]]>
            </x:String>
        </markdown:SfMarkdownViewer.Source>
    </markdown:SfMarkdownViewer>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerLoadingContent
{
    public partial class MainPage : ContentPage
    {
        // A const string is safe here because the value is a compile-time literal.
        private const string markdownContent = @"
# What is the Markdown Viewer?
The Markdown Viewer is a UI control in .NET MAUI that allows developers to render markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

# Header 1
Used for the main title or top-level heading in a markdown document.

## Header 2
Used to define major sections within your markdown content.";

        public MainPage()
        {
            InitializeComponent();
            SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
            markdownViewer.Source = markdownContent;
            Content = markdownViewer;
        }
    }
}

{% endhighlight %}
{% endtabs %}

## From Local File

To load markdown content from a local `.md` file, read its contents using standard file I/O and assign the result to the `Source` property of the `SfMarkdownViewer`. Use a cross-platform path such as `FileSystem.AppDataDirectory` so the same code works on Android, iOS, macOS, and Windows.

{% tabs %}
{% highlight C# %}

using System.IO;
using Microsoft.Maui.Storage;
using Syncfusion.Maui.MarkdownViewer;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        string filePath = Path.Combine(FileSystem.AppDataDirectory, "MarkdownContent.md");
        string markdownContent = File.ReadAllText(filePath);
        markdownViewer.Source = markdownContent;
        Content = markdownViewer;
    }
}

{% endhighlight %}
{% endtabs %}

To pre-bundle a `.md` file with the app, add it to the `Resources/Raw` folder of your .NET MAUI project. Files in `Resources/Raw` are automatically treated as `MauiAsset` and are read using `FileSystem.OpenAppPackageFileAsync`.

## From Embedded Resource

To load markdown content from an embedded resource:

Add the `.md` file to your project. You can place it under `Resources/Raw/` (recommended) or in a subfolder.

{% tabs %}
{% highlight C# %}

using System.Text;
using Microsoft.Maui.Storage;
using Syncfusion.Maui.MarkdownViewer;

public partial class MainPage : ContentPage
{
    private readonly SfMarkdownViewer markdownViewer = new SfMarkdownViewer();

    public MainPage()
    {
        InitializeComponent();
        Content = markdownViewer;
        _ = LoadMarkdownAsync();
    }

    private async Task LoadMarkdownAsync()
    {
        try
        {
            using Stream stream = await FileSystem.OpenAppPackageFileAsync("MarkdownContent.md");
            using StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string markdownContent = await reader.ReadToEndAsync();
            markdownViewer.Source = markdownContent;
        }
        catch (FileNotFoundException ex)
        {
            // Verify the .md file is present, the build action is MauiAsset, and the file name (case-sensitive) matches.
            System.Diagnostics.Debug.WriteLine($"Markdown file not found: {ex.FileName}");
        }
    }
}

{% endhighlight %}
{% endtabs %}

N> The file name passed to `OpenAppPackageFileAsync` is case-sensitive and must match the asset path relative to the project's `Resources/Raw` folder.

## From URL

To load markdown content from a remote URL, download the markdown text using `HttpClient` and assign the result to the `Source` property. The internet permission is granted by default on Android, iOS, macOS, and Windows; no extra configuration is required for HTTPS endpoints.

{% highlight C# %}

using System.Net.Http;
using Syncfusion.Maui.MarkdownViewer;

public partial class MainPage : ContentPage
{
    private readonly SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
    private static readonly HttpClient httpClient = new HttpClient();

    public MainPage()
    {
        InitializeComponent();
        Content = markdownViewer;
        _ = LoadMarkdownFromUrlAsync();
    }

    private async Task LoadMarkdownFromUrlAsync()
    {
        try
        {
            string url = "https://raw.githubusercontent.com/SyncfusionExamples/GettingStarted_DockLayout_MAUI/refs/heads/master/README.md";
            string markdownContent = await httpClient.GetStringAsync(url);
            markdownViewer.Source = markdownContent;
        }
        catch (HttpRequestException ex)
        {
            // The request failed (network error, non-success status code, or invalid URL).
            System.Diagnostics.Debug.WriteLine($"Failed to load markdown: {ex.Message}");
        }
    }
}

{% endhighlight %}

N> Only HTTPS URLs are guaranteed to work on all platforms because some platforms block plain HTTP by default. The fetched content is not cached automatically; cache the response in your own storage layer if you need to reduce repeated network calls.

## Troubleshooting

| Issue | Possible Cause | Recommended Action |
|-------|----------------|--------------------|
| "From Local File" throws `DirectoryNotFoundException`. | The file path is hard-coded to a platform-specific location (e.g., `D:\...`). | Use `FileSystem.AppDataDirectory` or `FileSystem.AppPackageDirectory` for a cross-platform path. |
| "From Embedded Resource" throws `FileNotFoundException`. | The file is missing, the build action is not `MauiAsset`, or the file name passed to `OpenAppPackageFileAsync` does not match exactly. | Verify the file exists, the build action is `MauiAsset`, and the file name is case-sensitive. |
| "From URL" throws `HttpRequestException`. | The device is offline, the URL is unreachable, or the endpoint returns a non-success status code. | Catch `HttpRequestException`, show a user-friendly message, and provide a retry option. |
| Rendered content is empty. | The `Source` property was set before the viewer was added to the visual tree. | Ensure the `SfMarkdownViewer` is part of the page hierarchy before assigning `Source`, or reassign `Source` after the view is loaded. |

## See Also
- [Retrieve Content Programmatically](https://help.syncfusion.com/maui/markdownviewer/contentretrieval)
- [Customize Appearance](https://help.syncfusion.com/maui/markdownviewer/appearance)
- [Apply CSS Style Rules](https://help.syncfusion.com/maui/markdownviewer/overridingdefaultstyles)
