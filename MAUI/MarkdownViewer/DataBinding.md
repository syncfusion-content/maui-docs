---
layout: post
title: Markdown Content Sources in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to load Markdown content from strings, local files, embedded resources, and URLs in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# Loading Markdown Content in .NET MAUI MarkdownViewer

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control supports flexible input sources, allowing developers to load Markdown content from strings, local files, embedded resources, and external URLs.

## From String

Assign a Markdown-formatted string to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control to render markdown content directly within your application.

{% tabs %} 
{% highlight xaml %}

<ContentPage>
    <markdown:SfMarkdownViewer>
        <markdown:SfMarkdownViewer.Source>
            <x:String>
                <![CDATA[
    # What is the Markdown Viewer?  
    The Markdown Viewer is a UI control in .NET MAUI that allows developers to render Markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

    # Header 1  
    Used for the main title or top-level heading in a Markdown document. 

    ## Header 2  
    Used to define major sections within your Markdown content.
                ]]>
            </x:String>
        </markdown:SfMarkdownViewer.Source>
    </markdown:SfMarkdownViewer>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerGettingStarted
{
    public partial class MainPage : ContentPage
    {
        private const string markdownContent = @"
# What is the Markdown Viewer?  
The Markdown Viewer is a UI control in .NET MAUI that allows developers to render Markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

# Header 1  
Used for the main title or top-level heading in a Markdown document. 

## Header 2  
Used to define major sections within your Markdown content.";
        
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

To load Markdown content from a local `.md` file, you can directly specify the file path and read its contents using standard file I/O and assign its content to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html).

Use the following code-behind to read the file and assign its content to the Markdown Viewer:

**C#**

{% highlight C# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        string filePath = @"D:\MAUI\MarkdownViewer\Files\MarkdownContent.md";
        string markdownContent = File.ReadAllText(filePath);
        markdownViewer.Source = markdownContent;
        Content = markdownViewer;  
    }
}

{% endhighlight %}

## From Embedded Resource

1. To load Markdown content from an embedded resource, place the `.md` file inside the `Resources` folder of your .NET MAUI project. 
2. Use asynchronous file access to read and assign the content to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control.

Refer to the following code-behind to read the embedded resource and assign its content to the Markdown Viewer:

**C#**

{% highlight C# %}

public partial class MainPage : ContentPage
{
    SfMarkdownViewer markdownViewer;

    public MainPage()
    {
        InitializeComponent();
        markdownViewer = new SfMarkdownViewer();
        _ = LoadMarkdownAsync();
        Content = markdownViewer;  
    }

    private async Task LoadMarkdownAsync()
    {
        using Stream stream = await FileSystem.OpenAppPackageFileAsync("MarkdownContent.md");
        using StreamReader reader = new StreamReader(stream, Encoding.UTF8);
        string markdownContent = await reader.ReadToEndAsync();
        markdownViewer.Source = markdownContent;
    }
}

{% endhighlight %}

## From URL

Markdown content can be loaded directly from a publicly accessible URL. This is useful for displaying remote documentation, release notes, or any Markdown file hosted online.

{% tabs %}
{% highlight xaml %}

<ContentPage>

    <markdown:SfMarkdownViewer Source="https://raw.githubusercontent.com/SyncfusionExamples/GettingStarted_DockLayout_MAUI/refs/heads/master/README.md">
    </markdown:SfMarkdownViewer>

</ContentPage>

{% endhighlight %}

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
