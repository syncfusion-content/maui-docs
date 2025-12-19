---
layout: post
title: Getting Started with .NET MAUI Radial Gauge control | Syncfusion
description: Learn here all about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Radial Gauge(SfRadialGauge) control and more.
platform: maui
control: SfRadialGauge
documentation: ug
---

# Getting Started with .NET MAUI Radial Gauge

This section explains the steps required to add the [`.NET MAUI Radial Gauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html) control and its elements such as axis, range, pointer, and annotation. This section covers only basic features needed to get started with Syncfusion<sup>&reg;</sup> radial gauge control. Follow the steps below to add a .NET MAUI Radial gauge control to your project.

To get start quickly with our .NET MAUI Radial Gauge, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=gagnYotFp48"%}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install .NET SDK
  - [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later must be installed.
2. Set up a .NET MAUI Environment with Visual Studio. Supported Visual Studio Versions:
  - Visual Studio 2022: Version 17.13 or later (e.g., 17.14.7) for .NET 9 development.
  - Visual Studio 2026: Required for .NET 10 development.

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Radial Gauge NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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

## Step 4: Add .NET MAUI Radial Gauge control

1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfRadialGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html).

{% capture codesnippet1 %}

{% tabs %}

{% highlight xaml %}

xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;

{% endhighlight %}

{% endtabs %}

{% endcapture %}

{{ codesnippet1 | UnOrderList_Indent_Level_1 }} 

* Initialize the SfRadialGauge control

{% capture codesnippet2 %}

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge />

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

{% endcapture %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code. 
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Radial Gauge NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Gauges` to install the Syncfusion<sup>®</sup> .NET MAUI Gauges NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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

## Step 4: Add .NET MAUI Radial Gauge control

1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfRadialGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html).

{% capture codesnippet1 %}

{% tabs %}

{% highlight xaml %}

xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;

{% endhighlight %}

{% endtabs %}

{% endcapture %}

{{ codesnippet1 | UnOrderList_Indent_Level_1 }} 

* Initialize the SfRadialGauge control

{% capture codesnippet2 %}

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge />

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

{% endcapture %}

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Radial Gauge Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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

## Step 4: Add .NET MAUI Radial Gauge control

1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfRadialGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html).

{% capture codesnippet1 %}

{% tabs %}

{% highlight xaml %}

xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Gauges;

{% endhighlight %}

{% endtabs %}

{% endcapture %}

{{ codesnippet1 | UnOrderList_Indent_Level_1 }} 

* Initialize the SfRadialGauge control

{% capture codesnippet2 %}

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge />

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

{% endcapture %}

{% endtabcontent %}
{% endtabcontents %}

{{ codesnippet2 | UnOrderList_Indent_Level_1 }} 

## Add axis to the radial gauge

Axes contain a list of axis elements, to which you can add any number of radial axes inside the gauge. You can specify the minimum and maximum values of axis using the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Minimum) and [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Maximum) properties as demonstrated in the following code sample.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Minimum="0"
                          Maximum="150" />
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();
RadialAxis radialAxis = new RadialAxis();
radialAxis.Minimum = 0;
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);
this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge with Axis](images/getting-started/maui-radial-gauge-with-axis.png)

## Add range to the radial gauge

Ranges contain a list of range elements, to which you can add any number of ranges inside the axis. You can specify the start value, end value, and background color for range using the [`StartValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_StartValue), [`EndValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_EndValue), and [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html#Syncfusion_Maui_Gauges_RadialRange_Fill) properties as demonstrated in the following code sample.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis Interval="10"
                          Maximum="150" >
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="0"
                                  EndValue="50"
                                  Fill="Red" />
                        <gauge:RadialRange StartValue="50"
                                  EndValue="100"
                                  Fill="Orange" />
                        <gauge:RadialRange StartValue="100"
                                  EndValue="150"
                                  Fill="Green" />
                    </gauge:RadialAxis.Ranges>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

            RadialAxis radialAxis = new RadialAxis();
            radialAxis.Maximum = 150;
            sfRadialGauge.Axes.Add(radialAxis);

            RadialRange gaugeRange1 = new RadialRange();
            gaugeRange1.StartValue = 0;
            gaugeRange1.EndValue = 50;
            gaugeRange1.Fill = new SolidColorBrush(Colors.Red);
            radialAxis.Ranges.Add(gaugeRange1);

            RadialRange gaugeRange2 = new RadialRange();
            gaugeRange2.StartValue = 50;
            gaugeRange2.EndValue = 100;
            gaugeRange2.Fill = new SolidColorBrush(Colors.Orange);
            radialAxis.Ranges.Add(gaugeRange2);

            RadialRange gaugeRange3 = new RadialRange();
            gaugeRange3.StartValue = 100;
            gaugeRange3.EndValue = 150;
            gaugeRange3.Fill = new SolidColorBrush(Colors.Green);
            radialAxis.Ranges.Add(gaugeRange3);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge with Range](images/getting-started/maui-radial-gauge-with-range.png)

## Add pointer to the radial gauge

