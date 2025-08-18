---
layout: post
title: Markdown Content Sources in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to load Markdown content from strings, local files, embedded resources, and URLs in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: MarkdownViewer
documentation: ug
---

# Loading Markdown Content in .NET MAUI MarkdownViewer

The (SfMarkdownViewer)[] control supports flexible input sources, allowing developers to load Markdown content from strings, local files, embedded resources, and external URLs.

## From String

Assign a Markdown-formatted string to the `Source` property of the SfMarkdownViewer control to render markdown content directly within your application.

{% tabs %} 

{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerGettingStarted
{
    public partial class MainPage : ContentPage
    {
        private const string GettingStartedMarkdown = @"# What is Markdown Viewer?  
Markdown View is a UI control in .NET MAUI that allows developers to render Markdown content with full formatting support. It is designed to work efficiently across both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks, etc.

# Header 1  
Used for the main title or top-level heading in a Markdown document. 

## Header 2  
Used to define major sections within your Markdown content.

![image](https://cdn.syncfusion.com/content/images/Xamarin/Mascot-1.png)
";
        
        public MainPage()
        {
            InitializeComponent();  
            SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
            markdownViewer.Source = GettingStartedMarkdown;
            Content = markdownViewer;       
        }
    }   
}

{% endhighlight %}

{% endtabs %}

## From Local File

To load Markdown content from a local file, use the `FilePicker` API to select a `.md` file. Once selected, read the file asynchronously and assign its content to the `Source` property of the `SfMarkdownViewer`.

{% tabs %}
{% highlight C# %}

private async void OnPickFileClicked(object sender, EventArgs e)
{
    var result = await FilePicker.Default.PickAsync(new PickOptions
    {
        PickerTitle = "Select a Markdown file"
    });

    if (result != null)
    {
        using var stream = await result.OpenReadAsync();
        using var reader = new StreamReader(stream);
        MarkdownViewer.Source = await reader.ReadToEndAsync();
    }
}

{% endhighlight %}
{% endtabs %}

## From Embedded Resource

1. To load Markdown content from an embedded resource, place the `.md` file inside the `Resources` folder of your .NET MAUI project. 
2. Use asynchronous file access to read and assign the content to the `Source` property of the `SfMarkdownViewer` control.

{% tabs %}
{% highlight C# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        _ = LoadMarkdownAsync();
        Content = markdownViewer;  
    }

    private async Task LoadMarkdownAsync()
    {
        using Stream stream = await FileSystem.OpenAppPackageFileAsync("MarkdownContent.md");
        using StreamReader reader = new StreamReader(stream, Encoding.UTF8);
        string markdownContent = await reader.ReadToEndAsync();
        MarkdownView.Source = markdownContent;
    }
}

{% endhighlight %}
{% endtabs %}

## From URL

Markdown content can be loaded directly from a publicly accessible URL. This is useful for displaying remote documentation, release notes, or any Markdown file hosted online.

{% tabs %}
{% highlight C# %}

public partial class MainPage : ContentPage
{ 
    public MainPage()
    {
        InitializeComponent();  
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        markdownViewer.Source = "https://raw.githubusercontent.com/SyncfusionExamples/GettingStarted_DockLayout_MAUI/refs/heads/master/README.md";
        Content = markdownViewer;       
    }
} 

{% endhighlight %}
{% endtabs %}
