---
layout: post
title: Getting Started with .NET MAUI Grid Splitter | Syncfusion®
description: Learn how to customize panes in the Syncfusion® .NET MAUI Grid Splitter control, including content, background, sizing, and collapse behavior.
platform: MAUI
control: SfGridSplitter
documentation: UG
---

# Getting Started with .NET MAUI Grid Splitter

This section guides you through setting up and configuring a [Grid Splitter]() in your .NET MAUI application. Follow the steps below to add a basic Grid Splitter and create resizable panes within your application.

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install https://dotnet.microsoft.com/en-us/download/dotnet/9.0 or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI GridSplitter NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for **Syncfusion.Maui.GridSplitter** and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install https://dotnet.microsoft.com/en-us/download/dotnet/9.0 or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured.

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Choose **Create Project**.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI GridSplitter NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> to open the integrated terminal.
2. Ensure you're in the project root directory where your `.csproj` file is located.
3. Run the following command:

```bash
dotnet add package Syncfusion.Maui.GridSplitter
```

4. Restore NuGet packages using:

```bash
dotnet restore
```

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install https://dotnet.microsoft.com/en-us/download/dotnet/9.0 or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Ensure that the MAUI workloads are installed and configured.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**.
2. Select **.NET MAUI App**.
3. Enter the Project Name, Solution Name, and Location.
4. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI GridSplitter NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for **Syncfusion.Maui.GridSplitter** and install the latest version.
3. Ensure the required dependencies are installed and restored successfully.

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

Add the following namespace.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}

Register the Syncfusion Core handler inside the `CreateMauiApp` method in the `MauiProgram.cs` file.

{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Import GridSplitter namespace

Add the following namespace in your XAML or C# file.

{% tabs %}
{% highlight xaml %}

xmlns:gridSplitter="clr-namespace:Syncfusion.Maui.GridSplitter;assembly=Syncfusion.Maui.GridSplitter"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.GridSplitter;

{% endhighlight %}
{% endtabs %}

## Step 5: Add a Grid Splitter with resizable panes

The [SfGridSplitter]() control manages multiple panes through the `SplitterPanes` collection. Each `SplitterPane` can host any .NET MAUI view and users can resize adjacent panes by dragging the separator.

The following example creates a horizontal Grid Splitter with three resizable panes.

{% tabs %}
{% highlight xaml %}

<gridSplitter:SfGridSplitter>

    <gridSplitter:SplitterPane>
        <VerticalStackLayout Padding="16">
            <Label Text="PARIS"
                    FontSize="20"
                    FontAttributes="Bold" />
            <Label Text="Paris, the city of lights and love." />
        </VerticalStackLayout>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <VerticalStackLayout Padding="16">
            <Label Text="CAMEMBERT"
                   FontSize="20"
                   FontAttributes="Bold" />
            <Label Text="A famous French cheese from Normandy." />
        </VerticalStackLayout>
    </gridSplitter:SplitterPane>

    <gridSplitter:SplitterPane>
        <VerticalStackLayout Padding="16">
            <Label Text="GRENOBLE"
                   FontSize="20"
                   FontAttributes="Bold" />
            <Label Text="Capital city of the French Alps." />
        </VerticalStackLayout>
    </gridSplitter:SplitterPane>

</gridSplitter:SfGridSplitter>

{% endhighlight %}

{% highlight c# %}

SfGridSplitter gridSplitter = new SfGridSplitter();

SplitterPane parisPane = new SplitterPane
{
    Content = new VerticalStackLayout
    {
        Padding = 16,
        Children =
            {
                new Label
                {
                    Text = "PARIS",
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold
                },
                new Label
                {
                    Text = "Paris, the city of lights and love."
                }
            }
    }
};

SplitterPane camembertPane = new SplitterPane
{
    Content = new VerticalStackLayout
    {
        Padding = 16,
        Children =
        {
            new Label
            {
                Text = "CAMEMBERT",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            },
            new Label
            {
                Text = "A famous French cheese from Normandy."
            }
        }
    }
};

SplitterPane grenoblePane = new SplitterPane
{
    Content = new VerticalStackLayout
    {
        Padding = 16,
        Children =
        {
            new Label
            {
                Text = "GRENOBLE",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            },
            new Label
            {
                Text = "Capital city of the French Alps."
            }
        }
    }
};

gridSplitter.AddPane(parisPane);
gridSplitter.AddPane(camembertPane);
gridSplitter.AddPane(grenoblePane);
Content = gridSplitter;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Grid Splitter](Images/getting-started.png)