Pointers contains a list of pointer elements, where you can add any number of gauge pointers such as [`NeedlePointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.NeedlePointer.html), [`RangePointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RangePointer.html) and [`MarkerPointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.MarkerPointer.html) inside the axis to indicate the value.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Maximum="150"
                          Interval="10">
..
            <gauge:RadialAxis.Pointers>
                <gauge:NeedlePointer Value="90" />
            </gauge:RadialAxis.Pointers>
        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);
..

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 90;
radialAxis.Pointers.Add(needlePointer);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Radial Gauge with Pointer](images/getting-started/maui-radial-gauge-with-pointer.png)

## Add annotation to the radial gauge

You can add any number of views such as text or image as an annotation inside the axis. The position of annotation can be customized using the [`DirectionUnit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionUnit) [`DirectionValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_DirectionValue) and [`PositionFactor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html#Syncfusion_Maui_Gauges_GaugeAnnotation_PositionFactor) properties as demonstrated in the following code.

{% tabs %}

{% highlight xaml %}

<gauge:SfRadialGauge>
    <gauge:SfRadialGauge.Axes>
        <gauge:RadialAxis Maximum="150"
                          Interval="10">
            ..
                   <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation x:Name="annotation"
                                       DirectionUnit="Angle"
                                       DirectionValue="90"
                                       PositionFactor="0.5">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="90"
                                   FontSize="25"
                                   FontAttributes="Bold" 
                                       TextColor="Black"/>
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>

        </gauge:RadialAxis>
    </gauge:SfRadialGauge.Axes>
</gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);
..

GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.Angle;
            gaugeAnnotation.DirectionValue = 90;
            gaugeAnnotation.PositionFactor = 0.5;
            gaugeAnnotation.Content = new Label() 
            {
                Text = "90", 
                FontAttributes = FontAttributes.Bold, 
                FontSize = 25,
                TextColor = Colors.Black
            };
            radialAxis.Annotations.Add(gaugeAnnotation);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

![MAUI Radial Gauge with Annotation](images/getting-started/maui-radial-gauge-with-annotation.png)

The following code example gives you the complete code of above configurations.

{% tabs %}

{% highlight xaml %}

 <gauge:SfRadialGauge>
            <gauge:SfRadialGauge.Axes>
                <gauge:RadialAxis Interval="10"
                          Maximum="150" >
                    <gauge:RadialAxis.Ranges>
                        <gauge:RadialRange StartValue="0"
                                  EndValue="50"
                                  Fill="Red" />
                        <gauge:RadialRange StartValue="50"
                                  EndValue="100"
                                  Fill="Orange" />
                        <gauge:RadialRange StartValue="100"
                                  EndValue="150"
                                  Fill="Green" />
                    </gauge:RadialAxis.Ranges>
                    <gauge:RadialAxis.Pointers>
                        <gauge:NeedlePointer Value="90" />
                    </gauge:RadialAxis.Pointers>
                    <gauge:RadialAxis.Annotations>
                        <gauge:GaugeAnnotation x:Name="annotation"
                                       DirectionUnit="Angle"
                                       DirectionValue="90"
                                       PositionFactor="0.5">
                            <gauge:GaugeAnnotation.Content>
                                <Label Text="90"
                                   FontSize="25"
                                   FontAttributes="Bold" 
                                       TextColor="Black"/>
                            </gauge:GaugeAnnotation.Content>
                        </gauge:GaugeAnnotation>
                    </gauge:RadialAxis.Annotations>
                </gauge:RadialAxis>
            </gauge:SfRadialGauge.Axes>
        </gauge:SfRadialGauge>

{% endhighlight %}

{% highlight c# %}

SfRadialGauge sfRadialGauge = new SfRadialGauge();

RadialAxis radialAxis = new RadialAxis();
radialAxis.Maximum = 150;
sfRadialGauge.Axes.Add(radialAxis);

GaugeRange gaugeRange1 = new GaugeRange();
gaugeRange1.StartValue = 0;
gaugeRange1.EndValue = 50;
gaugeRange1.Background = new SolidColorBrush(Colors.Red);
radialAxis.Ranges.Add(gaugeRange1);

GaugeRange gaugeRange2 = new GaugeRange();
gaugeRange2.StartValue = 50;
gaugeRange2.EndValue = 100;
gaugeRange2.Background = new SolidColorBrush(Colors.Orange);
radialAxis.Ranges.Add(gaugeRange2);

GaugeRange gaugeRange3 = new GaugeRange();
gaugeRange3.StartValue = 100;
gaugeRange3.EndValue = 150;
gaugeRange3.Background = new SolidColorBrush(Colors.Green);
radialAxis.Ranges.Add(gaugeRange3);

NeedlePointer needlePointer = new NeedlePointer();
needlePointer.Value = 90;
radialAxis.Pointers.Add(needlePointer);

GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            gaugeAnnotation.DirectionUnit = AnnotationDirection.Angle;
            gaugeAnnotation.DirectionValue = 90;
            gaugeAnnotation.PositionFactor = 0.5;
            gaugeAnnotation.Content = new Label() 
            {
                Text = "90", 
                FontAttributes = FontAttributes.Bold, 
                FontSize = 25,
                TextColor = Colors.Black
            };
radialAxis.Annotations.Add(gaugeAnnotation);

this.Content = sfRadialGauge;

{% endhighlight %}

{% endtabs %}

N> View [`sample`](https://github.com/SyncfusionExamples/MAUI-Radial-Gauge-Getting-Started-) in GitHub

N> You can refer to our [.NET MAUI Radial Gauge](https://www.syncfusion.com/maui-controls/maui-radial-gauge) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Radial Gauge Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Gauges/SampleBrowser.Maui.Gauges/Samples/RadialGauge) that shows you how to render the Radial Gauge in .NET MAUI.