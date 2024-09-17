---
layout: post
title: Getting started with .NET MAUI Slider control | Syncfusion
description: This section explains about the getting started with Syncfusion MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Getting Started with .NET MAUI Slider

This section guides you through setting up and configuring a [Slider](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html) in your .NET MAUI application. Follow the steps below to add a basic Slider to your project.

To get start quickly with MAUI SfSlider, you can check on this video:

<style>#MAUISliderVideoTutorial{width : 90% !important; height: 350px !important }</style>
<iframe id='MAUISliderVideoTutorial' src='https://www.youtube.com/embed/eBSzMk9bi08'></iframe>

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio
1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location, then click **Next**.
3. Select the .NET framework version and click **Create**.

### Visual Studio Code
1. Open the command palette by pressing `Ctrl+Shift+P`` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press enter.
Then choose **Create project**

## Step 2: Install the Syncfusion MAUI Sliders NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Sliders](https://www.nuget.org/packages/Syncfusion.Maui.Sliders) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the Handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace SliderGettingStarted
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

## Step 4: Add a Basic Slider control

Import the [SfSlider](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html) namespace and initialize the slider as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders">
    <Grid>
        <sliders:SfSlider />
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Sliders;

namespace SliderGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfSlider slider = new SfSlider();
            this.content = slider;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Initialize slider](images/getting-started/initialize-slider.png)

## Enable labels

The [ShowLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels) property enables the labels which renders on given interval.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0"
                  Maximum="10"
                  Value="5"
                  ShowLabels="True"
                  Interval="2" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 0,
    Maximum = 10,
    Value = 5,
    Interval = 2,
    ShowLabels = true,
};

{% endhighlight %}

{% endtabs %}

![Slider labels](images/getting-started/labels.png)

## Enable ticks

The [ShowTicks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks) property enables the ticks in the range selector, while the [MinorTicksPerInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval) property enables the minor ticks between the major ticks.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0"
                  Maximum="10"
                  Value="5"
                  Interval="2"
                  ShowTicks="True"
                  ShowLabels="True"
                  MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 0,
    Maximum = 10,
    Value = 5,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
    MinorTicksPerInterval = 1
};

{% endhighlight %}

{% endtabs %}

![Slider ticks](images/getting-started/ticks.png)

## Orientation

The [Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Orientation) property allows you to show the slider in both horizontal and vertical directions. The default value of the [Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Orientation) property is `Horizontal`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Orientation="Vertical"
                  Minimum="0"
                  Maximum="10"
                  Value="5"
                  Interval="2"
                  ShowLabels="True"
                  ShowTicks="True"
                  MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Orientation = SliderOrientation.Vertical,
    Minimum = 0,
    Maximum = 10,
    Value = 5,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
    MinorTicksPerInterval = 1
};

{% endhighlight %}

{% endtabs %}

![Slider orientation](images/getting-started/orientation.png)

## Inverse the slider

Invert the slider using the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property. The default value of the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property is `False`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0"
                  Maximum="10"
                  Value="5"
                  IsInversed="True"
                  Interval="2"
                  ShowTicks="True"
                  ShowLabels="True"
                  MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 0,
    Maximum = 10,
    Value = 5,
    IsInversed = true,
    Interval = 2,
    ShowLabels = true,
    ShowTicks = true,
    MinorTicksPerInterval = 1
};

{% endhighlight %}

{% endtabs %}

![Inverse slider](images/getting-started/slider-inverse.png)

## Formatting labels

Add prefix or suffix to the labels using the [NumberFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_NumberFormat) property.


{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="20"
                  Maximum="100"
                  Value="60"
                  Interval="20"
                  NumberFormat="$##"
                  ShowLabels="True"
                  ShowTicks="True"
                  MinorTicksPerInterval="1" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 20,
    Maximum = 100,
    Value = 60,
    Interval = 20,
    NumberFormat = "$##",
    ShowLabels = true,
    ShowTicks = true,
    MinorTicksPerInterval = 1
};

{% endhighlight %}

{% endtabs %}

![Slider label format](images/getting-started/label-format.png)

N> You can refer to our [.NET MAUI Slider](https://www.syncfusion.com/maui-controls/maui-slider) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Slider Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Sliders) that shows you how to render the Slider in .NET MAUI.
