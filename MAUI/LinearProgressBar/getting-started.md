---
layout: post
title: Getting started with .NET MAUI Linear ProgressBar control | Syncfusion<sup>&reg;</sup>
description: Learn here about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Linear ProgressBar (SfLinearProgressBar) control, its elements and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Getting started with .NET MAUI Linear ProgressBar

This section explains the steps required to add the linear progress bar control with the progress and its customizable elements such as indeterminate, segment, progress fill, and track fill. This section covers only the basic features needed to know and gets started with the Syncfusion<sup>&reg;</sup> linear progress bar. Follow the steps below to add a .NET MAUI Linear progress bar control to your project.

To get start quickly with our .NET MAUI Linear ProgressBar, check the following video.

{% youtube
"youtube:https://www.youtube.com/watch?v=DY29ko7PTXg&t"%}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

{% tabcontents %}
{% tabcontent Visual Studio %}

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

{% endtabcontent %}
{% endtabcontents %}

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Linear ProgressBar NuGet Package

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

## Step 4: Add .NET MAUI Linear progress bar control

1. To initialize the control, import the `Syncfusion.Maui.ProgressBar` namespace into your code.
2. Initialize [SfLinearProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html).

{% tabs %}

{% highlight xaml %}

xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ProgressBar;

{% endhighlight %}

{% endtabs %}

Create an instance for the linear progress bar control, and add it as content.

{% tabs %}

{% highlight xaml %}

<progressBar:SfLinearProgressBar Progress="75"/>

{% endhighlight %}

{% highlight c# %}

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { Progress = 75 };
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %}

N> By default, the value of progress should be specified between 0 and 100. To determine the progress value between 0 and 1, set the Minimum property to 0 and the Maximum property to 1.

Run the project, and check if you get following output to make sure that the project has been configured properly to add the linear progress bar.

![.NET MAUI Linear ProgressBar](images/getting-started/progress-bar.png)

## Enabling indeterminate state

When the progress of a task cannot be shown determinately, you can enable the indeterminate state using the [`IsIndeterminate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate) property to know if any progress is happening in the background.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar IsIndeterminate="True"/>

{% endhighlight %}

{% highlight C# %} 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { IsIndeterminate = true };
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar in indeterminate state](images/getting-started/linear-progressbar-indeterminate.gif)

## Enable segments

To visualize the progress of a multiple sequential task, split the linear progress bar into the multiple segments by defining the [`SegmentCount`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount) property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar SegmentCount="4" Progress="75"/>

{% endhighlight %}

{% highlight C# %} 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { Progress = 75, SegmentCount = 4 };
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear ProgressBar visualized with multiple sequential task](images/getting-started/segment.png)

## Apply colors

Customize the color of the progress indicator and track by defining the [`ProgressFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill) and [`TrackFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill) properties, respectively.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar Progress="75" 
                                 TrackFill="#33ffbe06" 
                                 ProgressFill="#FFffbe06"/>

<progressBar:SfLinearProgressBar Progress="75"  
                                 TrackFill="#3351483a" 
                                 ProgressFill="#FF51483a"/>

{% endhighlight %}

{% highlight C# %} 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar
{
    Progress = 75, 
    TrackFill = new SolidColorBrush(Color.FromArgb("#33ffbe06")), 
    ProgressFill = new SolidColorBrush(Color.FromArgb("#FFffbe06"))
};

SfLinearProgressBar sfLinearProgressBar = new SfLinearProgressBar
{
    Progress = 75, 
    TrackFill = new SolidColorBrush(Color.FromArgb("#3351483a")), 
    ProgressFill = new SolidColorBrush(Color.FromArgb("#FF51483a"))
};

{% endhighlight %}

{% endtabs %} 

![.NET MAUI Linear ProgressBar with customized colors](images/getting-started/style.png)

N> 
* Get the complete getting started sample from [GitHub](https://github.com/SyncfusionExamples/Getting-started-with-.NET-MAUI-Linear-ProgressBar-control-) link.
* Refer to our [.NET MAUI Linear ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations.