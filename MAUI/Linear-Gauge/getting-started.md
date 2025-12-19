---
layout: post
title: Getting started with .NET MAUI Linear Gauge control | Syncfusion
description: Learn here about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Linear Gauge (SfLinearGauge) control, its elements, and more. 
platform: maui
control: SfLinearGauge
documentation: ug
---

# Getting Started with .NET MAUI Linear Gauge

This section explains the steps required to add the [`.NET MAUI Linear Gauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1) control and its elements such as scale, range, and pointer. This section covers only basic features needed to get started with Syncfusion<sup>&reg;</sup> linear gauge control. Follow the steps below to add a .NET MAUI Linear gauge control to your project.

To get start quickly with our .NET MAUI Linear Gauge, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=wclf360zOPc"%}

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

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Gauges NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion core.

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

## Step 4: Add .NET MAUI Linear gauge control

1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

    <gauge:SfLinearGauge />

</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Gauges;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfLinearGauge gauge = new SfLinearGauge();
        this.Content = gauge;
    }
}

{% endhighlight %}
{% endtabs %}


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

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI Gauges NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Gauges` to install the Syncfusion<sup>®</sup> .NET MAUI Gauges NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion core.

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

## Step 4: Add .NET MAUI Linear gauge control

1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

    <gauge:SfLinearGauge />

</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Gauges;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfLinearGauge gauge = new SfLinearGauge();
        this.Content = gauge;
    }
}

{% endhighlight %}
{% endtabs %}

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Gauges NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> controls of .NET MAUI. In the **MauiProgram.cs** file, register the handler for Syncfusion core.

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

## Step 4: Add .NET MAUI Linear gauge control

1. To initialize the control, import the `Syncfusion.Maui.Gauges` namespace into your code.
2. Initialize [SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges">

    <gauge:SfLinearGauge />

</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Gauges;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfLinearGauge gauge = new SfLinearGauge();
        this.Content = gauge;
    }
}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

## Add range to the linear gauge

Ranges contain a list of range elements, to which you can add any number of ranges inside the scale. You can specify the start value, end value, and background color for range using the [`StartValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_StartValue), [`EndValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_EndValue), and [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html#Syncfusion_Maui_Gauges_LinearRange_Fill) properties as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange/>
                </gauge:SfLinearGauge.Ranges>
            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

 SfLinearGauge gauge = new SfLinearGauge();
        LinearRange range = new LinearRange();
        gauge.Ranges.Add(range);
        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear Gauge with Range](images/getting-started/maui-linear-gauge-with-range.PNG)

## Add pointer to the linear gauge

Pointers contain a list of pointer elements, in which you can add any number of gauge pointers such as [`BarPointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html), [`ShapePointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ShapePointer.html), and [`ContentPointer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.ContentPointer.html) inside the scale to indicate the value.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge>
                ..
                 <gauge:SfLinearGauge.MarkerPointers>

                    <gauge:LinearShapePointer Value="70"/>

                    <gauge:LinearContentPointer Value="80">
                        <gauge:LinearContentPointer.Content>
                            <Image Source="pin.png" HeightRequest="20" 
                                   WidthRequest="20"/>
                        </gauge:LinearContentPointer.Content>
                    </gauge:LinearContentPointer>
                </gauge:SfLinearGauge.MarkerPointers>

                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value="60"/>
                </gauge:SfLinearGauge.BarPointers>

            </gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
        ...

        LinearShapePointer shapePointer = new LinearShapePointer();
        shapePointer.Value = 70;
        gauge.MarkerPointers.Add(shapePointer);

        LinearContentPointer contentPointer = new LinearContentPointer();
        contentPointer.Value = 80;
        contentPointer.Content = new Image() { Source = "pin.png", HeightRequest = 20, WidthRequest = 20 };
        gauge.MarkerPointers.Add(contentPointer);

        BarPointer barPointer = new BarPointer();
        barPointer.Value = 60;
        gauge.BarPointers.Add(barPointer);
        this.Content = gauge;


{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear Gauge with Pointer](images/getting-started/maui-linear-gauge-with-pointer.PNG)

The following code example gives you the complete code of above configurations.

{% tabs %}

{% highlight xaml %}

  <gauge:SfLinearGauge x:Name="gauge" >
                <gauge:SfLinearGauge.Ranges>
                    <gauge:LinearRange/>
                </gauge:SfLinearGauge.Ranges>

                <gauge:SfLinearGauge.MarkerPointers>
                    <gauge:LinearShapePointer Value="70"/>

                    <gauge:LinearContentPointer Value="80">
                        <gauge:LinearContentPointer.Content>
                            <Image Source="pin.png" HeightRequest="20" 
                                   WidthRequest="20"/>
                        </gauge:LinearContentPointer.Content>
                    </gauge:LinearContentPointer>
                </gauge:SfLinearGauge.MarkerPointers>

                <gauge:SfLinearGauge.BarPointers>
                    <gauge:BarPointer Value = "60"/>
                </gauge:SfLinearGauge.BarPointers>
            </gauge:SfLinearGauge>


{% endhighlight %}

{% highlight c# %}

 SfLinearGauge gauge = new SfLinearGauge();
        
        LinearRange range = new LinearRange();
        gauge.Ranges.Add(range);
        
        LinearShapePointer shapePointer = new LinearShapePointer();
        shapePointer.Value = 70;
        gauge.MarkerPointers.Add(shapePointer);

        LinearContentPointer contentPointer = new LinearContentPointer();
        contentPointer.Value = 80;
        contentPointer.Content = new Image() { Source = "pin.png", HeightRequest = 20, WidthRequest = 20 };
        gauge.MarkerPointers.Add(contentPointer);

        BarPointer barPointer = new BarPointer();
        barPointer.Value = 60;
        gauge.BarPointers.Add(barPointer);

        this.Content = gauge;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Linear Gauge](images/getting-started/maui-linear-gauge.PNG)

N> View [`sample`](https://github.com/SyncfusionExamples/MAUI-Linear-Gauge-Getting-started-) in GitHub

N> You can refer to our [.NET MAUI Linear Gauge](https://www.syncfusion.com/maui-controls/maui-linear-gauge) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Linear Gauge Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Gauges/SampleBrowser.Maui.Gauges/Samples/LinearGauge) that shows you how to render the Linear Gauge in .NET MAUI.