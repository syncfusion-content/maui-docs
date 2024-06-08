---
layout: post
title: Getting Started with .NET MAUI Digital Gauge control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: maui
control: DigitalGauge
documentation: ug
keywords: .net maui, .net maui digital gauge, digital gauge, character segments, digital character, character types, character display types
---
# Getting Started with .NET MAUI Digital Gauge (SfDigitalGauge)

This section explains how to add the .NET MAUI DigitalGauge control. This section covers only the basic features needed to get started with Syncfusion DigitalGauge.

## Creating an application using the .NET MAUI DigitalGauge

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on nuget.org. To add SfDigitalGauge to your project,
open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Gauges, and then install it.

3. To initialize the control, import the control namespace Syncfusion.Maui.Gauges in XAML or C# code.

4. Initialize SfDigitalGauge.

{% tabs %}

{% highlight xaml %}
<ContentPage
. . .
   xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"

   <gauge:SfDigitalGauge/> 
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDigitalGauge sfDigitalGauge = new SfDigitalGauge();
        this.Content = sfDigitalGauge;
    }
}


{% endhighlight %}

{% endtabs %}

### Register the handler

Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# tabtitle="~/MauiProgram.cs" hl_lines="17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace GaugeMauiSample
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

## Display content to the DigitalGauge

In .NET MAUI DigitalGauge user can display value using `Text` property.

{% tabs %}

{% highlight xaml %}

   <gauge:SfDigitalGauge Text="syncfusion"/> 

{% endhighlight %}

{% highlight c# %}

        SfDigitalGauge sfDigitalGauge = new SfDigitalGauge();

        digital.Text = "syncfusion";

        this.Content = sfDigitalGauge;
 
{% endhighlight %}

{% endtabs %}



