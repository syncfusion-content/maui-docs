---
layout: post
title: Getting started with .NET MAUI SfLinearProgressBar control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI SfLinearProgressBar (Progress Bar) control, its elements and more.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Getting started with .NET MAUI SfLinearProgressBar (Linear Progress Bar)

This section explains the steps required to add the linear progress bar control with the progress and its customizable elements such as indeterminate, segment, progress fill, and track fill. This section covers only the basic features needed to know and gets started with the Syncfusion progress bar.

## Creating an application using the .NET MAUI SfLinearProgressBar

* Create a new .NET MAUI application in the Visual Studio.

* The Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfLinearProgressBar to your project, open the NuGet package manager in Visual Studio, and search for [Syncfusion.Maui.ProgressBar] then install that.

### Register the handler

The Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# tabtitle="~/MauiProgram.cs" hl_lines="17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MyProject
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

## Adding namespace

Add the following namespace.

{% tabs %}

{% highlight xaml %}

xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.ProgressBar;

{% endhighlight %}

{% endtabs %}

## Initializing progress bar

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

Run the project, and check if you get following output to make sure that the project has been configured properly to add the progress bar.

![.NET MAUI linear progress bar](images/getting-started/progress-bar.png)

## Enabling indeterminate state

When the progress of a task cannot be shown determinately, you can enable the indeterminate state using the `IsIndeterminate` property to know if any progress is happening in the background.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar IsIndeterminate="True"/>

{% endhighlight %}

{% highlight C# %} 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { IsIndeterminate = true };
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %} 

## Enable segments

To visualize the progress of a multiple sequential task, split the progress bar into the multiple segments by defining the `SegmentCount` property as demonstrated in the following code sample.

{% tabs %} 

{% highlight xaml %} 

<progressBar:SfLinearProgressBar SegmentCount="4" Progress="75"/>

{% endhighlight %}

{% highlight C# %} 

SfLinearProgressBar linearProgressBar = new SfLinearProgressBar { Progress = 75, SegmentCount = 4 };
this.Content = linearProgressBar;

{% endhighlight %}

{% endtabs %}

![.NET MAUI linear progress bar visualized with multiple sequential task](images/getting-started/segment.png)

## Apply colors

Customize the color of the progress indicator and track by defining the `ProgressFill` and `TrackFill` properties, respectively.

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

![.NET MAUI linear progress bar with customized colors](images/getting-started/style.png)

N> 
* Get the complete getting started sample from `GitHub` link.
* Refer to our `.NET MAUI linear progress bar` feature tour page for its groundbreaking feature representations.