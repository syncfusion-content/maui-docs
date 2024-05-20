---
layout: post
title: Getting Started with Maui Digital Gauge control | Syncfusion
description: Learn here about getting started with Syncfusion Maui Digital Gauge (SfDigitalGauge) control, its elements and more.
platform: Maui
control: DigitalGauge
documentation: ug
---
# Getting Started with Maui Digital Gauge (SfDigitalGauge)

This section explains the steps required to configure the `SfDigitalGauge` and add basic elements to it using various APIs.



You can add SfDigitalGauge reference using one of the following methods:

**Method 1: Adding SfDigitalGauge reference from nuget.org**

Syncfusion Maui components are available in [nuget.org](https://www.nuget.org/). To add SfDigitalGauge to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/25.2.4?_src=template), and then install it.

N> Install the same version of SfDigitalGauge NuGet in all the projects.


## Adding namespace for the assemblies

{% tabs %}

{% highlight xaml %}

xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;

{% endhighlight %}

{% endtabs %}


## Initialize gauge

You can initialize the `SfDigitalGauge`control with a required optimal name using the included namespace.

{% tabs %}

{% highlight xaml %}

     <gauge:SfDigitalGauge/> 

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge sfDigitalGauge = new SfDigitalGauge();

this.Content = sfDigitalGauge;

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

## Setting character type for digital gauge

By using the `CharacterType` property, you can set the segments for digital gauge. The digital characters can be drawn in the following four different segments:

•	SevenSegment

•	FourteenSegment

•	SixteenSegment

•	EightCrossEightDotMatrix

{% tabs %}

{% highlight xaml %}

    <digitalGauge:SfDigitalGauge x:Name="SevenSegmentGauge" CharacterType="SevenSegment" Text="1234" />

{% endhighlight %}

{% highlight c# %}

SfDigitalGauge digital = new SfDigitalGauge();

digital.CharacterType = CharacterType.SevenSegment;

{% endhighlight %}

{% endtabs %}

## Configuring properties

The `CharacterHeight`, `CharacterWidth`, and `CharacterStroke`properties are used to display characters, which can be customized as shown in the following code snippets:

{% tabs %}

{% highlight xaml %}

       <gauge:SfDigitalGauge  CharacterHeight="60" CharacterWidth="25" 
                                                    
                          CharacterStrokeColor="#146CED"/>


{% endhighlight %}

{% highlight c# %}

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.CharacterHeight = 60;

            digital.CharacterWidth = 25;

            digital.CharacterStrokeColor = Color.FromRgb(20, 108, 237);

{% endhighlight %}

{% endtabs %}

The following code example is the complete code of the previous configurations.

{% tabs %}

{% highlight xaml %}

     <?xml version="1.0" encoding="utf-8" ?>
       <ContentPage  xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"
             xmlns:local="clr-namespace:SampleBrowser.Maui.Gauges.SfDigitalGauge"
             x:Class="SampleBrowser.Maui.Gauges.SfDigitalGauge.GettingStarted">

            <gauge:SfDigitalGauge Text="1234"
                                CharacterStroke="LightBlue"
                                DisabledSegmentStroke="LightGreen"
                                CharacterHeight="50"
                                CharacterWidth="40"
                                StrokeWidth="40"
                                CharacterType="SevenSegment"/>
         </ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;

namespace Syncfusion.Maui.Gauges.SfDigitalGauge

{

    public partial class MainPage : ContentPage

    {

        public MainPage()
        {
            InitializeComponent();

            //Initialize digital gauge

            SfDigitalGauge digital = new SfDigitalGauge();

            digital.Time = "1234";

            digital.CharacterHeight = 90;

            digital.CharacterWidth = 25;

            digital.StrokeWidth = 5;

            digital.CharacterType = CharacterType.SevenSegment;

            digital.CharacterStroke = Color.FromRgb(20, 108, 237);

            digital.DisabledSegmentStroke = Color.Gray;

        }
    }
}

{% endhighlight %}

{% endtabs %}


