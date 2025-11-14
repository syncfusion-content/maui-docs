---
layout: post
title: Getting started with .NET MAUI MarkdownViewer control | Syncfusion
description: Learn how to get started with Syncfusion® .NET MAUI SfMarkdownViewer control and explore its capabilities for rendering Markdown content.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
keywords: .net maui markdownviewer, syncfusion markdownviewer maui, markdown viewer .net maui, .net maui markdown rendering, sfmarkdownviewer example maui, .net maui markdown control, markdown content .net maui, markdown rendering .net maui
---

# Getting Started with .NET MAUI MarkdownViewer (SfMarkdownViewer)

This guide details the initial setup and basic usage of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control, offering insight into its ability to render Markdown content with various formatting capabilities across mobile and desktop platforms.

To get start quickly with our [.NET MAUI MarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html), you can check the below video.

{% youtube "https://www.youtube.com/watch?v=4wHEDadFrxM" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.8 or later).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI MarkdownViewer NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for `Syncfusion.Maui.MarkdownViewer` and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the Handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion® controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion® core.

{% tabs %}

{% highlight C# tabtitle="MauiProgram.cs" hl_lines="2 13" %}

using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MarkdownViewerGettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Initialize the MarkdownViewer Control

1. To initialize the control, import the `Syncfusion.Maui.MarkdownViewer` namespace.
2. Add an [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) instance to your page.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:markdown="clr-namespace:Syncfusion.Maui.MarkdownViewer;assembly=Syncfusion.Maui.MarkdownViewer">

    <markdown:SfMarkdownViewer />
    
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();  
            SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
            Content = markdownViewer;       
        }
    }   
}

{% endhighlight %}
{% endtabs %}
{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P`, type **.NET:New Project** and press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI MarkdownViewer NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.MarkdownViewer` to install the  Syncfusion® NET MAUI MarkdownViewer package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler
[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) nuget is a dependent package for all Syncfusion® controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion® core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MarkdownViewerSample
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
        .UseMauiApp<App>()
        .ConfigureSyncfusionCore()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        });

        return builder.Build();
     }
  }
}     

{% endhighlight %}
{% endtabs %}

## Step 4: Initialize the MarkdownViewer Control

1. To initialize the control, import the `Syncfusion.Maui.MarkdownViewer` namespace.
2. Add an [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) instance to your page.

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:markdown="clr-namespace:Syncfusion.Maui.MarkdownViewer;assembly=Syncfusion.Maui.MarkdownViewer">

    <markdown:SfMarkdownViewer />

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();  
            SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
            Content = markdownViewer;    
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI MarkdownViewer NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for `Syncfusion.Maui.MarkdownViewer` and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the Handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion<sup>®</sup> core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MarkdownViewerSample
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
        .UseMauiApp<App>()
        .ConfigureSyncfusionCore()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        });

        return builder.Build();
     }
  }
}     

{% endhighlight %}
{% endtabs %}

## Step 4: Initialize the MarkdownViewer Control

1. To initialize the control, import the `Syncfusion.Maui.MarkdownViewer` namespace.
2. Add an [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) instance to your page.

{% tabs %} 
{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:markdown="clr-namespace:Syncfusion.Maui.MarkdownViewer;assembly=Syncfusion.Maui.MarkdownViewer">

    <markdown:SfMarkdownViewer />

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();  
            SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
            Content = markdownViewer;    
        }
    }   
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

## Step 5: Add Source to the SfMarkdownViewer

To display Markdown content, assign a string to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control. This string can contain standard Markdown syntax such as headings, bold text, lists, and images.

{% tabs %} 
{% highlight xaml %}

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

### Table 

|              | Column 1 | Column 2 | Column 3 |
|--------------|----------|----------|----------|
| Row 1        | Content  | Content  | Content  |
| Row 2        | Content  | Content  | Content  |
| Row 3        | Content  | Content  | Content  |
            ]]>
        </x:String>
    </markdown:SfMarkdownViewer.Source>
</markdown:SfMarkdownViewer>

{% endhighlight %}

{% highlight C# %}

public partial class MainPage : ContentPage
{
        private const string markdownContent = @"# What is the Markdown Viewer?  
            The Markdown Viewer is a UI control in .NET MAUI that allows developers to render Markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

            # Header 1  
            Used for the main title or top-level heading in a Markdown document. 

            ## Header 2  
            Used to define major sections within your Markdown content.

            ### Table 

            |              | Column 1 | Column 2 | Column 3 |
            |--------------|----------|----------|----------|
            | Row 1        | Content  | Content  | Content  |
            | Row 2        | Content  | Content  | Content  |
            | Row 3        | Content  | Content  | Content  |";

    public MainPage()
    {
        InitializeComponent();  
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        markdownViewer.Source = markdownContent;
        Content = markdownViewer;       
    }
}  

{% endhighlight %}
{% endtabs %}

N> For more details about binding Markdown content from various sources, refer to [MarkdownSources](/MarkdownSources.md).

![Output of Markdown Viewer](Images/maui-markdown-viewer-gettingstarted.png)

You can access a complete getting started sample [here](https://github.com/SyncfusionExamples/.NET_MAUI_Markdown_Viewer_GettingStarted).
