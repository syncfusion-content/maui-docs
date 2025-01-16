---
layout: post
title: Getting started with .NET MAUI Circular ProgressBar | Syncfusion<sup>&reg;</sup>
description: Learn here about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Circular ProgressBar (SfCircularProgressBar) control, its elements and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# Getting started with .NET MAUI Circular ProgressBar

This section explains the steps required to add the circular progress bar control with the progress and its customizable elements such as indeterminate, segment, progress fill, and track fill. This section covers only the basic features needed to know and gets started with the Syncfusion<sup>&reg;</sup> circular progress bar. Follow the steps below to add a .NET MAUI Circular progress bar to your project.

To get start quickly with our .NET MAUI Circular ProgressBar, check the following video.

{% youtube
"youtube:https://www.youtube.com/watch?v=lH_0-2JEKcM"%}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI Circular ProgressBar NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
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

## Step 4: Add .NET MAUI Circular ProgressBar control

1. To initialize the control, import the `Syncfusion.Maui.ProgressBar` namespace into your code.
2. Initialize [SfCircularProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html).

{% tabs %}

{% highlight xaml %}

xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ProgressBar;

{% endhighlight %}

{% endtabs %}

Create an instance for the circular progress bar control, and add it as content.

{% tabs %}

{% highlight xaml %}

<progressBar:SfCircularProgressBar Progress="75"/>

{% endhighlight %}

{% highlight c# %}

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { Progress = 75 };
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %}

N> By default, the value of progress should be specified between 0 and 100. To determine the progress value between 0 and 1, set the Minimum property to 0 and the Maximum property to 1.

Run the project, and check if you get following output to make sure that the project has been configured properly to add the circular progress bar.

![.NET MAUI Circular ProgressBar](images/getting-started/progress-bar.png)

## Enabling indeterminate state

When the progress of a task cannot be shown determinately, you can enable the indeterminate state using the [`IsIndeterminate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate) property to know if any progress is happening in the background.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfCircularProgressBar IsIndeterminate="True"/>

{% endhighlight %}

{% highlight C# %} 

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { IsIndeterminate = true };
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar in indeterminate state](images/getting-started/circular-progressbar-indeterminate.gif)

## Enable segments

To visualize the progress of a multiple sequential task, split the circular progress bar into the multiple segments by defining the [`SegmentCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount) property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfCircularProgressBar SegmentCount="4" Progress="75"/>

{% endhighlight %}

{% highlight C# %} 

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar { Progress = 75, SegmentCount = 4 };
this.Content = circularProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Circular ProgressBar visualized with multiple sequential task](images/getting-started/segment.png)

## Apply colors

Customize the color of the progress indicator and track by defining the [`ProgressFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill) and [`TrackFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill) properties, respectively.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfCircularProgressBar Progress="75" 
                                   TrackFill="#33c15244" 
                                   ProgressFill="#FFc15244"/>

<progressBar:SfCircularProgressBar Progress="75" 
                                   TrackFill="#3390a84e" 
                                   ProgressFill="#FF90a84e"/>

{% endhighlight %}

{% highlight C# %} 

SfCircularProgressBar circularProgressBar = new SfCircularProgressBar
{
    Progress = 75, 
    TrackFill = new SolidColorBrush(Color.FromArgb("#33c15244")), 
    ProgressFill = new SolidColorBrush(Color.FromArgb("#FFc15244"))
};

SfCircularProgressBar sfCircularProgressBar = new SfCircularProgressBar
{
    Progress = 75, 
    TrackFill = new SolidColorBrush(Color.FromArgb("#3390a84e")), 
    ProgressFill = new SolidColorBrush(Color.FromArgb("#FF90a84e"))
};

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Circular ProgressBar with customized colors](images/getting-started/style.png)

N> 
* Get the complete getting started sample from [GitHub](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-Circular-ProgressBar-control.-) link.
* Refer to our [.NET MAUI Circular ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations.